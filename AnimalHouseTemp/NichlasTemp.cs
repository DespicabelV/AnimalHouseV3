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
    class NichlasTemp
    {
        public IPersistenceController Daba;
        public NichlasTemp()
        {
            Daba = new DatabaseController();
        }

        SqlConnection db;
        SqlDataReader reader;

        private SqlConnection DBCOpenDB()
        {
            db = new SqlConnection("Data source = den1.mssql8.gear.host; Initial Catalog = semester2; User Id = semester2; Password = Tz94m3Vv!!2Y");
            db.Open();
            return db;
        }

        private void DBCCloseDB()
        {
            db.Close();
        }

        public object SelectFromXToGridView(string from)
        {
            string qry = $"select * from {from}";
            DBCOpenDB();
            SqlCommand SqlCMD = new SqlCommand(qry, DBCOpenDB());
            SqlDataAdapter Sdr = new SqlDataAdapter(SqlCMD);
            DataTable dt = new DataTable();
            Sdr.Fill(dt);
            DBCCloseDB();
            return dt;
        }

        //Anden Constructor til Owner, som kun anvender de parameter jeg skal skal bruge
        public void SelectOwner()
        {
            //Daba.DBCSelectFromWhere();
        }
    }
}
