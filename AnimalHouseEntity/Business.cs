using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHousePersistence;

namespace AnimalHouseEntity
{
    public class Business : Owner
    {
        //Jacob
        IPersistenceController DatabaseController = new DatabaseController();
        private int CVRNr;
        private string CompanyName;
        private int PhoneNr;

        public Business(int TelefonNr, string FirstName, string LastName, string Adress, string Email, string City, int ZipCode, int CVRNr, string CompanyName)
            : base(TelefonNr, FirstName, LastName, Adress, Email, City, ZipCode)
        {
            this.CVRNr = CVRNr;
            this.CompanyName = CompanyName;
        }

        public Business (int TelefonNr,int CVRNr,string CompanyName): base (TelefonNr)
        {
            this.PhoneNr = TelefonNr;
            this.CVRNr = CVRNr;
            this.CompanyName = CompanyName;
        }

        public Business(int TelefonNr) : base(TelefonNr)
        {
        }

        public void AddBusinessToDatabase()
        {
            DatabaseController.DBCInsertBusiness(PhoneNr, CompanyName,CVRNr);
        }

        public List<string> SearchForBusiness(string TelePhoneNr)
        {
            List<string> BusinessList = DatabaseController.DBCSelectFromWhere("Erhverv", "ejer", TelePhoneNr);
            return BusinessList;
        }

        public void UpdateBusiness()
        {
            DatabaseController.DBCUpdateBusiness(PhoneNr, CompanyName, CVRNr);
        }
    }
}
