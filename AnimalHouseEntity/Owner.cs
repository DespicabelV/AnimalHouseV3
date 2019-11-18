using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntity
{
    public abstract class Owner
    {
        private int TelefonNr;
        private string FirstName;
        private string LastName;
        private string Adress;
        private string Email;
        private string City;
        private int ZipCode;

        public Owner(int TelefonNr, string FirstName, string LastName, string Adress, string Email, string City, int ZipCode)
        {
            this.TelefonNr = TelefonNr;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Adress = Adress;
            this.Email = Email;
            this.City = City;
            this.ZipCode = ZipCode;
        }
    }
}
