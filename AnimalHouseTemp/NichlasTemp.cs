﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHousePersistence;
using System.Data.SqlClient;
using AnimalHouseEntity;
using System.Data;

namespace AnimalHouseTemp
{
    public class Medicinz : Ressource
    {
        private string Name;
        private int Amount;

        public Medicinz(int ID, double Price, int ProductCategoryID, string Name, int Amount) : base(ID, Price, ProductCategoryID)
        {
            this.Name = Name;
            this.Amount = Amount;
        }
        public Medicinz(int ID, int Amount) : base(ID)
        {
            this.Amount = Amount;
            
        }


        public void UpdateAmountInStock(string Item, int Id, int Amount)
        {
            NichlasTemp Temp = new NichlasTemp();
            Temp.DBCUpdateAmountInStock(Item,Amount,Id);
        }
    
    }
    public class AlmostReceipt
    {
        private int ID;
        private int PriceTotal;
        private int BookingID;
        private int EjerTelefonNr;

        public AlmostReceipt(int ID, int PriceTotal, int BookingID, int EjerTelefonNr)
        {
            this.ID = ID;
            this.PriceTotal = PriceTotal;
            this.BookingID = BookingID;
            this.EjerTelefonNr = EjerTelefonNr;
        }

        public AlmostReceipt(int PriceTotal, int BookingID, int EjerTelefonNr)
        {
            this.PriceTotal = PriceTotal;
            this.BookingID = BookingID;
            this.EjerTelefonNr = EjerTelefonNr;
        }
        public void InsertReciept()
        {
            IPersistenceController DBC = new DatabaseController();
            DBC.DBCInsertReceipt(PriceTotal,BookingID,EjerTelefonNr);

        }
    }


    public class EntityLejeOrdre
    {
        private int ID;
        private int ReceiptID;
        private int ProductCategoryID;
        private int RessourceId;
        private int Price;
        private int Amount;


        public EntityLejeOrdre(int ReceiptID, int ProductCategoryID,int RessourceID, int Price, int Amount)
        {
            this.ReceiptID = ReceiptID;
            this.ProductCategoryID = ProductCategoryID;
            this.RessourceId = RessourceID;
            this.Price = Price;
            this.Amount = Amount;
        }

        public EntityLejeOrdre(int Price, int Amount)
        {
            this.Price = Price;
            this.Amount = Amount;
        }
        public EntityLejeOrdre(int Price)
        {
            this.Price = Price;
        }

        public double Discount(int Price, int Discount)
        {
            double NewPrice;
            NewPrice = Price - ((Price/100)*Discount);
            return NewPrice;
        }
        public double ChangeOfPriceWithMoms(int Price, int Amount, int OldPrice)
        {
            double NewPrice = Price;
            Convert.ToDouble(OldPrice);
            NewPrice = (NewPrice * 1.25)*Amount;
            NewPrice = NewPrice + Convert.ToDouble(OldPrice);
            return NewPrice;
        }

        public double ChangeOfPriceWithOutMoms(int Price, int Amount, int OldPrice)
        {
            double NewPrice = Price;
            NewPrice = NewPrice * Amount;
            NewPrice = NewPrice + Convert.ToDouble(OldPrice);
            return NewPrice;
        }

    }

    public class NæstenController
    {
        public void InsertOrderLine(int Faktura, int RessourceKatagori, int Ressource, int Price, int Antal)
        {
            EntityLejeOrdre ELO = new EntityLejeOrdre(Faktura,RessourceKatagori,Ressource,Price,Antal);
            NichlasTemp Temp = new NichlasTemp();
            Temp.DBCInsertOrderLine(Faktura,RessourceKatagori,Ressource,Price,Antal);
        }

        public int Discount(int Price, int Discount)
        {
            EntityLejeOrdre ELO = new EntityLejeOrdre(Price);
             return Convert.ToInt32(ELO.Discount(Price,Discount));
        }

        public int ChangeOfPriceWithOutMoms(int Price, int Amount, int OldPrice)
        {
            EntityLejeOrdre ELO = new EntityLejeOrdre(Price,Amount);
            return Convert.ToInt32(ELO.ChangeOfPriceWithOutMoms(Price, Amount, OldPrice));
        }

        public int ChangeOfPriceWithMoms(int Price, int Amount, int OldPrice)
        {
            EntityLejeOrdre ELO = new EntityLejeOrdre(Price, Amount);
            return Convert.ToInt32(ELO.ChangeOfPriceWithMoms(Price, Amount,OldPrice));
        }

        public void UpdateAmountInStock(string Item, int Id, int Amount, int WantedAmount)
        {

            Medicinz MIDZ = new Medicinz(Id,Amount);
            Amount = Amount - WantedAmount;
            MIDZ.UpdateAmountInStock(Item, Id, Amount);

        }

        public void InsertReciept(int PriceTotal, int Bookning, int Ejer)
        {
            AlmostReceipt almostReceipt = new AlmostReceipt(PriceTotal,Bookning, Ejer);
            almostReceipt.InsertReciept();
        }
    }

    public class NichlasTemp
    {
        public IPersistenceController Daba;
        public NichlasTemp()
        {
            Daba = new DatabaseController();
        }

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

        //Sql Statements

