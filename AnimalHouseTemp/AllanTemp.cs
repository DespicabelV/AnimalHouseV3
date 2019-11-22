using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseEntity;
using AnimalHousePersistence;


namespace AnimalHouseTemp
{
    class AllanTemp
    {
               
                
    }
    class Controller //Controller
    {

        void NewAnimal(string Name, char Gender,DateTime Birthdate, string Race, int Doctor, int Chip)
        {
            Dyr animal = new Dyr(Name, Gender, Birthdate, Race, Doctor, Chip);
            animal.Add(animal);
            
        }        
    }

   public class Dyr //entity
   {
        private int ID;
        private string Name;
        private char Gender;
        private DateTime Birthdate;
        private string Race;
        private int Doctor;
        private int Chip;
        private string Journal;


        public Dyr(int ID, string Name, char Gender, DateTime Birthdate, string Race, int Doctor, int Chip, string Journal)
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

        public Dyr(string Name, char Gender, DateTime Birthdate, string Race, int Doctor, int Chip)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Birthdate = Birthdate;
            this.Race = Race;
            this.Doctor = Doctor;
            this.Chip = Chip;
        }

        IPersistenceController DBController;
        public void Add(Dyr Animal)
        {
            DBController.DBCInsertAnimal(Animal.Name, Animal.Gender, Animal.Birthdate, Animal.Race, Animal.Doctor, Animal.Chip);
        }
   }
}
