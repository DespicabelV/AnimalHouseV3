using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseEntity;

namespace AnimalHouseController
{
    public class Contoller
    {
        static void Main(string[] args)
        {
        }

        public bool ControllerOwnerExist(string COParam)
        {
            bool TempBool;
            TempBool = Private.PrivateExist(COParam);
            return TempBool;
        }

        public List<string> ControllerGetOwner(string PhoneNum)
        {
            List<string> ControllerGetOwner;

            ControllerGetOwner = Private.PrivateFetch(PhoneNum);

            return ControllerGetOwner;
        }

        public List<string> ControllerGetRelation(string OwnerID)
        {
            List<string> ControllerGetRelation;

            ControllerGetRelation = Owner.RelationFetch(OwnerID);

            return ControllerGetRelation;
        }

        public List<string> ControllerGetAnimal(string AnimalID)
        {
            List<string> ControllerGetAnimal;

            ControllerGetAnimal = Animal.AnimalFetch(AnimalID);

            return ControllerGetAnimal;
        }

        public List<string> ControllerGetAllDoctor()
        {
            List<string> ControllerGetAllDoctor;

            ControllerGetAllDoctor = Doctor.DoctorAllFetch("Laege");

            return ControllerGetAllDoctor;
        }

        public List<string> ControllerGetAllTreatment()
        {
            List<string> ControllerGetAllTreatment;

            ControllerGetAllTreatment = Treatment.TreatmentAllFetch("Behandling");

            return ControllerGetAllTreatment;
        }

        public List<string> ControllerGetBookedTime(string Date, string Doctor)
        {
            List<string> ControllerGetBookedTime;

            ControllerGetBookedTime = Booking.TimeBookedTimeFetch(Date, Doctor);

            return ControllerGetBookedTime;
        }

        public List<string> ControllerGetTime()
        {
            List<string> ControllerGetTime;

            ControllerGetTime = Booking.TimeTimeFetch();

            return ControllerGetTime;
        }

        public List<string> ControllerGetCage()
        {
            List<string> ControllerGetCage;

            ControllerGetCage = Cage.CageFetch();

            return ControllerGetCage;
        }

        public List<string> ControllerGetBookning(string OwnerID)
        {
            List<string> ControllerGetBookning;

            ControllerGetBookning = Booking.BookningFetch(OwnerID);

            return ControllerGetBookning;
        }

        public void ControllerAddBookning(int Treatment, int Doctor, int Animal, int CageID, int CageDay, string Date, int Times, int Owner)
        {
            Booking TempBook;
            TempBook = new Booking(Treatment, Doctor, Animal, CageID, CageDay, Date, Times, Owner);
            TempBook.Add();
        }

        public void ControllerUpdateBookning(int Treatment, int Doctor, int ID, int CageID, int CageDayAmount, string Date, int Times)
        {
            Booking TempBook;
            TempBook = new Booking(Treatment, Doctor, ID, CageID, CageDayAmount, Date, Times);
            TempBook.Update();
        }

        public void ControllerDeleteBookning(string Pram)
        {
            Booking.DeleteBookning(Pram);
        }

        public List<string> ControllerPrintDocktorLetter()
        {
            return Doctor.PrintDoctorLetter();
        }

        public object ControllerPrintCategoryToDataGridView(string Category)
        {
            return Ressource.PrintCategoryToDataGridView(Category);
        }

        public object ControllerPrintCategoryToDataGridViewName(string Category, string Where)
        {
            return Ressource.PrintCategoryToDataGridViewName(Category,Where);
        }


        public int ControllerChangeOfPriceWithOutMoms(int Price, int Amount, int OldPrice)
        {
            OrderLine ELO = new OrderLine(Price, Amount);
            return Convert.ToInt32(ELO.ChangeOfPriceWithOutMoms(Price, Amount, OldPrice));
        }

        public int ControllerChangeOfPriceWithMoms(int Price, int Amount, int OldPrice)
        {
            OrderLine ELO = new OrderLine(Price, Amount);
            return Convert.ToInt32(ELO.ChangeOfPriceWithMoms(Price, Amount, OldPrice));
        }

        public int ControllerDiscount(int Price, int Discount)
        {
            OrderLine ELO = new OrderLine(Price);
            return Convert.ToInt32(ELO.Discount(Price, Discount));
        }

        public int ControllerInsertReciept(int PriceTotal, int Bookning, int Ejer)
        {
            Receipt Receipt = new Receipt(PriceTotal, Bookning, Ejer);
            return Receipt.InsertReciept();
        }

        public void ControllerInsertOrderLine(int RecieptID,int RessourceID, int ProductCategoryID, int Price, int Amount)
        {
            OrderLine OrderLine = new OrderLine(RecieptID,RessourceID,ProductCategoryID,Price,Amount);
            OrderLine.InsertOrderLine();
        }

        public bool ControllerCheckIfExsistInPrivateIsPrivate(string OwnerID)
        {
            return Private.CheckIfExsistInPrivateIsPrivate(OwnerID);
        }

        public List<string> ControllerBookningFeetch(string OwnerID)
        {
            return Booking.BookningFetchSpecific(OwnerID);
        }

        public int ControllerUpdateMedicin()
        {
            return Medicin.UpdatePriceForMedicin();
        }


