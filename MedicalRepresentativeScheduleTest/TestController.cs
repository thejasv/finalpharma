using MedicalRepresentativeSchedule.Controllers;
using MedicalRepresentativeSchedule.Models;
using MedicalRepresentativeSchedule.Providers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalRepresentativeScheduleTest
{
    public class TestController
    {
        Mock<IRepScheduleProvider> schedulepro;
        List<Doctor> doctors;
        List<MedicineStock> stock;
        List<RepresentativeDetails> representatives;

        [SetUp]
        public void Setup()
        {
            schedulepro = new Mock<IRepScheduleProvider>();
        }

        [TestCase("2021/04/05")]
        public void TestControllerLayerCorrectInput(DateTime startdate)
        {
            schedulepro.Setup(m => m.GetRepScheduleAsync(It.IsAny<DateTime>())).Returns(Task.FromResult(new List<RepSchedule>(){
                new RepSchedule {
                RepName = "R1", DoctorName = "D1", DateOfMeeting = "05-04-2021", DoctorContactNumber = "9876543210", Medicine = "Aspirin", MeetingSlot = "1-2pm", TreatingAilment = "General"
            }
                }));
            var pro = new RepScheduleController(schedulepro.Object);
            var res = pro.Get(startdate).Result as ObjectResult;
            Assert.AreEqual(res.StatusCode, 200);
        }



        [TestCase("2021/04/05")]
        [TestCase("2021/04/06")]
        public void ScheduleMeetingController_GetMeetingStartDate(DateTime startdate)
        {
            schedulepro.Setup(s => s.GetRepScheduleAsync(startdate)).Returns(Task.FromResult(new List<RepSchedule>()));
            var pro = new RepScheduleController(schedulepro.Object);
            ObjectResult data = pro.Get(startdate).Result as ObjectResult;
            Assert.AreEqual(404, data.StatusCode);
        }
    }
}