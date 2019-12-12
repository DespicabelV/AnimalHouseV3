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
        IPersistenceController DatabaseController = new DatabaseController();
        private int CVRNr;
        private string CompanyName;

        public Business(int TelefonNr, string FirstName, string LastName, string Adress, string Email, string City, int ZipCode, int CVRNr, string CompanyName)
            : base(TelefonNr, FirstName, LastName, Adress, Email, City, ZipCode)
        {
            this.CVRNr = CVRNr;
            this.CompanyName = CompanyName;
        }
        public Business (int TelefonNr,int CVRNr,string CompanyName): base (TelefonNr)
        {
            this.CVRNr = CVRNr;
            this.CompanyName = CompanyName;
        }
        public Business(int TelefonNr) : base(TelefonNr)
        {
            
        }

        public void AddBusinessToDatabase(int TelePhoneNr, string companyname, int CVRNR)
        {

            DatabaseController.DBCInsertBusiness(TelePhoneNr, companyname, CVRNR);
        }
        public List<string> SearchForBusiness(string TelePhoneNr)
        {
            List<string> BusinessList = DatabaseController.DBCSelectFromWhere("Erhverv", "ejer", TelePhoneNr);
            return BusinessList;
        }
        public void UpdateBusiness(int TelePhoneNr, string companyname, string CVRNR)
        {
            DatabaseController.DBCUpdateBusiness(TelePhoneNr, companyname, CVRNR);
        }
    }
}
