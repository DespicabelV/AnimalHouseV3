using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntity
{
    public class Booking
    {
        private int ID;
        private int CageID;
        private int CageDayAmount;
        private string Date;
        private int Times;

        public Booking(int ID, int CageID, int CageDayAmount, string Date, int Times)
        {
            this.ID = ID;
            this.CageID = CageID;
            this.CageDayAmount = CageDayAmount;
            this.Date = Date;
            this.Times = Times;
        }
    }
}
