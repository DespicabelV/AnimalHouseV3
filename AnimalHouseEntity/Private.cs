using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntity
{
    public class Private : Owner
    {
        public Private(int TelefonNr, string FirstName, string LastName, string Adress, string Email, string City, int ZipCode) : base(TelefonNr, FirstName, LastName, Adress, Email, City, ZipCode)
        {
        }
    }
}
