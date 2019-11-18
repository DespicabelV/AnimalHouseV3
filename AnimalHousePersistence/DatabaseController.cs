using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AnimalHousePersistence
{
    class DatabaseController
    {
        SqlConnection db;
        SqlDataReader reader;

        private SqlConnection DBCOpenDB()
        {
            db = new SqlConnection("Data source = den1.mssql7.gear.host; Initial Catalog = animalhousev3;User Id= animalhousev3 ;Password= Ts3N59?EL_mw");
            db.Open();
            return db;
        }

        public void DBCCloseDB()
        {
            db.Close();
        }

        public void DBCBeginTrans()
        {
            SqlCommand DBCTrans = new SqlCommand();
            DBCTrans.CommandText = "BEGIN TRANSACTION";
            DBCTrans.Connection = db;
            DBCTrans.ExecuteNonQuery();
        }

        public void DBCCommitTrans()
        {
            SqlCommand DBCCommit = new SqlCommand();
            DBCCommit.CommandText = "COMMIT";
            DBCCommit.Connection = db;
            DBCCommit.ExecuteNonQuery();
        }

        public void DBCRollbackTrans()
        {
            SqlCommand DBCRollback = new SqlCommand();
            DBCRollback.CommandText = "ROLLBACK";
            DBCRollback.Connection = db;
            DBCRollback.ExecuteNonQuery();
        }

        public void DBCDelete()
        {

        }

        public void DBCSelectFromWhere()
        {

        }

        public void DBCInsert()
        {

        }

        public void DBCUpdate()
        {

        }

        public void DBCSelectFrom()
        {

        }
    }
}
