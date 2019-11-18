using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntity
{
    public class Shelf_Ressource : Ressource
    {
        private string Name;
        public Shelf_Ressource(int ID, double Price, int ProductCategoryID, string Name) : base(ID, Price, ProductCategoryID)
        {
            this.Name = Name;
        }
    }
}
