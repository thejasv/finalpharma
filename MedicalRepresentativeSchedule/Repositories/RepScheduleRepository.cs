using MedicalRepresentativeSchedule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LumenWorks.Framework.IO.Csv;
using System.Data;
using System.IO;

namespace MedicalRepresentativeSchedule.Repositories 
{

    public class RepScheduleRepository : IRepScheduleRepository
    {
        
        private static List<Doctor> doctors=new List<Doctor>();
        private static List<RepresentativeDetails> representatives;
        List<DoctorDTO> docDetails = new List<DoctorDTO>();
        List<RepresentativeDetailsDTO> repDetails = new List<RepresentativeDetailsDTO>();
        public RepScheduleRepository()
        {
            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(@"D:\safe\MedicalRepresentativeSchedule\DoctorList.csv")), true))
            {
                csvTable.Load(csvReader);
            }
            for (int i = 0; i < csvTable.Rows.Count; i++)
            {
                doctors.Add(new Doctor { Name = csvTable.Rows[i][0].ToString(),ContactNumber= csvTable.Rows[i][1].ToString(),TreatingAilment=csvTable.Rows[i][2].ToString() });
            }

            representatives = new List<RepresentativeDetails>()
            {
                new RepresentativeDetails{RepresentativeName= "Rep1" },
                new RepresentativeDetails{RepresentativeName= "Rep2" },
                new RepresentativeDetails{RepresentativeName= "Rep3" }
            };


        }
        public List<DoctorDTO> GetDoctorDetails()
        {
            foreach (var i in doctors)
            {
                docDetails.Add(new DoctorDTO { Name = i.Name, ContactNumber = i.ContactNumber, TreatingAilment = i.TreatingAilment });
            }
            return docDetails;
        }
        public List<RepresentativeDetailsDTO> GetRepresentativesDetails()
        {
            foreach (var i in representatives)
            {
                repDetails.Add(new RepresentativeDetailsDTO { RepresentativeName = i.RepresentativeName });
            }
            return repDetails;
        }

    }
        
    
}
