using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntity
{
    public class Animal
    {
        private int ID;
        private string Name;
        private char Gender;
        private string Birthdate;
        private string Race;
        private int Doctor;
        private int Chip;
        private string Journal;

        public Animal(int ID, string Name, char Gender, string Birthdate, string Race, int Doctor, int Chip, string Journal)
        {
            this.ID = ID;
            this.Name = Name;
            this.Gender = Gender;
            this.Birthdate = Birthdate;
            this.Race = Race;
            this.Doctor = Doctor;
            this.Chip = Chip;
            this.Journal = Journal;
        }
    }
}
