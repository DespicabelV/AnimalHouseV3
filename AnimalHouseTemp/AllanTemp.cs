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

        public bool CheckAnimalOwner(string Ejer, string TeleNummer, string Parameter)
        {
            Dyr animal = new Dyr();
            return animal.CheckOwner(Ejer, TeleNummer, Parameter);
        }
        //ikke færdig
        public void AddRelation(int EjerTelenummer, int DyrID)
        {
            Dyr animal = new Dyr();
            animal.InsertRelation(EjerTelenummer, DyrID);
        }

        public List<string> SearchAnimal(string IDDyr)
        {
            Dyr animal = new Dyr();
            animal.GetAnimal(IDDyr);
            List<string> DyrList = new List<string>();
            foreach (string i in animal.GetAnimal(IDDyr))
            {
                DyrList.Add(i);
            }
            return DyrList;
        }

        public bool CheckIfAnimalExist(string From, string Where, string Parameter)
        {
            Dyr animal = new Dyr();
            return animal.CheckIfAnimalExist(From, Where, Parameter);
        }

        public List<string> FindDyrID(string Name, string Date, string Race, char Gender)
        {
            Dyr animal = new Dyr();
            animal.GetDyrID(Name, Date, Race, Gender);
            List<string> DyrList = new List<string>();
            foreach (string i in animal.GetDyrID(Name, Date, Race, Gender))
            {
                DyrList.Add(i);
            }
            return DyrList;
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

        public Dyr()
        {

        }


        public void Add()
        {
            IPersistenceController DBController = new DatabaseController();
            DBController.DBCInsertAnimal(Name, Gender, Birthdate, Race, Doctor, Chip);
        }

        public bool CheckOwner(string Ejer, string EjerTelenummer, string Parameter)
        {
            IPersistenceController DBController = new DatabaseController();
            return DBController.CheckIfExist(Ejer, EjerTelenummer, Parameter);
        }

        //ikke færdig
        public void InsertRelation(int EjerTelenummer, int DyrID)
        {
            IPersistenceController DBController = new DatabaseController();
            DBController.DBCInsertRelation(EjerTelenummer, DyrID);
        }
  

        public List<string> GetAnimal(string AFParam)
        {
            IPersistenceController DBController = new DatabaseController();
            List<string> ListAnimal;

            ListAnimal = DBController.DBCSelectFromWhere("Dyr", "ID", AFParam);

            return ListAnimal;
        }

        public bool CheckIfAnimalExist(string From, string Where, string Parameter)
        {
            IPersistenceController DBController = new DatabaseController();
            return DBController.CheckIfExist(From, Where, Parameter);
        }

        public List<string> GetDyrID(string Name, string Date, string Race, char Gender)
        {
            IPersistenceController DBController = new DatabaseController();
            List<string> ListAnimal;

            ListAnimal = DBController.DBCSelectAnimal(Name, Date, Race, Gender);

            return ListAnimal;
        }
   }
}
