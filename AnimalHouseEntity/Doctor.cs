using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHousePersistence;

namespace AnimalHouseEntity
{
    public class Doctor
    {
        private int ID;
        private string Name;
        private int Expertise;

        public Doctor(int ID, string Name, int Expertise)
        {
            this.ID = ID;
            this.Name = Name;
            this.Expertise = Expertise;
        }

        public static List<string> DoctorAllFetch(string DFParam)
        {
            IPersistenceController Daba = new DatabaseController();
            List<string> ListDoctor;

            ListDoctor = Daba.DBCSelectFrom(DFParam);

            return ListDoctor;
        }

        public static List<string> PrintDoctorLetter()
        {
            IPersistenceController Daba = new DatabaseController();
            return Daba.DBCPrintDocktorLetter();
        }
    }
}
