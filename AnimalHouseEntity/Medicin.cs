using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntity
{
   public class Medicin
    {
        private string Name;
        public Medicin(int ID, double Price, int ProductCategoryID, string Name) : base(ID, Price, ProductCategoryID)
        {
            this.Name = Name;
        }
    }
}
