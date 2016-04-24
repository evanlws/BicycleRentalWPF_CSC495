using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRentalCLI
{
  class Fine : Persistable
  {
    private int ID { get; set; }
    private string BannerID { get; set; }
    private string FineAmount { get; set; }
    private string DateFineImposed { get; set; }
    private string Status { get; set; }
    private string DateStatusUpdated { get; set; }

    public Fine()
      : base() // call parent default constructor
    {
      connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
          @"Data source=BicycleRental.accdb";
    }
    //------------------------------------------------------------------
    public Fine(string bannerId, string fineAmount, string dateFineImposed, string status, string dateStatusUpdated)
      : base()
    {
      connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
          @"Data source=BicycleRental.accdb";

      this.BannerID = bannerId;
      this.FineAmount = fineAmount;
      this.DateFineImposed = dateFineImposed;
      this.Status = status;
      this.DateStatusUpdated = dateStatusUpdated;

    }
    //------------------------------------------------------------------
    public void populate(int Id)
    {
      string queryString = "SELECT * FROM Fine WHERE (ID = " + Id + ")";
      List<Object> results = getValues(queryString);
      if (results != null)
      {
        foreach (object result in results)
        {
          IEnumerable<Object> row = result as IEnumerable<Object>;
          int count = 0;
          foreach (object rowValue in row)
          {
            // DEBUG Console.WriteLine(rowValue);
            if (count == 0)
              ID = Convert.ToInt32(rowValue);
            else if (count == 1)
              BannerID = Convert.ToString(rowValue);
            else if (count == 2)
              FineAmount = Convert.ToString(rowValue);
            else if (count == 3)
              DateFineImposed = Convert.ToString(rowValue);
            else if (count == 4)
              Status = Convert.ToString(rowValue);
            else if (count == 5)
              DateStatusUpdated = Convert.ToString(rowValue);
            count = count + 1;
          }
        }
      }
    }

    public void insert()
    {

      string insertQuery =
      "INSERT INTO Fine (BannerID, FineAmount, DateFineImposed, Status, DateStatusUpdated) " +
      "VALUES (" +
      "'" + this.BannerID + "', '" +
      this.FineAmount + "', '" +
      this.DateFineImposed + "', '" +
      this.Status + "', '" +
      this.DateStatusUpdated + "')";
      int returnCode = modifyDatabase(insertQuery);
      if (returnCode != 0)
      {
        Console.WriteLine("Error in inserting Fine object into database");
      }
      else
      {
        Console.WriteLine("Fine object successfully inserted");
        string idQueryString = "SELECT MAX(ID) FROM Fine";
        List<Object> results = getValues(idQueryString);
        if (results != null)
        {
          // DEBUG Console.WriteLine("Got an id from id query");
          foreach (object result in results)
          {
            IEnumerable<Object> row = result as IEnumerable<Object>;
            foreach (object rowValue in row)
            {
              // DEBUG Console.WriteLine("Retrieved id = " + rowValue);
              this.ID = Convert.ToInt32(rowValue);
            }
          }
        }
      }
    }

    public void update()
    {
      string updateQuery = "UPDATE Fine SET " +
          " BannerID = '" + this.BannerID + "' ," +
          " FineAmount = '" + this.FineAmount + "' ," +
          " DateFineImposed = '" + this.DateFineImposed + "' ," +
          " Status = '" + this.Status + "' ," +
          " DateStatusUpdated = '" + this.DateStatusUpdated + "' " +
          " WHERE " +
          " ID = " + this.ID;
      Console.WriteLine(updateQuery);
      int returnCode = modifyDatabase(updateQuery);
      if (returnCode != 0)
        Console.WriteLine("Error in updating Fine object into database");
      else
        Console.WriteLine("Fine object successfully updated");
    }

    public void delete()
    {
      string deleteQuery = "DELETE FROM Fine WHERE " +
          " ID = " + this.ID;
      Console.WriteLine(deleteQuery);
      int returnCode = modifyDatabase(deleteQuery);
      if (returnCode != 0)
        Console.WriteLine("Error in deleting Fine object from database");
      else
        Console.WriteLine("Fine object successfully deleted");
    }

    public string getBannerId()
    {
      return this.BannerID;
    }

    public string getFineAmount()
    {
      return this.FineAmount;
    }

    public string getDateFineImposed()
    {
      return this.DateFineImposed;
    }

    public string getStatus()
    {
      return this.Status;
    }

    public string getDateStatusUpdated()
    {
      return this.DateStatusUpdated;
    }

    public void setBannerId(string bannerId)
    {
      this.BannerID = bannerId;
    }

    public void setFineAmount(string fineAmount)
    {
      this.FineAmount = fineAmount;
    }

    public void setDateFineImposed(string dateFineImposed)
    {
      this.DateFineImposed = dateFineImposed;
    }

    public void setStatus(string status)
    {
      this.Status = status;
    }

    public void setDateStatusUpdated(string dateStatusUpdated)
    {
      this.DateStatusUpdated = dateStatusUpdated;
    }

  }
}