        public void ControllerNewAnimal(string Name, char Gender, string Birthdate, string Race, int Doctor, int Chip)
        {
            Animal animal = new Animal(Name, Gender, Birthdate, Race, Doctor, Chip);
            animal.Add();
        }

        public void ControllerAddRelation(int EjerTelenummer, int DyrID)
        {
            Animal.InsertRelation(EjerTelenummer, DyrID);
        }

        public bool ControllerCheckAnimalOwner(string Parameter)
        {
            return Animal.CheckOwner(Parameter);
        }

        public List<string> ControllerSearchAnimal(string IDDyr)
        {
            List<string> DyrList = new List<string>();
            foreach (string i in Animal.GetAnimal(IDDyr))
            {
                DyrList.Add(i);
            }
            return DyrList;
        }

        public bool ControllerCheckIfAnimalExist(string Parameter)
        {
            return Animal.CheckIfAnimalExist(Parameter);
        }

        public List<string> ControllerFindAnimalID(string Name, string Date, string Race, char Gender)
        {
            return Animal.GetDyrID(Name, Date, Race, Gender);
        }

        public void ControllerUpdateAnimal(int ID, string Name, char Gender, string Date, string Race, int Doctor, int Chip)
        {
            Animal animal = new Animal(ID, Name, Gender, Date, Race, Doctor, Chip);
            animal.UpdateAnimal();
        }

        public void ControllerDeleteRelation(string ID)
        {
            Animal.DeleteRelation(ID);
        }

        public void ControllerDeleteAnimal(string Parameter)
        {
            Animal.DeleteAnimal(Parameter);
        }

        public List<string> ControllerFindAllDoctor()
        {
            List<string> GetAllDoctor;

            GetAllDoctor = Animal.GetDoctor();

            return GetAllDoctor;
        }

        public string ControllerGetDoctorName(string DyrID)
        {
            return Animal.GetDoctorName(DyrID);
        }

        public void ControllerAddJournal(int Doctor, int ID, string Date, string Title, string Comment)
        {
            Animal.AddJournal(Doctor, ID, Date, Title, Comment);
        }

        public object ControllerGetJournal(string DyrID)
        {
            return Animal.ShowJournal(DyrID);
        }

        public List<string> ControllerPrintMedicin()
        {
            return Ressource.PrintMedicin();
        }

        public List<string> ControllerPrintShelfStock()
        {
            return Ressource.PrintShelftStock();
        }
        public void CreatePrivateOwner(int TelePhoneNr, string firstname, string lastname, string adress, string email, string city, int zipcode)
        {
            Owner Owner = new Owner(TelePhoneNr,firstname,lastname,adress,email,city,zipcode);
            Private PrivateOwner = new Private(TelePhoneNr);
            PrivateOwner.AddOwnerToDatabase(TelePhoneNr, firstname, lastname, adress, email, city, zipcode);
            PrivateOwner.AddPrivateToDatabase(TelePhoneNr);
        }
        public void CreateBusinessOwner(int TelePhoneNr, string firstname, string lastname, string adress, string email, string city, int zipcode, string companyname, int CVRNR)
        {
            Owner owner = new Owner(TelePhoneNr, firstname, lastname, adress, email, city, zipcode);
            Business BusinessOwner = new Business(TelePhoneNr, CVRNR, companyname);
            owner.AddOwnerToDatabase(TelePhoneNr, firstname, lastname, adress, email, city, zipcode);
            BusinessOwner.AddBusinessToDatabase(TelePhoneNr, companyname, CVRNR);
        }
        public List<string> SearchForOwner(string TelephoneNr)
        {
            Owner Owner = new Owner(Convert.ToInt32(TelephoneNr));
            List<string> Ownerlist = Owner.SearchForOwner(TelephoneNr);
            return Ownerlist;
        }
        public List<string> SearchForBusiness(string TelePhoneNr)
        {
            Business BusinessOwner = new Business(Convert.ToInt32(TelePhoneNr));
            List<string> BusinessList = BusinessOwner.SearchForBusiness(TelePhoneNr);
            return BusinessList;
        }
        public void UpdateOwner(int TelePhoneNr, string firstname, string lastname, string adress, string email, string city, int zipcode)
        {
            Owner owner = new Owner(TelePhoneNr, firstname, lastname, adress, email, city, zipcode);
            owner.UpdateOwner(TelePhoneNr, firstname, lastname, adress, email, city, zipcode);
        }
        public void UpdateBusiness(int TelePhoneNr, string CompanyName, string CVRNR)
        {
            Business business = new Business(TelePhoneNr,Convert.ToInt32(CVRNR),CompanyName);
            business.UpdateBusiness(TelePhoneNr, CompanyName, CVRNR);
        }
        public void DeleteOwner(string Owner, string Where, string TelephoneNr)
        {
            Owner owner = new Owner(Convert.ToInt32(TelephoneNr));
            owner.DeleteOwner(Owner, Where, TelephoneNr);
        }
        public object ShowAnimalDataTable(string TelephoneNr)
        {
            Owner owner = new Owner(Convert.ToInt32(TelephoneNr));
            object dt = owner.GetOwnersAnimalDataTable(TelephoneNr);
            return dt;
        }
    }
}
