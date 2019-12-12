using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHousePersistence;

namespace AnimalHouseEntity
{
    public class Private : Owner
    {
        IPersistenceController DatabaseController = new DatabaseController();
        public Private(int TelefonNr, string FirstName, string LastName, string Adress, string Email, string City, int ZipCode) : base(TelefonNr, FirstName, LastName, Adress, Email, City, ZipCode)
        {
        }
        public Private(int TelefonNr) : base(TelefonNr)
        {

        }
        
        


        public void AddPrivateToDatabase(int TelePhoneNr)
        {
            DatabaseController.DBCInsertPrivate(TelePhoneNr);
        }
        public List<string> SearchForPrivate(string TelePhoneNr)
        {
            List<string> PrivateList = DatabaseController.DBCSelectFromWhere("Private_", "ejer", TelePhoneNr);
            return PrivateList;
        }

        


        public static bool PrivateExist(string PEParam)
        {
            IPersistenceController Daba = new DatabaseController();
            bool TempBool;
            return TempBool = Daba.CheckIfExist("Ejer", "TelefonNr", PEParam);
        }

        public static bool CheckIfExsistInPrivateIsPrivate(string OwnerID)
        {
            IPersistenceController DBController = new DatabaseController();
            return DBController.CheckIfExist("Private_", "Ejer", OwnerID);
        }

        public static List<string> PrivateFetch(string PFParam)
        {
            IPersistenceController Daba = new DatabaseController();
            List<string> ListOwn;

            ListOwn = Daba.DBCSelectFromWhere("Ejer", "TelefonNr", PFParam);

            return ListOwn;
        }
    }
}
