using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntity
{
    public class OrderLine
    {
        private int ID;
        private int ReceiptID;
        private int ProductCategoryID;
        private double Price;
        private int Amount;

        public OrderLine(int ID, int ReceiptID, int ProductCategoryID, double Price, int Amount)
        {
            this.ID = ID;
            this.ReceiptID = ReceiptID;
            this.ProductCategoryID = ProductCategoryID;
            this.Price = Price;
            this.Amount = Amount;
        }
    }
}
