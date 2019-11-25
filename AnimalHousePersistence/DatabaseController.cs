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
            int DBCSelectCount;
            List<string> DBCListSelect = new List<string>();
            
            SqlCommand SelectFrom = new SqlCommand();
            SelectFrom.CommandText = $"SELECT * FROM {DBCFrom} WHERE {DBCWhere} = {DBCParam}";
            SelectFrom.Connection = db;
            reader = SelectFrom.ExecuteReader();
            reader.Read();

            DBCSelectCount = reader.FieldCount;
            for (int i = 0; i < DBCSelectCount; i++)
            {
                DBCListSelect.Add(Convert.ToString(reader.GetValue(i)));
            }
            
            DBCCloseDB();
            return DBCListSelect;
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
        
        public void DBCInsertBooking(int Behandling, int Laege, int Dyr, int Bur, int Burdage, string Dato, int Tid)
        {
            DBCOpenDB();
            SqlCommand DBCInsertAnimal = new SqlCommand();
            DBCInsertAnimal.CommandText = $"INSERT INTO Bookning (Behandling, Laege, Dyr, Bur, Burdage, Dato, Tid) " +
                $"VALUES({Behandling}, {Laege}, {Dyr}, {Bur}, {Burdage}, '{Dato}', {Tid})";
            DBCInsertAnimal.Connection = db;
            DBCInsertAnimal.ExecuteNonQuery();
            DBCCloseDB();
        }

        public void DBCInsertBusiness(int Ejer, string FirmaNavn, int CVR)
        {
            DBCOpenDB();
            SqlCommand DBCInsertAnimal = new SqlCommand();
            DBCInsertAnimal.CommandText = $"INSERT INTO Erhverv (Ejer, FirmaNavn, CVR) " +
                $"VALUES({Ejer}, '{FirmaNavn}', {CVR})";
            DBCInsertAnimal.Connection = db;
            DBCInsertAnimal.ExecuteNonQuery();
            DBCCloseDB();
        }

        public void DBCInsertRessource(int Pris, int VareKatagoriID)
        {
            DBCOpenDB();
            SqlCommand DBCInsertAnimal = new SqlCommand();
            DBCInsertAnimal.CommandText = $"INSERT INTO Ressource (Pris, VareKatagoriID) " +
                $"VALUES({Pris}, {VareKatagoriID})";
            DBCInsertAnimal.Connection = db;
            DBCInsertAnimal.ExecuteNonQuery();
            DBCCloseDB();
        }

        public void DBCInsertMedicin(int ID, string Navn)
        {
            DBCOpenDB();
            SqlCommand DBCInsertAnimal = new SqlCommand();
            DBCInsertAnimal.CommandText = $"INSERT INTO Medicin (ID, Navn) " +
                $"VALUES({ID}, '{Navn}')";
            DBCInsertAnimal.Connection = db;
            DBCInsertAnimal.ExecuteNonQuery();
            DBCCloseDB();
        }

        public void DBCInsertOrderLine(int Faktura, int RessourceKatagori, int Ressource, int Pris, int Antal)
        {
            DBCOpenDB();
            SqlCommand DBCInsertAnimal = new SqlCommand();
            DBCInsertAnimal.CommandText = $"INSERT INTO OrdreLinje (Faktura, RessourceKatagori, Ressource, Pris, Antal) " +
                $"VALUES({Faktura}, {RessourceKatagori}, {Ressource}, {Pris}, {Antal})";
            DBCInsertAnimal.Connection = db;
            DBCInsertAnimal.ExecuteNonQuery();
            DBCCloseDB();
        }

        public void DBCInsertOwner(int TelefonNr, string Fornavn, string Efternavn, string Adresse, string Email, string By, int Postnr)
        {
            DBCOpenDB();
            SqlCommand DBCInsertAnimal = new SqlCommand();
            DBCInsertAnimal.CommandText = $"INSERT INTO Ejer (TelefonNr, Fornavn, Efternavn, Adresse, Email, By_, PostNr)" +
                $"VALUES({TelefonNr}, '{Fornavn}', '{Efternavn}', '{Adresse}', '{Email}', '{By}', {Postnr})";
            DBCInsertAnimal.Connection = db;
            DBCInsertAnimal.ExecuteNonQuery();
            DBCCloseDB();
        }

        public void DBCInsertPrivate(int Ejer)
        {
            DBCOpenDB();
            SqlCommand DBCInsertAnimal = new SqlCommand();
            DBCInsertAnimal.CommandText = $"INSERT INTO Private_ (Ejer) " +
                $"VALUES({Ejer})";
            DBCInsertAnimal.Connection = db;
            DBCInsertAnimal.ExecuteNonQuery();
            DBCCloseDB();
        }

        public void DBCInsertReceipt(int Total, int Bookning, int Ejer)
        {
            DBCOpenDB();
            SqlCommand DBCInsertAnimal = new SqlCommand();
            DBCInsertAnimal.CommandText = $"INSERT INTO Faktura (Total, Bookning, Ejer)" +
                $"VALUES({Total}, {Bookning}, {Ejer})";
            DBCInsertAnimal.Connection = db;
            DBCInsertAnimal.ExecuteNonQuery();
            DBCCloseDB();
        }


        //Updates
        public void DBCUpdateOwner(int TelefonNr, string Fornavn, string Efternavn, string Adresse, string Email, string By_, int Postnr)
        {
            DBCOpenDB();
            SqlCommand DBCInsertAnimal = new SqlCommand();
            DBCInsertAnimal.CommandText = $"UPDATE Ejer " +
                $"SET TelefonNr = {TelefonNr}, Fornavn = '{Fornavn}',Efternavn = {Efternavn}, Adresse = '{Adresse}', Email = '{Email}', By_ = '{By_}', Postnr = {Postnr}" +
                $"WHERE TelefonNr = {TelefonNr}";
            DBCInsertAnimal.Connection = db;
            DBCInsertAnimal.ExecuteNonQuery();
            DBCCloseDB();
        }

        public void DBCUpdateAnimal(int ID, string Navn, char Kon, string Date, string Race, int Laege, int Chip)
        {
            DBCOpenDB();
            SqlCommand DBCInsertAnimal = new SqlCommand();
            DBCInsertAnimal.CommandText = $"UPDATE Dyr " +
                $"SET Navn = '{Navn}', Kon = '{Kon}', Fodselsdag = '{Date}', Race = '{Race}', Laege = {Laege}, Chip = {Chip}" +
                $"WHERE ID = {ID}";
            DBCInsertAnimal.Connection = db;
            DBCInsertAnimal.ExecuteNonQuery();
            DBCCloseDB();
        }

        public void DBCUpdateMedicin(int ID, string Navn)
        {
            DBCOpenDB();
            SqlCommand DBCInsertAnimal = new SqlCommand();
            DBCInsertAnimal.CommandText = $"UPDATE Medicin " +
                $"SET Navn = '{Navn}'" +
                $"WHERE ID = {ID}";
            DBCInsertAnimal.Connection = db;
            DBCInsertAnimal.ExecuteNonQuery();
            DBCCloseDB();
        }

        public void DBCUpdateRessource(int ID, int Pris, int VareKata)
        {
            DBCOpenDB();
            SqlCommand DBCInsertAnimal = new SqlCommand();
            DBCInsertAnimal.CommandText = $"UPDATE Ressource " +
                $"SET Pris = {Pris}, VarekatagoriID = {VareKata}" +
                $"WHERE ID = {ID}";
            DBCInsertAnimal.Connection = db;
            DBCInsertAnimal.ExecuteNonQuery();
            DBCCloseDB();
        }


        //Select From All
        public void DBCSelectFrom()
        {

        }
    }
}
