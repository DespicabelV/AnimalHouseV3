using System;
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
            string Qry = $"select * from OrdreLinje where Id = {Where} ";
            DBCOpenDB();
            SqlCommand SqlCMD = new SqlCommand(Qry, DBCOpenDB());
            SqlDataAdapter Adapter = new SqlDataAdapter(SqlCMD);
            DataTable dt = new DataTable();
            Adapter.Fill(dt);
            DBCCloseDB();
            return dt;
        }

        public void InsertIntoOrdreLineWhereX(int Faktura, int RessourceKatagori, int Ressource, double Pris, int Antal, bool Where)
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

        public void DBCInsertOrderLine(int Faktura, int RessourceKatagori, int Ressource, double Pris, int Antal)
        {
            DBCOpenDB();
            SqlCommand DBCInsertOrderLine = new SqlCommand();
            DBCInsertOrderLine.CommandText = $"INSERT INTO OrdreLinje (Faktura, RessourceKatagori, Ressource, Pris, Antal) " +
                $"VALUES({Faktura}, {RessourceKatagori}, {Ressource}, {Pris}, {Antal})";
            DBCInsertOrderLine.Connection = db;
            DBCInsertOrderLine.ExecuteNonQuery();
            DBCCloseDB();
        }

    }
}
