using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHousePersistence;

namespace AnimalHouseEntity
{
    public class Cage : Ressource
    {
        //Viggo
        private string AnimalType;

        public Cage(int ID, double Price, int ProductCategoryID, string AnimalType) : base(ID, Price, ProductCategoryID)
        {
            this.AnimalType = AnimalType;
        }

        public static List<string> CageFetch()
        {
            IPersistenceController Daba = new DatabaseController();
            List<string> CageList;

            CageList = Daba.DBCSelectFrom("Bur");

            return CageList;
        }
    }
}
