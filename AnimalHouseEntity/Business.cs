using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntity
{
    public class Business : Owner
    {
        private int CVRNr;
        private string CompanyName;

        public Business(int TelefonNr, string FirstName, string LastName, string Adress, string Email, string City, int ZipCode, int CVRNr, string CompanyName)
            : base(TelefonNr, FirstName, LastName, Adress, Email, City, ZipCode)
        {
            this.CVRNr = CVRNr;
            this.CompanyName = CompanyName;
        }
    }
}
