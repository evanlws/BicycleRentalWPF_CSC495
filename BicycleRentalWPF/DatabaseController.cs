using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRentalWPF
{
    class DatabaseController
    {
        System.Data.OleDb.OleDbConnection conn;
        OleDbCommand command;
        //bool flag;
        public DatabaseController()
        {
            conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data source=..\BicycleRental.accdb";
            command = new OleDbCommand();
            command.Connection = conn;
        }

        public void checkBannerID(string id)
        {
            command.CommandText = "SELECT * FROM  Worker WHERE BannerId = '" + id + "'";
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                conn.Close();
                //flag = true;
            }

            //flag = false;
        }


        public void checkBannerPassword(string password)
        {
            command.CommandText = "SELECT * FROM  Worker WHERE Credentials = '" + password + "'";
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                conn.Close();
                //flag = true;
            }

           // flag = false;
        }
    }
}
