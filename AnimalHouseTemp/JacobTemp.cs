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

        public void CreatePrivateOwner(int telefonnr, string firstname, string lastname, string adress, string email, string city, int zipcode)
        {
            JacobTempEntity PrivateOwner = new JacobTempEntity();
            PrivateOwner.AddOwnerToDatabase(telefonnr, firstname, lastname, adress, email, city, zipcode);
            PrivateOwner.AddPrivateToDatabase(telefonnr);

        }
        public void CreateBusinessOwner(int telefonnr, string firstname, string lastname, string adress, string email, string city, int zipcode, string companyname, int CVRNR)
        {
            JacobTempEntity BusinessOwner = new JacobTempEntity();
            BusinessOwner.AddOwnerToDatabase(telefonnr, firstname, lastname, adress, email, city, zipcode);
            BusinessOwner.AddBusinessToDatabase(telefonnr, companyname, CVRNR);
        }
        public List<string> SearchForOwner(string TelephoneNr)
        {
            JacobTempEntity owner = new JacobTempEntity();
            List<string> Ownerlist=owner.SearchForOwner(TelephoneNr);
            return Ownerlist;
        }
        public List<string> SearchForPrivate(string TelePhoneNr)
        {
            JacobTempAHC entity = new JacobTempAHC();
            List<string> PrivateList = entity.SearchForPrivate(TelePhoneNr);
            return PrivateList;
        }
        public List<string> SearchForBusiness(string TelePhoneNr)
        {
            JacobTempEntity entity = new JacobTempEntity();
            List<string> BusinessList = entity.SearchForBusiness(TelePhoneNr);
            return BusinessList;
        }



    }
    class JacobTempEntity
    {
        //code for entity layer

        public IPersistenceController OwnerController;
        public JacobTempEntity()
        {
            OwnerController = new DatabaseController();
        }


        public void AddBusinessToDatabase(int telefonnr, string companyname, int CVRNR)
        {
            OwnerController.DBCInsertBusiness(telefonnr, companyname, CVRNR);
        }
        public void AddOwnerToDatabase(int telefonnr, string firstname, string lastname, string adress, string email, string city, int zipcode)
        {
            OwnerController.DBCInsertOwner(telefonnr, firstname, lastname, adress, email, city, zipcode);
        }
        public void AddPrivateToDatabase(int telefonnr)
        {
            OwnerController.DBCInsertPrivate(telefonnr);
        }

        public List<string> SearchForOwner(string TelePhoneNr)
        {
           List<string> ownerlist= OwnerController.DBCSelectFromWhere("ejer", "TelefonNr", TelePhoneNr);
            return ownerlist;
        }
       
        public List<string> SearchForPrivate(string TelePhoneNr)
        {
            List<string> PrivateList = OwnerController.DBCSelectFromWhere("Private_", "TelefonNr", TelePhoneNr);
            return PrivateList;
        }
        public List<string> SearchForBusiness(string TelePhoneNr)
        {
            List<string> BusinessList = OwnerController.DBCSelectFromWhere("Erhverv", "TelefonNr", TelePhoneNr);
            return BusinessList;
        }



    }
    
}
