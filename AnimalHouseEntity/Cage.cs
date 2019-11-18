using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntity
{
    public class Cage : Ressource
    {
        private string AnimalType;
        private bool RentCheck;
        public Cage(int ID, double Price, int ProductCategoryID, string AnimalType) : base(ID, Price, ProductCategoryID)
        {
            this.AnimalType = AnimalType;
        }



    }
}
