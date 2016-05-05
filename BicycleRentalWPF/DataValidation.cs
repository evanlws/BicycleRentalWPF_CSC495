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

        public static bool ValidateLogin(Worker worker)
        {
        
            try 
            {  
                OleDbConnection conn = new OleDbConnection ();
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                @"Data source=..\BicycleRental.accdb";
                conn.Open();            
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                command.CommandText = "SELECT * FROM  Worker WHERE BannerId = '" + w1.getBannerId() + "' AND WorkerPassword = '" + w1.getWorkerPassword() + "'";
                
                OleDbDataReader reader = command.ExecuteReader();

                //return true if id and password matches
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
     
            return false;//return false if log in doesnt match database

        }//end ValidateLogin method
         
        
        /*
      public static bool ValidateInsertUser(User newUser)
      {

          try
          {
              OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
              conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
              @"Data source=..\BicycleRental.accdb";
              conn.Open();
              OleDbCommand command = new OleDbCommand();
              command.Connection = conn;
              command.CommandText = "SELECT * FROM  User WHERE BannerId = '" + userInfo[0] + "'";//look if id already in database or not

              OleDbDataReader reader = command.ExecuteReader();

              //return true if id and password matches
              if(reader.Read())
              {
                  MessageBox.Show("Match id");

                  conn.Close();
                  return true;
              }
          }
          catch(Exception e)
          {
              MessageBox.Show("Fail to connect to database");
          }

          return false;//return false if log in doesnt match database

          return false;//return false if log in doesnt match database
      }
      */
    }//end DataValidation
}
