using MedicalRepresentativeSchedule.Models;
using MedicalRepresentativeSchedule.Providers;
using MedicalRepresentativeSchedule.Repositories;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalRepresentativeScheduleTest
{
    class TestProvider
    {
        Mock<IRepScheduleRepository> schedulepro;
        List<DoctorDTO> doctors;
        List<RepresentativeDetailsDTO> representatives;
        List<MedicineStock> stock;
        List<RepSchedule> schedulelist;
        Mock<IMedicineStockProvider> medicineProvider;



        [SetUp]
        public void Setup()
        {
            doctors = new List<DoctorDTO>()
             {
               new DoctorDTO { Name = "doc1",ContactNumber="0987654321" , TreatingAilment="Orthopaedics"},
               new DoctorDTO { Name = "doc2",ContactNumber="0987654321" , TreatingAilment="General"},
               new DoctorDTO { Name = "doc3",ContactNumber="0987654321" , TreatingAilment="Gynecology"},
               new DoctorDTO { Name = "doc4",ContactNumber="0987654321" , TreatingAilment="Orthopaedics"},
            };
            representatives = new List<RepresentativeDetailsDTO>()
            {
                new RepresentativeDetailsDTO{RepresentativeName= "rep1" },
                new RepresentativeDetailsDTO{RepresentativeName= "rep2" },
                new RepresentativeDetailsDTO{RepresentativeName= "rep3" }
            };
            stock = new List<MedicineStock>()
            { new MedicineStock
            {
                Name = "Medicine1",
                ChemicalComposition = new List<string> { "chemical1", "chemical2" },
                TargetAilment = "Orthopaedics",
                DateOfExpiry = DateTime.Parse("10-10-2021"),
                NumberOfTabletsInStock = 50
            },
            new MedicineStock
            {
                Name = "Medicine2",
                ChemicalComposition = new List<string> { "chemical3", "chemical2" },
                TargetAilment = "General",
                DateOfExpiry = DateTime.Parse("10-09-2021"),
                NumberOfTabletsInStock = 50
            },
            new MedicineStock
            {
                Name = "Medicine3",
                ChemicalComposition = new List<string> { "chemical1", "chemical2" },
                TargetAilment = "Gynecology",
                DateOfExpiry = DateTime.Parse("10-10-2021"),
                NumberOfTabletsInStock = 50
            },
            };
            schedulepro = new Mock<IRepScheduleRepository>();
            medicineProvider = new Mock<IMedicineStockProvider>();
            schedulepro.Setup(m => m.GetDoctorDetails()).Returns(doctors);
            schedulepro.Setup(m => m.GetRepresentativesDetails()).Returns(representatives);

        }


        [Test]
        public void TestGetDoctors()
        {
            var pro = new RepScheduleProvider(schedulepro.Object, medicineProvider.Object);
            var res = pro.GetDoctors();
            Assert.IsNotNull(res);
        }

        [Test]
        public void TestGetRepresentatives()
        {
            var pro = new RepScheduleProvider(schedulepro.Object, medicineProvider.Object);
            var res = pro.GetRepresentatives();
            Assert.IsNotNull(res);
        }


        [TestCase("2021/03/04")]
        [TestCase("2021/03/05")]
        [TestCase("2021/03/06")]
        public void Provider_ScheduleMeet(DateTime date1)
        {
            medicineProvider.Setup(s => s.GetMedicineStock()).Returns(Task.FromResult(stock));
            var pro = new RepScheduleProvider(schedulepro.Object, medicineProvider.Object);
            var res = pro.GetRepScheduleAsync(date1);
            Assert.IsNotNull(res);
        }
    }
}
