using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntity
{
    public class Doctor
    {
        private int ID;
        private string Name;
        private int Expertise;

        public Doctor(int ID, string Name, int Expertise)
        {
            this.ID = ID;
            this.Name = Name;
            this.Expertise = Expertise;
        }
    }
}
