using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHousePersistence;

namespace AnimalHouseEntity
{
    public class OrderLine
    {
        //Nichlas
        private int ReceiptID;
        private int RessourceID;
        private int ProductCategoryID;
        private int Price;
        private int Amount;

        public OrderLine(int ReceiptID,int RessourceID, int ProductCategoryID, int Price, int Amount)
        {
            this.ReceiptID = ReceiptID;
            this.RessourceID = RessourceID;
            this.ProductCategoryID = ProductCategoryID;
            this.Price = Price;
            this.Amount = Amount;
        }

        public OrderLine(int Price, int Amount)
        {
            this.Price = Price;
            this.Amount = Amount;
        }

        public OrderLine(int Price)
        {
            this.Price = Price;
        }

        public double Discount(int Price, int Discount)
        {
            double NewPrice;
            NewPrice = Price - ((Price / 100) * Discount);
            return NewPrice;
        }

        public double ChangeOfPriceWithMoms(int Price, int Amount, int OldPrice)
        {
            double NewPrice = Price;
            Convert.ToDouble(OldPrice);
            NewPrice = (NewPrice * 1.25) * Amount;
            NewPrice = NewPrice + Convert.ToDouble(OldPrice);
            return NewPrice;
        }

        public double ChangeOfPriceWithOutMoms(int Price, int Amount, int OldPrice)
        {
            double NewPrice = Price;
            NewPrice = NewPrice * Amount;
            NewPrice = NewPrice + Convert.ToDouble(OldPrice);
            return NewPrice;
        }

        public void InsertOrderLine()
        {
            IPersistenceController Controller = new DatabaseController();
            Controller.DBCInsertOrderLine(ReceiptID,ProductCategoryID,RessourceID,Price,Amount);
        }
    }
}
