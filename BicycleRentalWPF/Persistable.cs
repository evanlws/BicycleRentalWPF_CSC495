using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BicycleRentalWPF
{

    public class Persistable
    {
        System.Data.OleDb.OleDbConnection conn;
        protected static string connectionString { get; set; }
        public Persistable()
        {
            conn = new
                System.Data.OleDb.OleDbConnection();

        }

        public void configureConnection()
        {
            conn.ConnectionString = connectionString;
        }

        public List <Object> getValues(string queryString)
        {
            List <Object> results = new List <Object>();

            configureConnection();
            using (conn)
            {
                System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand(queryString, conn);
                try
                {
                    conn.Open();
                    System.Data.OleDb.OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Object[] nextRow = new Object[reader.FieldCount];
                        reader.GetValues(nextRow);
                        results.Add(nextRow);
                    }

                    return results;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return null;
                }
            }
        }

        public int modifyDatabase(string queryString)
        {
            configureConnection();
            using (conn)
            {
                System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand(queryString);

                // Set the Connection to the new OleDbConnection.
                command.Connection = conn;

                // Open the connection and execute the insert command. 
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    return 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return 1;
                }
            }
        }
    } //end Persistable

}
