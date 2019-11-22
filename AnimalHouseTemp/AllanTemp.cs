﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseEntity;
using AnimalHousePersistence;


namespace AnimalHouseTemp
{
    public class AllanTemp
    {
               
                
    }
    public class Controller //Controller
    {

        public void NewAnimal(string Name, char Gender,string Birthdate, string Race, int Doctor, int Chip)
        {
            Dyr animal = new Dyr(Name, Gender, Birthdate, Race, Doctor, Chip);
            animal.Add();            
        }        
    }

   public class Dyr //entity
   {
        private int ID;
        private string Name;
        private char Gender;
        private string Birthdate;
        private string Race;
        private int Doctor;
        private int Chip;
        private string Journal;      

        public Dyr(string Name, char Gender, string Birthdate, string Race, int Doctor, int Chip)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Birthdate = Birthdate;
            this.Race = Race;
            this.Doctor = Doctor;
            this.Chip = Chip;
        }

        IPersistenceController DBController;
        public void Add()
        {
            DBController = new DatabaseController();
            DBController.DBCInsertAnimal(Name, Gender, Birthdate, Race, Doctor, Chip);
        }
   }
}
