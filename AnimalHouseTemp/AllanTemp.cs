using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        public bool CheckAnimalOwner(string Parameter)
        {
            return Dyr.CheckOwner(Parameter);
        }

        public void AddRelation(int EjerTelenummer, int DyrID)
        {
            Dyr.InsertRelation(EjerTelenummer, DyrID);
        }
        
        public List<string> SearchAnimal(string IDDyr)
        {
            List<string> DyrList = new List<string>();
            foreach (string i in Dyr.GetAnimal(IDDyr))
            {
                DyrList.Add(i);
            }
            return DyrList;
        }
        
        public bool CheckIfAnimalExist(string Parameter)
        {            
            return Dyr.CheckIfAnimalExist(Parameter);
        }
        
        public List<string> FindDyrID(string Name, string Date, string Race, char Gender)
        {
            return Dyr.GetDyrID(Name, Date, Race, Gender);
        }

        public void UpdateAnimal(int ID, string Name, char Gender, string Date, string Race, int Doctor, int Chip)
        {
            Dyr animal = new Dyr(ID, Name, Gender, Date, Race, Doctor, Chip);
            animal.UpdateAnimal();
        }
        
        public void DeleteRelation(string ID)
        {
            Dyr.DeleteRelation(ID);
        }

        public void DeleteAnimal(string Parameter)
        {
            Dyr.DeleteAnimal(Parameter);
        }

        public List<string> FindAllDoctor()
        {
            List<string> GetAllDoctor;

            GetAllDoctor = Dyr.GetDoctor();

            return GetAllDoctor;
        }

        public string GetDoctorName(string DyrID)
        {
            return Dyr.GetDoctorName(DyrID);
        }

        public void AddJournal(int Doctor, int ID, string Date, string Title, string Comment)
        {
            Dyr.AddJournal(Doctor, ID, Date, Title, Comment);
        }

        public object GetJournal(string DyrID)
        {
            return Dyr.ShowJournal(DyrID);
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
        

        public Dyr(string Name, char Gender, string Birthdate, string Race, int Doctor, int Chip)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Birthdate = Birthdate;
            this.Race = Race;
            this.Doctor = Doctor;
            this.Chip = Chip;
        }

        public Dyr(int ID, string Name, char Gender, string Birthdate, string Race, int Doctor, int Chip)
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

        public static bool CheckOwner(string Parameter)
        {
            IPersistenceController DBController = new DatabaseController();
            return DBController.CheckIfExist("Ejer", "TelefonNr", Parameter);
        }

        public static void InsertRelation(int EjerTelenummer, int DyrID)
        {
            IPersistenceController DBController = new DatabaseController();
            DBController.DBCInsertRelation(EjerTelenummer, DyrID);
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

        //public static string GetJournal(string DyrID)
        //{
        //    IPersistenceController DBController = new DatabaseController();
        //    DBController.select
        //}

        //contructor
        public static void AddJournal(int Doctor, int ID, string Date, string Titel, string Comment)
        {
            IPersistenceController DBController = new DatabaseController();
            DBController.DBCInsertJournal(Doctor, ID, Date, Titel, Comment);
        }

        public static object ShowJournal(string DyrID)
        {
            Database db = new Database();
            return db.DBCGetJournal(DyrID);
        }
   }

    class Database
    {
        SqlConnection db;
        private SqlConnection DBCOpenDB()
        {
            db = new SqlConnection("Data source = den1.mssql7.gear.host; Initial Catalog = animalhousev3;User Id= animalhousev3 ;Password= Ts3N59?EL_mw");
            db.Open();
            return db;
        }

        private void DBCCloseDB()
        {
            db.Close();
        }

        public object DBCGetJournal(string DBCPram)
        {
            DBCOpenDB();
            string quary = $"select Laege, Dato, Emne, Kommentar from Journal " +
                $"where Dyr = {DBCPram}";
            SqlCommand SelectFromJoin = new SqlCommand(quary,DBCOpenDB());
            SqlDataAdapter Adapter = new SqlDataAdapter(SelectFromJoin);
            DataTable DT = new DataTable();
            Adapter.Fill(DT);
            
            DBCCloseDB();

            return DT;
        }
    }
}
