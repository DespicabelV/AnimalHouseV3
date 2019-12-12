using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHousePersistence;

namespace AnimalHouseEntity
{
    public abstract class Ressource
    {
        private int ID;
        private double Price;
        private int ProductCategoryID;

        public Ressource(int ID, double Price, int ProductCategoryID)
        {
            this.ID = ID;
            this.Price = Price;
            this.ProductCategoryID = ProductCategoryID;
        }

        public Ressource(int ID)
        {
            this.ID = ID;
        }

        public Ressource(int ID, int Price)
        {
            this.ID = ID;
            this.Price = Price;
        }

       public static object PrintCategoryToDataGridView(string Category)
       {
            IPersistenceController Daba = new DatabaseController();
            return Daba.SelectFromXToGridView(Category);
       }

       public static object PrintCategoryToDataGridViewName(string Category, string Where)
       {
            IPersistenceController Daba = new DatabaseController();
            return Daba.SelectFromTableToGridViewWhereNameLike(Category,Where);
       }
        public static List<string> PrintMedicin()
        {
            IPersistenceController DBController = new DatabaseController();
            return DBController.DBCGetMedicinPrint();
        }

        public static List<string> PrintShelftStock()
        {
            IPersistenceController DBController = new DatabaseController();
            return DBController.DBCGetRessourcePrint();
        }

    }
}
