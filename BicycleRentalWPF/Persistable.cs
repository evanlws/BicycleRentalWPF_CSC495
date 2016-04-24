using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;

class Persistable
{
  System.Data.OleDb.OleDbConnection conn;
  protected static string connectionString { get; set; }
  public Persistable()
  {
    conn = new System.Data.OleDb.OleDbConnection();
  }

  public void configureConnection()
  {
    conn.ConnectionString = connectionString;
  }
  //------------------------------------------------------------------
  //  Retrieve data values from database and put them in an array list
  //  of objects, and return it. This is used when executing a SELECT
  //  query
  //------------------------------------------------------------------
  public List<Object> getValues(string queryString)
  {
    List<Object> results = new List<Object>();

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

  //------------------------------------------------------------------
  //  This modifies the database. Used by DELETE, UPDATE and INSERT
  //  operations
  //------------------------------------------------------------------
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
}
