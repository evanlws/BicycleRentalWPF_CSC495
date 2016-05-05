using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Data.OleDb;
namespace BicycleRentalWPF
{
    public class DataValidation
    {


        public static bool ValidateData(string bannerID, string password)
        {
            
            try 
            {
                OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                @"Data source=..\BicycleRental.accdb";
                conn.Open();            
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                command.CommandText = "SELECT * FROM  Worker WHERE BannerId = '" + bannerID + "' AND WorkerPassword = '" + password + "'";
                
                  OleDbDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    conn.Close();
                    return true;

                }

            }
            catch(Exception e) 
            {
                MessageBox.Show("Fail to connect to database");
            }
     






            

            return false;

        }

    }
}
