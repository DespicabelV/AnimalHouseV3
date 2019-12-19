using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHousePersistence;

namespace AnimalHouseEntity
{
    public class Treatment : Ressource
    {
        //Viggo
        private string Name;

        public Treatment(int ID, double Price, int ProductCategoryID,string Name) : base(ID, Price, ProductCategoryID)
        {
            this.Name = Name;
        }

        public static List<string> TreatmentAllFetch(string TFParam)
        {
            IPersistenceController Daba = new DatabaseController();
            List<string> ListTreatment;

            ListTreatment = Daba.DBCSelectFrom(TFParam);

            return ListTreatment;
        }
    }
}
