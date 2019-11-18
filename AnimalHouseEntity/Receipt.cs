using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntity
{
   public class Receipt
    {
        private int ID;
        private double PriceTotal;
        private int BookingID;
        private int EjerTelefonNr;

        public Receipt(int ID, double PriceTotal, int BookingID, int EjerTelefonNr)
        {
            this.ID = ID;
            this.PriceTotal = PriceTotal;
            this.BookingID = BookingID;
            this.EjerTelefonNr = EjerTelefonNr;
        }
    }
}
