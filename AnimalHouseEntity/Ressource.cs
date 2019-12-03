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

        protected Ressource(int ID, double Price, int ProductCategoryID)
        {
            this.ID = ID;
            this.Price = Price;
            this.ProductCategoryID = ProductCategoryID;
        }

        protected Ressource(int ID)
        {
            this.ID = ID;
        }
    }
}
