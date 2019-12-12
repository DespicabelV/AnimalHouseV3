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


        public Animal(string Name, char Gender, string Birthdate, string Race, int Doctor, int Chip)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Birthdate = Birthdate;
            this.Race = Race;
            this.Doctor = Doctor;
            this.Chip = Chip;
        }

        public Animal(int ID, string Name, char Gender, string Birthdate, string Race, int Doctor, int Chip)
        {
            this.ID = ID;
            this.Name = Name;
            this.Gender = Gender;
            this.Birthdate = Birthdate;
            this.Race = Race;
            this.Doctor = Doctor;
            this.Chip = Chip;
        }


        public void Add()
        {
            IPersistenceController DBController = new DatabaseController();
            DBController.DBCInsertAnimal(Name, Gender, Birthdate, Race, Doctor, Chip);
        }

        public static void InsertRelation(int EjerTelenummer, int DyrID)
        {
            IPersistenceController DBController = new DatabaseController();
            DBController.DBCInsertRelation(EjerTelenummer, DyrID);
        }

        public static bool CheckOwner(string Parameter)
        {
            IPersistenceController DBController = new DatabaseController();
            return DBController.CheckIfExist("Ejer", "TelefonNr", Parameter);
        }

        public static List<string> GetAnimal(string AFParam)
        {
            IPersistenceController DBController = new DatabaseController();
            List<string> ListAnimal;

            ListAnimal = DBController.DBCSelectFromWhere("Dyr", "ID", AFParam);

            return ListAnimal;
        }

        public static bool CheckIfAnimalExist(string Parameter)
        {
            IPersistenceController DBController = new DatabaseController();
            return DBController.CheckIfExist("Dyr", "ID", Parameter);
        }

        public static List<string> GetDyrID(string Name, string Date, string Race, char Gender)
        {
            IPersistenceController DBController = new DatabaseController();
            List<string> ListAnimal;

            ListAnimal = DBController.DBCSelectAnimal(Name, Date, Race, Gender);

            return ListAnimal;
        }

        public void UpdateAnimal()
        {
            IPersistenceController DBController = new DatabaseController();
            DBController.DBCUpdateAnimal(ID, Name, Gender, Birthdate, Race, Doctor, Chip);
        }


        public static void DeleteAnimal(string ID)
        {
            IPersistenceController DBController = new DatabaseController();
            DBController.DBCDelete("Dyr", "ID", ID);
        }

        public static void DeleteRelation(string ID)
        {
            IPersistenceController DBController = new DatabaseController();
            DBController.DBCDelete("Relation", "Dyr", ID);
        }

        public static string GetDoctorName(string DyrID)
        {
            IPersistenceController DBController = new DatabaseController();

            return DBController.DBCGetDoctor(DyrID);
        }

        public static List<string> GetDoctor()
        {
            IPersistenceController DBController = new DatabaseController();
            List<string> ListDoctor;

            ListDoctor = DBController.DBCSelectFrom("Laege");

            return ListDoctor;
        }

        public static void AddJournal(int Doctor, int ID, string Date, string Titel, string Comment)
        {
            IPersistenceController DBController = new DatabaseController();
            DBController.DBCInsertJournal(Doctor, ID, Date, Titel, Comment);
        }

        public static List<string> AnimalFetch(string AFParam)
        {
            IPersistenceController Daba = new DatabaseController();
            List<string> ListAnimal;

            ListAnimal = Daba.DBCSelectFromWhere("Dyr", "ID", AFParam);

            return ListAnimal;
        }
        public static object ShowJournal(string DyrID)
        {
            IPersistenceController DBController = new DatabaseController();
            return DBController.DBCGetJournal(DyrID);
        }


    }
}
