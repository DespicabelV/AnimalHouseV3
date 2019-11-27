using System;
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
        public Animal(string Name, char Gender, string Birthdate, string Race, int Doctor, int Chip)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Birthdate = Birthdate;
            this.Race = Race;
            this.Doctor = Doctor;
            this.Chip = Chip;
        }

        IPersistenceController DBController;

        static List<string> AnimalFetch(string AFParam)
        {
            IPersistenceController Daba = new DatabaseController();
            List<string> ListAnimal;

            ListAnimal = Daba.DBCSelectFromWhere("Dyr", "ID", AFParam);

            return ListAnimal;
        }

        public void Add(Animal Animal)
        {
            DBController = new DatabaseController();
            DBController.DBCInsertAnimal(Animal.Name, Animal.Gender, Animal.Birthdate, Animal.Race, Animal.Doctor, Animal.Chip);
        }
        
        public bool CheckOwner(string Ejer, string EjerTelenummer, string Parameter)
        {
            DBController = new DatabaseController();
            return DBController.CheckIfExist(Ejer, EjerTelenummer, Parameter);
        }
        
        public void InsertRelation(int EjerTeleNummer, int DyrID)
        {
            DBController = new DatabaseController();
            DBController.DBCInsertRelation(EjerTeleNummer, DyrID);
        }


    }
}
