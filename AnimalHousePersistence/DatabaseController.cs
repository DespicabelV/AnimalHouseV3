using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AnimalHousePersistence
{
    public class DatabaseController : IPersistenceController
    {
        SqlConnection db;
        SqlDataReader reader;

        //General SQL Statements
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

        public void DBCBeginTrans()
        {
            DBCOpenDB();
            SqlCommand DBCTrans = new SqlCommand();
            DBCTrans.CommandText = "BEGIN TRANSACTION";
            DBCTrans.Connection = db;
            DBCTrans.ExecuteNonQuery();
            DBCCloseDB();
        }

        public void DBCCommitTrans()
        {
            DBCOpenDB();
            SqlCommand DBCCommit = new SqlCommand();
            DBCCommit.CommandText = "COMMIT";
            DBCCommit.Connection = db;
            DBCCommit.ExecuteNonQuery();
            DBCCloseDB();
        }

        public void DBCRollbackTrans()
        {
            DBCOpenDB();
            SqlCommand DBCRollback = new SqlCommand();
            DBCRollback.CommandText = "ROLLBACK";
            DBCRollback.Connection = db;
            DBCRollback.ExecuteNonQuery();
            DBCCloseDB();
        }

        public bool CheckIfExist(string DBCFrom, string DBCWhere, string DBCParam)
        {
            int i;
            bool flag = true;
            DBCOpenDB();
            SqlCommand DBCCheck = new SqlCommand();
            DBCCheck.CommandText = $"SELECT COUNT(*) FROM {DBCFrom} WHERE {DBCWhere} = {DBCParam}";
            DBCCheck.Connection = db;
            i = (int) DBCCheck.ExecuteScalar();
            DBCCloseDB();

            if (i == 0)
            {
                flag = false;
            }

            return flag;
        }


        //Genaric Statemets used by all 
        public void DBCDelete(string DBCFrom, string DBCWhere, string DBCParam)
        {
            DBCOpenDB();
            SqlCommand Delete_ = new SqlCommand();
            Delete_.CommandText = $"DELETE FROM {DBCFrom} WHERE {DBCWhere} ='{DBCParam}'";
            Delete_.Connection = db;
            Delete_.ExecuteNonQuery();
            DBCCloseDB();
        }

        public List<string> DBCSelectFromWhere(string DBCFrom, string DBCWhere, string DBCParam)
        {
            DBCOpenDB();
            List<string> DBCListSelect = new List<string>();
            
            SqlCommand SelectFrom = new SqlCommand();
            SelectFrom.CommandText = $"SELECT * FROM {DBCFrom} WHERE {DBCWhere} = {DBCParam}";
            SelectFrom.Connection = db;
            reader = SelectFrom.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    DBCListSelect.Add(Convert.ToString(reader.GetValue(i)));
                }
            }

            DBCCloseDB();
            return DBCListSelect;
        }

        public List<string> DBCSelectSpecificFromWhere(string DBCSelect ,string DBCFrom, string DBCWhere, string DBCParam)
        {
            DBCOpenDB();
            List<string> DBCListSelectSp = new List<string>();

            SqlCommand SelectFrom = new SqlCommand();
            SelectFrom.CommandText = $"SELECT {DBCSelect} FROM {DBCFrom} WHERE {DBCWhere} = {DBCParam}";
            SelectFrom.Connection = db;
            reader = SelectFrom.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    DBCListSelectSp.Add(Convert.ToString(reader.GetValue(i)));
                }
            }

            DBCCloseDB();
            return DBCListSelectSp;
        }

        public List<string> DBCSelectSpecific(string DBCSelect, string DBCFrom)
        {
            DBCOpenDB();
            List<string> DBCListSelectSp = new List<string>();

            SqlCommand SelectFrom = new SqlCommand();
            SelectFrom.CommandText = $"SELECT {DBCSelect} FROM {DBCFrom}";
            SelectFrom.Connection = db;
            reader = SelectFrom.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    DBCListSelectSp.Add(Convert.ToString(reader.GetValue(i)));
                }
            }

            DBCCloseDB();
            return DBCListSelectSp;
        }

        public List<string> DBCSelectFrom(string DBCFrom)
        {
            DBCOpenDB();
            List<string> DBCListSelect = new List<string>();

            SqlCommand SelectFrom = new SqlCommand();
            SelectFrom.CommandText = $"SELECT * FROM {DBCFrom}";
            SelectFrom.Connection = db;
            reader = SelectFrom.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    DBCListSelect.Add(Convert.ToString(reader.GetValue(i)));
                }
            }

            DBCCloseDB();
            return DBCListSelect;
        }

        public List<string> DBCSelectAnimal(string DBCName, string DBCDate, string DBCRace, char DBCGender)
        {
            DBCOpenDB();
            List<string> DBCSelectAnimal = new List<string>();

            SqlCommand SelectFrom = new SqlCommand();
            SelectFrom.CommandText = $"select * from Dyr where navn = '{DBCName}' and Fodselsdag= '{DBCDate}' and Race ='{DBCRace}' and Kon ='{DBCGender}'";
            SelectFrom.Connection = db;
            reader = SelectFrom.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    DBCSelectAnimal.Add(Convert.ToString(reader.GetValue(i)));
                }
            }

            DBCCloseDB();
            return DBCSelectAnimal;
        }

        public List<string> DBCBookedTimes(string DBCDate, string DBCDoctor)
        {
            DBCOpenDB();
            List<string> DBCBookedTimes = new List<string>();

            SqlCommand DBCTiderCom = new SqlCommand();
            DBCTiderCom.CommandText = $"select Tider.FraTil, Tider.ID from Tider " +
                $"left outer Join Bookning On Bookning.Tid = Tider.ID where Bookning.Dato = '{DBCDate}' and Bookning.Laege = {DBCDoctor}";
            DBCTiderCom.Connection = db;
            reader = DBCTiderCom.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    DBCBookedTimes.Add(Convert.ToString(reader.GetValue(i)));
                }
            }

            DBCCloseDB();
            return DBCBookedTimes;
        }

        public List<string> DBCTimes()
        {
            DBCOpenDB();
            List<string> DBCTimesList = new List<string>();

            SqlCommand DBCTime = new SqlCommand();
            DBCTime.CommandText = $"select * from Tider";
            DBCTime.Connection = db;
            reader = DBCTime.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    DBCTimesList.Add(Convert.ToString(reader.GetValue(i)));
                }
            }

            DBCCloseDB();
            return DBCTimesList;
        }

        public string DBCGetDoctor(string DBCPram)
        {
            DBCOpenDB();
            string DBCGetDoctorString;

            SqlCommand SelectFromJoin = new SqlCommand();
            SelectFromJoin.CommandText = $"select Laege.Navn from Laege " +
                $"right outer join Dyr on Laege.ID = Dyr.Laege " +
                $"where Dyr.ID = {DBCPram}";
            SelectFromJoin.Connection = db;
            DBCGetDoctorString = (string)SelectFromJoin.ExecuteScalar();

            DBCCloseDB();
            return DBCGetDoctorString;
        }

        public List<string> DBCGetMedicinPrint()
        {
            DBCOpenDB();
            List<string> DBCMedicinList = new List<string>();

            SqlCommand DBCGetMedicinPrint = new SqlCommand();
            DBCGetMedicinPrint.CommandText = $"select Ressource.VareKatagoriID, Medicin.ID, Medicin.Navn, Medicin.Antal, Ressource.Pris from Medicin " +
                $"Left join Ressource On Medicin.ID = Ressource.ID";
            DBCGetMedicinPrint.Connection = db;
            reader = DBCGetMedicinPrint.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    DBCMedicinList.Add(Convert.ToString(reader.GetValue(i)));
                }
            }

            DBCCloseDB();
            return DBCMedicinList;
        }

        public List<string> DBCGetRessourcePrint()
        {
            DBCOpenDB();
            List<string> DBCRessourceList = new List<string>();

            SqlCommand DBCGetRessourcePrint = new SqlCommand();
            DBCGetRessourcePrint.CommandText = $"select Ressource.VareKatagoriID, Hyldevare.ID, Hyldevare.Navn, Hyldevare.Antal, Ressource.Pris from Hyldevare " +
                $"Left join Ressource On Hyldevare.ID = Ressource.ID";
            DBCGetRessourcePrint.Connection = db;
            reader = DBCGetRessourcePrint.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    DBCRessourceList.Add(Convert.ToString(reader.GetValue(i)));
                }
            }

            DBCCloseDB();
            return DBCRessourceList;
        }

        public List<string> DBCPrintDocktorLetter()
        {
            DBCOpenDB();

            List<string> DBCDoctorLetterList = new List<string>();

            SqlCommand DBCPrintDocktorLetter = new SqlCommand();
            DBCPrintDocktorLetter.CommandText = $"select Bookning.dyr,Bookning.Ejer,Bookning.Dato,Bookning.Behandling,Bookning.Laege from Bookning " +
                $"WHERE Dato<DATEADD(YEAR, -1, GETDATE())";
            DBCPrintDocktorLetter.Connection = db;
            reader = DBCPrintDocktorLetter.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    DBCDoctorLetterList.Add(Convert.ToString(reader.GetValue(i)));
                }
            }

            DBCCloseDB();
            return DBCDoctorLetterList;
        }


        //Inserts
        public void DBCInsertAnimal(string Navn, char Kon, string Fodselsdag, string Race, int Laege, int Chip)
        {
            DBCOpenDB();
            SqlCommand DBCInsertAnimal = new SqlCommand();
            DBCInsertAnimal.CommandText = $"INSERT INTO Dyr (Navn, Kon, Fodselsdag, Race, Laege, Chip) " +
                $"VALUES('{Navn}', '{Kon}', '{Fodselsdag}', '{Race}', {Laege}, {Chip})";
            DBCInsertAnimal.Connection = db;
            DBCInsertAnimal.ExecuteNonQuery();
            DBCCloseDB();
        }

        public void DBCInsertRelation(int Ejer, int Dyr)
        {
            DBCOpenDB();
            SqlCommand DBCInsertRelation = new SqlCommand();
            DBCInsertRelation.CommandText = $"INSERT INTO Relation (Ejer, Dyr) " +
                $"VALUES({Ejer}, {Dyr})";
            DBCInsertRelation.Connection = db;
            DBCInsertRelation.ExecuteNonQuery();
            DBCCloseDB();
        }
        
        public void DBCInsertBooking(int Behandling, int Laege, int Dyr, int Bur, int Burdage, string Dato, int Tid, int Ejer)
        {
            DBCOpenDB();
            SqlCommand DBCInsertBooking = new SqlCommand();
            DBCInsertBooking.CommandText = $"INSERT INTO Bookning (Behandling, Laege, Dyr, Bur, Burdage, Dato, Tid, Ejer) " +
                $"VALUES({Behandling}, {Laege}, {Dyr}, {Bur}, {Burdage}, '{Dato}', {Tid}, {Ejer})";
            DBCInsertBooking.Connection = db;
            DBCInsertBooking.ExecuteNonQuery();
            DBCCloseDB();
        }

        public void DBCInsertBusiness(int Ejer, string FirmaNavn, int CVR)
        {
            DBCOpenDB();
            SqlCommand DBCInsertBusiness = new SqlCommand();
            DBCInsertBusiness.CommandText = $"INSERT INTO Erhverv (Ejer, FirmaNavn, CVR) " +
                $"VALUES({Ejer}, '{FirmaNavn}', {CVR})";
            DBCInsertBusiness.Connection = db;
            DBCInsertBusiness.ExecuteNonQuery();
            DBCCloseDB();
        }

        public void DBCInsertRessource(int Pris, int VareKatagoriID)
        {
            DBCOpenDB();
            SqlCommand DBCInsertRessource = new SqlCommand();
            DBCInsertRessource.CommandText = $"INSERT INTO Ressource (Pris, VareKatagoriID) " +
                $"VALUES({Pris}, {VareKatagoriID})";
            DBCInsertRessource.Connection = db;
            DBCInsertRessource.ExecuteNonQuery();
            DBCCloseDB();
        }

        public void DBCInsertMedicin(int ID, string Navn)
        {
            DBCOpenDB();
            SqlCommand DBCInsertMedicin = new SqlCommand();
            DBCInsertMedicin.CommandText = $"INSERT INTO Medicin (ID, Navn) " +
                $"VALUES({ID}, '{Navn}')";
            DBCInsertMedicin.Connection = db;
            DBCInsertMedicin.ExecuteNonQuery();
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

        public void DBCInsertOwner(int TelefonNr, string Fornavn, string Efternavn, string Adresse, string Email, string By, int Postnr)
        {
            DBCOpenDB();
            SqlCommand DBCInsertOwner = new SqlCommand();
            DBCInsertOwner.CommandText = $"INSERT INTO Ejer (TelefonNr, Fornavn, Efternavn, Adresse, Email, By_, PostNr)" +
                $"VALUES({TelefonNr}, '{Fornavn}', '{Efternavn}', '{Adresse}', '{Email}', '{By}', {Postnr})";
            DBCInsertOwner.Connection = db;
            DBCInsertOwner.ExecuteNonQuery();
            DBCCloseDB();
        }

        public void DBCInsertPrivate(int Ejer)
        {
            DBCOpenDB();
            SqlCommand DBCInsertPrivate = new SqlCommand();
            DBCInsertPrivate.CommandText = $"INSERT INTO Private_ (Ejer) " +
                $"VALUES({Ejer})";
            DBCInsertPrivate.Connection = db;
            DBCInsertPrivate.ExecuteNonQuery();
            DBCCloseDB();
        }

        public int DBCInsertReceipt(int Total, int Bookning, int Ejer)
        {
            int TempID;
            DBCOpenDB();
            SqlCommand DBCInsertReceipt = new SqlCommand();
            DBCInsertReceipt.CommandText = $"INSERT INTO Faktura (Total, Bookning, Ejer) output INSERTED.ID " +
                $"VALUES({Total}, {Bookning}, {Ejer})";
            DBCInsertReceipt.Connection = db;
            TempID = (int)DBCInsertReceipt.ExecuteScalar();
            DBCCloseDB();
            return TempID;
        }

        public void DBCInsertJournal(int Laege, int Dyr, string Dato, string Emne, string Kommentar)
        {
            DBCOpenDB();
            SqlCommand DBCInsertJournal = new SqlCommand();
            DBCInsertJournal.CommandText = $"INSERT INTO Journal (Laege, Dyr, Dato, Emne, Kommentar)" +
                $"VALUES({Laege}, {Dyr}, '{Dato}', '{Emne}', '{Kommentar}')";
            DBCInsertJournal.Connection = db;
            DBCInsertJournal.ExecuteNonQuery();
            DBCCloseDB();
        }


        //Updates
        public void DBCUpdateOwner(int TelefonNr, string Fornavn, string Efternavn, string Adresse, string Email, string By_, int Postnr)
        {
            DBCOpenDB();
            SqlCommand DBCUpdateOwner = new SqlCommand();
            DBCUpdateOwner.CommandText = $"UPDATE Ejer " +
                $"SET TelefonNr = {TelefonNr}, Fornavn = '{Fornavn}',Efternavn = {Efternavn}, Adresse = '{Adresse}', Email = '{Email}', By_ = '{By_}', Postnr = {Postnr}" +
                $"WHERE TelefonNr = {TelefonNr}";
            DBCUpdateOwner.Connection = db;
            DBCUpdateOwner.ExecuteNonQuery();
            DBCCloseDB();
        }

        public void DBCUpdateAnimal(int ID, string Navn, char Kon, string Date, string Race, int Laege, int Chip)
        {
            DBCOpenDB();
            SqlCommand DBCUpdateAnimal = new SqlCommand();
            DBCUpdateAnimal.CommandText = $"UPDATE Dyr " +
                $"SET Navn = '{Navn}', Kon = '{Kon}', Fodselsdag = '{Date}', Race = '{Race}', Laege = {Laege}, Chip = {Chip}" +
                $"WHERE ID = {ID}";
            DBCUpdateAnimal.Connection = db;
            DBCUpdateAnimal.ExecuteNonQuery();
            DBCCloseDB();
        }

        public void DBCUpdateMedicin(int ID, string Navn)
        {
            DBCOpenDB();
            SqlCommand DBCUpdateMedicin = new SqlCommand();
            DBCUpdateMedicin.CommandText = $"UPDATE Medicin " +
                $"SET Navn = '{Navn}'" +
                $"WHERE ID = {ID}";
            DBCUpdateMedicin.Connection = db;
            DBCUpdateMedicin.ExecuteNonQuery();
            DBCCloseDB();
        }

        public void DBCUpdateBusiness(int ID, string Navn, string CVR)
        {
            DBCOpenDB();
            SqlCommand DBCUpdateBusiness = new SqlCommand();
            DBCUpdateBusiness.CommandText = $"UPDATE Erhverv " +
                $"SET FirmaNavn = '{Navn}', CVR = {CVR}" +
                $"WHERE Ejer = {ID}";
            DBCUpdateBusiness.Connection = db;
            DBCUpdateBusiness.ExecuteNonQuery();
            DBCCloseDB();
        }

        public void DBCUpdateRessource(int ID, int Pris)
        {
            DBCOpenDB();
            SqlCommand DBCUpdateRessource = new SqlCommand();
            DBCUpdateRessource.CommandText = $"UPDATE Ressource " +
                $"SET Pris = {Pris} " +
                $"WHERE ID = {ID}";
            DBCUpdateRessource.Connection = db;
            DBCUpdateRessource.ExecuteNonQuery();
            DBCCloseDB();
        }

        public void DBCUpdateBookning(int Behandling, int Laege, int ID, int Bur, int Burdag, string Dato, int Tid)
        {
            DBCOpenDB();
            SqlCommand DBCUpdateBookning = new SqlCommand();
            DBCUpdateBookning.CommandText = $"UPDATE Bookning " +
                $"SET Behandling = {Behandling}, Laege = {Laege}, Bur = {Bur}, Burdage = {Burdag}, Dato = '{Dato}', Tid = {Tid}" +
                $"WHERE ID = {ID}";
            DBCUpdateBookning.Connection = db;
            DBCUpdateBookning.ExecuteNonQuery();
            DBCCloseDB();
        }
    }
}
