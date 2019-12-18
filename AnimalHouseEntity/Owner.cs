using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHousePersistence;

namespace AnimalHouseEntity
{
    public class Owner
    {
        private int TelefonNr;
        private string FirstName;
        private string LastName;
        private string Adress;
        private string Email;
        private string City;
        private int ZipCode;
        IPersistenceController DatabaseController = new DatabaseController();

        public Owner(int TelefonNr, string FirstName, string LastName, string Adress, string Email, string City, int ZipCode)
        {
            this.TelefonNr = TelefonNr;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Adress = Adress;
            this.Email = Email;
            this.City = City;
            this.ZipCode = ZipCode;
        }
       
        public Owner(int TelefonNr)
        {
            this.TelefonNr = TelefonNr;
        }
        
        public static List<string> RelationFetch(string RFParam)
        {
            IPersistenceController Daba = new DatabaseController();
            List<string> ListRela;

            ListRela = Daba.DBCSelectFromWhere("Relation", "Ejer", RFParam);

            return ListRela;
        }

        public void AddOwnerToDatabase()
        {
            DatabaseController.DBCInsertOwner(TelefonNr,FirstName,LastName,Adress,Email,City,ZipCode);
        }

        public List<string> SearchForOwner(string TelePhoneNr)
        {
            List<string> ownerlist = DatabaseController.DBCSelectFromWhere("ejer", "TelefonNr", TelePhoneNr);
            return ownerlist;
        }

        public void UpdateOwner()
        {
            DatabaseController.DBCUpdateOwner(TelefonNr, FirstName, LastName, Adress, Email, City, ZipCode);
        }

        public void DeleteOwner(string Owner, string Where, string TelephoneNr)
        {
            DatabaseController.DBCDelete(Owner, Where, TelephoneNr);
        }

        public object GetOwnersAnimalDataTable(string TelePhoneNr)
        {
           return DatabaseController.GetOwnersAnimalDataTable(TelePhoneNr);
        }
    }
}
