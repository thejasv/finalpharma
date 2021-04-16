
using MedicalRepresentativeSchedule.Models;
using MedicalRepresentativeSchedule.Providers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using log4net;

namespace MedicalRepresentativeSchedule.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RepScheduleController : ControllerBase
    {
        private readonly IRepScheduleProvider _repScheduleProvider;
       

        private static readonly ILog _log = LogManager.GetLogger(typeof(RepScheduleController));
        public RepScheduleController(IRepScheduleProvider repSchedule)
        {
            this._repScheduleProvider = repSchedule;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DateTime startDate)
        {
            try
            {
                var res = await _repScheduleProvider.GetRepScheduleAsync(startDate);
                if (res.Count!=0||res.Any<RepSchedule>())
                {
                    _log.Info("returning schedule");
                    return new OkObjectResult(res);
                }
                else
                {
                    _log.Error("schedule not received");
                    return NotFound("schedule not received");
                }
            }
            catch (Exception e)
            {
                _log.Error("Error while scheduling - " + e.Message);
                return StatusCode(500);
            }
        }
    }
}
