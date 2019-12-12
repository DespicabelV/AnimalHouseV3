using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHousePersistence;

namespace AnimalHouseEntity
{
   public class Receipt
    {
        private int ID;
        private int PriceTotal;
        private int BookingID;
        private int EjerTelefonNr;

        IPersistenceController DABA = new DatabaseController();

        public Receipt(int ID, int PriceTotal, int BookingID, int EjerTelefonNr)
        {
            this.ID = ID;
            this.PriceTotal = PriceTotal;
            this.BookingID = BookingID;
            this.EjerTelefonNr = EjerTelefonNr;
        }
        public Receipt(int PriceTotal, int BookingID, int EjerTelefonNr)
        {
            this.PriceTotal = PriceTotal;
            this.BookingID = BookingID;
            this.EjerTelefonNr = EjerTelefonNr;
        }

        public Receipt(int ID)
        {
            this.ID = ID;
        }

        public int InsertReciept()
        {
            if (BookingID == 0)
            {
                BookingID = 11;
            }
            return DABA.DBCInsertReceipt(PriceTotal, BookingID, EjerTelefonNr);
        }
    }
}
