using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AnimalHousePersistence
{
    public class DatabaseController : IDatabaseController
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

        public static void DBCRollbackTrans()
        {
            SqlCommand DBCRollback = new SqlCommand();
            DBCRollback.CommandText = "ROLLBACK";
            DBCRollback.Connection = db;
            DBCRollback.ExecuteNonQuery();
        }


        //Genaric Statemets used by all 
        public void DBCDelete(string DBCFrom, string DBCWhere, string DBCParam)
        {
            SqlCommand Delete_ = new SqlCommand();
            Delete_.CommandText = $"DELETE FROM {DBCFrom} WHERE {DBCWhere} ='{DBCParam}'";
            Delete_.Connection = db;
            Delete_.ExecuteNonQuery();
        }

        public object DBCSelectFromWhere(string DBCFrom, string DBCWhere, string DBCParam)
        {
            object DBCSelectObject;
            SqlCommand SelectFrom = new SqlCommand();
            SelectFrom.CommandText = $"SELECT FROM {DBCFrom} WHERE {DBCWhere} ='{DBCParam}'";
            SelectFrom.Connection = db;
            DBCSelectObject = SelectFrom.ExecuteReader();
            return DBCSelectObject;
        }


        //Inserts
        public void DBCInsertAnimal()
        {

        }

        public void DBCInsertBooking()
        {

        }

        public void DBCInsertBusiness()
        {

        }

        public void DBCInsertMedicin()
        {

        }

        public void DBCInsertOrderLine()
        {

        }

        public void DBCInsertOwner()
        {

        }

        public void DBCInsertPrivate()
        {

        }

        public void DBCInsertReceipt()
        {

        }


        //Updates
        public void DBCUpdateOwner()
        {

        }

        public void DBCUpdateAnimal()
        {

        }

        public void DBCUpdateMedicin()
        {

        }


        //Select From All
        public void DBCSelectFrom()
        {

        }
    }
}
