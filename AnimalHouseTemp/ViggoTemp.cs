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

        //Entity
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
    }
}
