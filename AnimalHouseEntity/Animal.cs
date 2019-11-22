﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHousePersistence;

namespace AnimalHouseEntity
{
    public class Animal
    {
        private int ID;
        private string Name;
        private char Gender;
        private DateTime Birthdate;
        private string Race;
        private int Doctor;
        private int Chip;
        private string Journal;

        public Animal(int ID, string Name, char Gender, DateTime Birthdate, string Race, int Doctor, int Chip, string Journal)
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
        public Animal(string Name, char Gender, DateTime Birthdate, string Race, int Doctor, int Chip)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Birthdate = Birthdate;
            this.Race = Race;
            this.Doctor = Doctor;
            this.Chip = Chip;
        }

        IPersistenceController DBController;
        public void Add(Animal Animal)
        {
            DBController.DBCInsertAnimal(Animal.Name, Animal.Gender, Animal.Birthdate, Animal.Race, Animal.Doctor, Animal.Chip);
        }
    }
}
