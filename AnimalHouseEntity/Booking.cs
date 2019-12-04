using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHousePersistence;

namespace AnimalHouseEntity
{
    public class Booking
    {
        IPersistenceController IPC;
        private int CageID;
        private int CageDayAmount;
        private string Date;
        private int Times;
        private int Treatment;
        private int Doctor;
        private int Animal;
        private int Owner;
        private int ID;

        public Booking(int Treatment, int Doctor, int Animal, int CageID, int CageDayAmount, string Date, int Times, int Owner)
        {
            IPC = new DatabaseController();
            this.CageID = CageID;
            this.CageDayAmount = CageDayAmount;
            this.Date = Date;
            this.Times = Times;
            this.Treatment = Treatment;
            this.Doctor = Doctor;
            this.Animal = Animal;
            this.Owner = Owner;
        }

        public Booking(int Treatment, int Doctor, int ID, int CageID, int CageDayAmount, string Date, int Times)
        {
            IPC = new DatabaseController();
            this.CageID = CageID;
            this.CageDayAmount = CageDayAmount;
            this.Date = Date;
            this.Times = Times;
            this.Treatment = Treatment;
            this.Doctor = Doctor;
            this.ID = ID;
        }

        public void Add()
        {
            IPC.DBCInsertBooking(Treatment, Doctor, Animal, CageID, CageDayAmount, Date, Times, Owner);
        }

        public void Update()
        { 
            IPC.DBCUpdateBookning(Treatment,Doctor, ID, CageID,CageDayAmount,Date,Times);
        }
    }
}
