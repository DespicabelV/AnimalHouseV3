using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHousePersistence;
using AnimalHouseEntity;

namespace AnimalHouseTemp
{
    public class ViggoTemp
    {
        IPersistenceController Daba;


        //Todo
        //Check if the owner is there
        //Lav inset journal til dyr

        public ViggoTemp()
        {
            Daba = new DatabaseController();
        }

        //Controler

        public bool ControllerOwnerExist(string COParam)
        {
            bool TempBool;
            TempBool = PrivateExist(COParam);
            return TempBool;
        }

        public List<string> ControllerGetOwner(string PhoneNum)
        {
            List<string> ControllerGetOwner;

            ControllerGetOwner = PrivateFetch(PhoneNum);

            return ControllerGetOwner;
        }

        public List<string> ControllerGetRelation(string OwnerID)
        {
            List<string> ControllerGetRelation;

            ControllerGetRelation = RelationFetch(OwnerID);

            return ControllerGetRelation;
        }

        public List<string> ControllerGetAnimal(string AnimalID)
        {
            List<string> ControllerGetAnimal;

            ControllerGetAnimal = AnimalFetch(AnimalID);

            return ControllerGetAnimal;
        }

        public List<string> ControllerGetAllDoctor()
        {
            List<string> ControllerGetAllDoctor;

            ControllerGetAllDoctor = DoctorAllFetch("Laege");

            return ControllerGetAllDoctor;
        }

        public List<string> ControllerGetAllTreatment()
        {
            List<string> ControllerGetAllTreatment;

            ControllerGetAllTreatment = TreatmentAllFetch("Behandling");

            return ControllerGetAllTreatment;
        }

        public List<string> ControllerGetBookedTime(string Date, string Doctor)
        {
            List<string> ControllerGetBookedTime;

            ControllerGetBookedTime = TimeBookedTimeFetch(Date, Doctor);

            return ControllerGetBookedTime;
        }

        public List<string> ControllerGetTime()
        {
            List<string> ControllerGetTime;

            ControllerGetTime = TimeTimeFetch();

            return ControllerGetTime;
        }

        public List<string> ControllerGetCage()
        {
            List<string> ControllerGetCage;

            ControllerGetCage = CageFetch();

            return ControllerGetCage;
        }

        public List<string> ControllerGetBookning(string OwnerID)
        {
            List<string> ControllerGetBookning;

            ControllerGetBookning = BookningFetch(OwnerID);

            return ControllerGetBookning;
        }

        public void ControllerAddBookning(int Treatment, int Doctor, int Animal, int CageID, int CageDay, string Date, int Times, int Owner)
        {
            Booking TempBook;
            TempBook = new Booking(Treatment, Doctor, Animal, CageID, CageDay, Date, Times, Owner);
            TempBook.Add();
        }

        public void ControllerUpdateBookning(int Treatment, int Doctor, int Animal, int CageID, int CageDay, string Date, int Times, int Owner)
        {
            Booking TempBook;
            TempBook = new Booking(Treatment, Doctor, Animal, CageID, CageDay, Date, Times, Owner);
            TempBook.Update();
        }

        //------------------------Entity-----------------------------

        static bool PrivateExist(string PEParam)
        {
            IPersistenceController Daba = new DatabaseController();
            bool TempBool;
            return TempBool = Daba.CheckIfExist("Ejer", "TelefonNr", PEParam);
        }

        static List<string> PrivateFetch(string PFParam)
        {
            IPersistenceController Daba = new DatabaseController();
            List<string> ListOwn;

            ListOwn = Daba.DBCSelectFromWhere("Ejer", "TelefonNr", PFParam);
          
            return ListOwn;
        }

        static List<string> BookningFetch(string PFParam)
        {
            IPersistenceController Daba = new DatabaseController();
            List<string> ListBookning;

            ListBookning = Daba.DBCSelectFromWhere("Bookning", "Ejer", PFParam);

            return ListBookning;
        }

        static List<string> RelationFetch(string RFParam)
        {
            IPersistenceController Daba = new DatabaseController();
            List<string> ListRela;

            ListRela = Daba.DBCSelectFromWhere("Relation", "Ejer", RFParam);

            return ListRela;
        }

        static List<string> AnimalFetch(string AFParam)
        {
            IPersistenceController Daba = new DatabaseController();
            List<string> ListAnimal;

            ListAnimal = Daba.DBCSelectFromWhere("Dyr", "ID", AFParam);

            return ListAnimal;
        }

        static List<string> DoctorAllFetch(string DFParam)
        {
            IPersistenceController Daba = new DatabaseController();
            List<string> ListDoctor;

            ListDoctor = Daba.DBCSelectFrom(DFParam);

            return ListDoctor;
        }

        static List<string> TreatmentAllFetch(string TFParam)
        {
            IPersistenceController Daba = new DatabaseController();
            List<string> ListTreatment;

            ListTreatment = Daba.DBCSelectFrom(TFParam);

            return ListTreatment;
        }

        static List<string> TimeBookedTimeFetch(string TTParamDate, string TTPramDoctor)
        {
            IPersistenceController Daba = new DatabaseController();
            List<string> ListTime;

            ListTime = Daba.DBCBookedTimes(TTParamDate, TTPramDoctor);

            return ListTime;
        }

        static List<string> TimeTimeFetch()
        {
            IPersistenceController Daba = new DatabaseController();
            List<string> ListTime;

            ListTime = Daba.DBCTimes();

            return ListTime;
        }

        static List<string> CageFetch()
        {
            IPersistenceController Daba = new DatabaseController();
            List<string> CageList;

            CageList = Daba.DBCSelectFrom("Bur");

            return CageList;
        }
        

    }
}
