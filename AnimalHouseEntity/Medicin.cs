using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntity
{
   public class Medicin : Ressource
    {
        private string Name;
        private int Amount;
        public Medicin(int ID, double Price, int ProductCategoryID, string Name, int Amount) : base(ID, Price, ProductCategoryID)
        {
            this.Name = Name;
            this.Amount = Amount;
        }
    }
}
