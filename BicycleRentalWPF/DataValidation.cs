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
        DatabaseController dbc;
       

        public DataValidation()
        {
            dbc = new DatabaseController();

        }


        public  bool Login(List<string> dataInput)
        {

            dbc.checkBannerID(dataInput[0]);
            dbc.checkBannerID(dataInput[1]);
            return false;
        }








        /*
                public static bool connection(string validateTypeput, List<string> dataInput)
                {
                    OleDbConnection conn = new OleDbConnection();
                    conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                    @"Data source=..\BicycleRental.accdb";

                    switch (validateTypeput)
                    {
                        case "login":
                            ValidateID(conn, dataInput);
                            ValidPassword()
                            break;
                        case
                    }

                    return false;
                }

                public static bool ValidateLogin(OleDbConnection conn, List<string> dataInput)
                {

                    try 
                    {  
                        conn.Open();            
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = conn;
                        command.CommandText = "SELECT * FROM  Worker WHERE BannerId = '" + worker.getBannerId() + "' AND WorkerPassword = '" + worker.getWorkerPassword() + "'";

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
                       MessageBox.Show(e.ToString());
                    }

                    return false;//return false if log in doesnt match database

                }//end ValidateLogin method


        /*        
              public static bool ValidateInsertUser(User user)
              {

                    return checkID(user.getBannerId());
              }

            private static bool checkID(string id)
            {
                Regex regex = new Regex(@"\d{9}");
                Match match = regex.Match(id);
                    if (match.Success)
                        return true;

                return false;
            }

            private static bool checkFirstName(string id)
            {



                return false;
            }
            private static bool checkLastName(string id)
            {



                return false;
            }

            private static bool checkPhoneNumber(string id)
            {



                return false;
            }

            private static bool checkEmail(string id)
            {



                return false;
            }


            private static bool checkEmptyString(string inputData)
            {
                return (!(inputData == null || inputData == ""));
            }


        */

    }//end DataValidation

   
    
}