        //Vælger bare en bestemt table og retunerne det som en datatable
        public object SelectFromXToGridView(string Table)
        {
            string Qry = $"select Ressource.VareKatagoriID, {Table}.*, Ressource.Pris from {Table},Ressource where {Table}.ID = Ressource.ID";
            DBCOpenDB();
            SqlCommand SqlCMD = new SqlCommand(Qry, DBCOpenDB());
            SqlDataAdapter Sdr = new SqlDataAdapter(SqlCMD);
            DataTable dt = new DataTable();
            Sdr.Fill(dt);
            DBCCloseDB();
            return dt;
        }

        //Selecter fra bestemt table og hvad det skal være  og retunerne det som en datatable
        public object SelectFromXToGridViewWhereX(string Table, string Where)
        {
            string Qry = $"select  Ressource.VareKatagoriID, {Table}.*, Ressource.Pris from {Table},Ressource where {Table}.ID = Ressource.ID and Navn Like '%{Where}%'";
            DBCOpenDB();
            SqlCommand SqlCMD = new SqlCommand(Qry, DBCOpenDB());
            SqlDataAdapter Adapter = new SqlDataAdapter(SqlCMD);
            DataTable dt = new DataTable();
            Adapter.Fill(dt);
            DBCCloseDB();
            return dt;
        }

        public object SelectFromOrdreLine(int Where)
        {
            string Qry = $"select * from OrdreLinje where Faktura = {Where} ";
            DBCOpenDB();
            SqlCommand SqlCMD = new SqlCommand(Qry, DBCOpenDB());
            SqlDataAdapter Adapter = new SqlDataAdapter(SqlCMD);
            DataTable dt = new DataTable();
            Adapter.Fill(dt);
            DBCCloseDB();
            return dt;
        }

        public void InsertIntoOrdreLineWhereX(int Faktura, int RessourceKatagori, int Ressource, int Pris, int Antal, bool Where)
        {
            DBCOpenDB();
            SqlCommand DBCInsertAnimal = new SqlCommand();
            DBCInsertAnimal.CommandText = $"INSERT INTO OrdreLinje (Faktura, RessourceKatagori, Ressource, Pris, Antal) " +
                $"VALUES({Faktura}, {RessourceKatagori}, {Ressource}, {Pris}, {Antal}) where ID = {Where}";
            DBCInsertAnimal.Connection = db;
            DBCInsertAnimal.ExecuteNonQuery();
            DBCCloseDB();
        }

        public void UpdateAmountInStockForUniqueItem(string Category,int Amount, int Where)
        {
            DBCOpenDB();
            SqlCommand UpdateAmountInStockForUniqueItem = new SqlCommand();
            UpdateAmountInStockForUniqueItem.CommandText = $"UPDATE {Category} " +
                $"SET Antal = '{Amount}'" +
                $"WHERE ID = {Where}";
            UpdateAmountInStockForUniqueItem.Connection = db;
            UpdateAmountInStockForUniqueItem.ExecuteNonQuery();
            DBCCloseDB();
        }

        public void DBCInsertOrderLine(int Faktura, int RessourceKatagori, int Ressource, int Pris, int Antal)
        {
            DBCOpenDB();
            SqlCommand DBCInsertOrderLine = new SqlCommand();
            DBCInsertOrderLine.CommandText = $"INSERT INTO OrdreLinje (Faktura, RessourceKatagori, Ressource, Pris, Antal) " +
                $"VALUES({Faktura}, {RessourceKatagori}, {Ressource}, {Pris}, {Antal})";
            DBCInsertOrderLine.Connection = db;
            DBCInsertOrderLine.ExecuteNonQuery();
            DBCCloseDB();
        }

        public void DBCUpdateAmountInStock(string Item,int ID, int NewAmount)
        {
            DBCOpenDB();
            SqlCommand SqlCommand = new SqlCommand();
            SqlCommand.CommandText = $"UPDATE {Item} " +
                $"SET Antal = '{NewAmount}', WHERE ID = {ID}";
            SqlCommand.Connection = db;
            SqlCommand.ExecuteNonQuery();
            DBCCloseDB();
        }
        //Console/Entity Kode

        public bool CheckIfExsist1(string OwnerID)
        {
            IPersistenceController DBController = new DatabaseController();
            return DBController.CheckIfExist("Ejer","TelefonNr",OwnerID);
        }
        public bool CheckIfExsist(string OwnerID)
        {
            NichlasTemp Temp = new NichlasTemp();
            return Temp.CheckIfExsist1(OwnerID);
        }

        public List<string> GetOwner1(string OwnerID)
        {
            IPersistenceController DBController = new DatabaseController();
            List<string> ListOwner;

            ListOwner = DBController.DBCSelectSpecificFromWhere("TelefonNr","Ejer","TelefonNr",OwnerID);

            return ListOwner;
        }


        public List<string> GetOwner(string OwnerID)
        {
            NichlasTemp Temp = new NichlasTemp();
            return Temp.GetOwner1(OwnerID);
        }

        public List<string> GetBookning1(string OwnerID)
        {
            IPersistenceController DBController = new DatabaseController();
            List<string> ListReceipt;

            ListReceipt = DBController.DBCSelectSpecificFromWhere("ID","Bookning","Ejer",OwnerID);

            return ListReceipt;
        }

        public List<string> GetBookning(string OwnerId)
        {
            NichlasTemp Temp = new NichlasTemp();
            return Temp.GetBookning(OwnerId);
        }
    }
}
