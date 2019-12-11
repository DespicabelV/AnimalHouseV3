using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
