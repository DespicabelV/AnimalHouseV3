using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHousePersistence;
using AnimalHouseEntity;

namespace AnimalHouseTemp
{
    // the data will go through 4 steps. 
    // 1. Getting read from the ui and converted to proper variable. 
    // 2. Controller making new object with these variable, maybe added to list?
    // 3. An AddOwner method in the owner class will transfer the object from the controller to the DatabaseController through an interface
    // 4. The DatabaseController then inserts the Owner into the database with an InsertOwner method, wich includes SQL command strings. 

    class JacobTempAui
    {
        // this piece of code can't be made in here, but instead it will be made in UI.
        JacobTempAHC Controller = new JacobTempAHC();



    }
    public class JacobTempAHC
    {
        // code for controller layer  
        public void CreatePrivateOwner(int TelePhoneNr, string firstname, string lastname, string adress, string email, string city, int zipcode)
        {
            JacobTempEntity PrivateOwner = new JacobTempEntity();
            PrivateOwner.AddOwnerToDatabase(TelePhoneNr, firstname, lastname, adress, email, city, zipcode);
            PrivateOwner.AddPrivateToDatabase(TelePhoneNr);

        }
        public void CreateBusinessOwner(int TelePhoneNr, string firstname, string lastname, string adress, string email, string city, int zipcode, string companyname, int CVRNR)
        {
            JacobTempEntity BusinessOwner = new JacobTempEntity();
            BusinessOwner.AddOwnerToDatabase(TelePhoneNr, firstname, lastname, adress, email, city, zipcode);
            BusinessOwner.AddBusinessToDatabase(TelePhoneNr, companyname, CVRNR);
        }
        public List<string> SearchForOwner(string TelephoneNr)
        {
            JacobTempEntity owner = new JacobTempEntity();
            List<string> Ownerlist=owner.SearchForOwner(TelephoneNr);
            return Ownerlist;
        }
        public List<string> SearchForPrivate(string TelePhoneNr)
        {
            JacobTempEntity entity = new JacobTempEntity();
            List<string> PrivateList = entity.SearchForPrivate(TelePhoneNr);
            return PrivateList;
        }
        public List<string> SearchForBusiness(string TelePhoneNr)
        {
            JacobTempEntity entity = new JacobTempEntity();
            List<string> BusinessList = entity.SearchForBusiness(TelePhoneNr);
            return BusinessList;
        }
        public void UpdateOwner(int TelePhoneNr, string firstname, string lastname, string adress, string email, string city, int zipcode)
        {
            JacobTempEntity Update = new JacobTempEntity();
            Update.UpdateOwner(TelePhoneNr, firstname, lastname, adress, email, city, zipcode);
        }
        public void UpdateBusiness(int TelePhoneNr, string CompanyName,string CVRNR)
        {
            JacobTempEntity Update = new JacobTempEntity();
            Update.UpdateBusiness(TelePhoneNr, CompanyName, CVRNR);
        }
        public void DeleteOwner(string Owner,string Where,string TelephoneNr)
        {
            JacobTempEntity entity = new JacobTempEntity();
            entity.DeleteOwner(Owner, Where, TelephoneNr);
        }
        //public void DeleteBusiness(string Owner)
    }
    class JacobTempEntity
    {
        //code for entity layer
        public IPersistenceController OwnerController;
        public JacobTempEntity()
        {
            OwnerController = new DatabaseController();
        }
        public void AddBusinessToDatabase(int TelePhoneNr, string companyname, int CVRNR)
        {
            OwnerController.DBCInsertBusiness(TelePhoneNr, companyname, CVRNR);
        }
        public void AddOwnerToDatabase(int TelePhoneNr, string firstname, string lastname, string adress, string email, string city, int zipcode)
        {
            OwnerController.DBCInsertOwner(TelePhoneNr, firstname, lastname, adress, email, city, zipcode);
        }
        public void AddPrivateToDatabase(int TelePhoneNr)
        {
            OwnerController.DBCInsertPrivate(TelePhoneNr);
        }
        public List<string> SearchForOwner(string TelePhoneNr)
        {
           List<string> ownerlist= OwnerController.DBCSelectFromWhere("ejer", "TelefonNr", TelePhoneNr);
            return ownerlist;
        }
        public List<string> SearchForPrivate(string TelePhoneNr)
        {
            List<string> PrivateList = OwnerController.DBCSelectFromWhere("Private_", "ejer", TelePhoneNr);
            return PrivateList;
        }
        public List<string> SearchForBusiness(string TelePhoneNr)
        {
            List<string> BusinessList = OwnerController.DBCSelectFromWhere("Erhverv", "ejer", TelePhoneNr);
            return BusinessList;
        }
        public void UpdateOwner(int TelePhoneNr, string firstname, string lastname, string adress, string email, string city, int zipcode)
        {
            OwnerController.DBCUpdateOwner(TelePhoneNr, firstname, lastname, adress, email, city, zipcode);
        }
        public void UpdateBusiness(int TelePhoneNr, string companyname, string CVRNR)
        {
            OwnerController.DBCUpdateBusiness(TelePhoneNr, companyname, CVRNR);
        }
        public void DeleteOwner(string Owner,string Where,string TelephoneNr)
        {
            OwnerController.DBCDelete("ejer", "TelefonNr", "TelefonNr");
        }
       //public void DeleteBusiness(string Business,string Where,string TelehponeNr)
        //{
        //    OwnerController.DBCDelete(Business, Where, TelehponeNr);
        //}
    }
}
