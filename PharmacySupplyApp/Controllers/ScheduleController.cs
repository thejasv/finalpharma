using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using log4net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PharmacySupplyApp.Models;
using PharmacySupplyApp.Providers;

namespace PharmacySupplyApp.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly ILog _log = LogManager.GetLogger(typeof(UserController));
        private readonly IRepScheduleProvider _repProvider;
        private string _token;
        public ScheduleController(IRepScheduleProvider repProvider)
        {
            _repProvider = repProvider;
        }

        public IActionResult Index()
        {
            try
            {
                if (HttpContext.Session.GetString("token") == null)
                {
                    _log.Info("token not found");
                    return RedirectToAction("Login", "User");
                }
                else
                {
                    _log.Info("Displaying Index page of Scheduling");
                    string today = DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day;
                    ViewBag.Min = today;
                    return View();
                }
            }
            catch (Exception e)
            {
                _log.Error("Error in ScheduleController while displaying Index page - " + e.Message);
                throw;
            }
        }
        [HttpPost]
        public async Task<IActionResult> Index(ScheduleDate dates)
        {
            try
            {
                if (HttpContext.Session.GetString("token") == null)
                {
                    _log.Info("token not found");
                    return RedirectToAction("Login", "User");
                }
                else
                {
                    _token = HttpContext.Session.GetString("token");
                    HttpResponseMessage response = await _repProvider.GetSchedule(dates.Date, _token);
                    if (response.IsSuccessStatusCode)
                    {
                       
                        var result = response.Content.ReadAsStringAsync().Result;
                        TempData["result"] = result;
                        return RedirectToAction("Schedule");
                    }
                    else if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                        _log.Error("could not schedule");
                        return View("NoSchedule");
                    }
                    else if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        _log.Error("Unauthorized response received from the api");
                        return View("Unauthorized");
                    }
                    else
                    {
                        _log.Error("Error occured in Micro-Service called for scheduling");
                        return View("Error");
                    }
                }
            }
            catch (Exception e)
            {
                _log.Error("Error in Schedule Controller while displaying schedule - " + e.Message);
                return View("Error");
            }
        }

        public IActionResult Schedule()
        {
            try
            {
                if (HttpContext.Session.GetString("token") == null)
                {
                    _log.Info("token not found");
                    return RedirectToAction("Login", "User");
                }
                else
                {
                    List<RepSchedule> schedules =
                        JsonConvert.DeserializeObject<List<RepSchedule>>(TempData["result"].ToString());
                    _repProvider.AddToDb(schedules);
                    return View(schedules);
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
                return View("Error");
            }
        }
    }
}