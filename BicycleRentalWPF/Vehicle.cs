using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRentalWPF
{
  class Vehicle : Persistable
  {
    private int ID { get; set; }
    private string BikeMake { get; set; }
    private string ModelNumber { get; set; }
    private string SerialNumber { get; set; }
    private string Color { get; set; }
    private string Description { get; set; }
    private string Location { get; set; }
    private string PhysicalCondition { get; set; }
    private string Notes { get; set; }
    private string Status { get; set; }
    private string DateStatusUpdated { get; set; }

    public Vehicle()
      : base() // call parent default constructor
    {
      connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
          @"Data source=..\BicycleRental.accdb";

    }

    //------------------------------------------------------------------
    public Vehicle(string bikeMake, string modelNumber, string serialNumber, string color, string description, string location, string physicalCondition, string notes, string status, string dateStatusUpdated)
      : base()
    {
      connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
          @"Data source=..\BicycleRental.accdb";

      this.BikeMake = bikeMake;
      this.ModelNumber = modelNumber;
      this.SerialNumber = serialNumber;
      this.Color = color;
      this.Description = description;
      this.Location = location;
      this.PhysicalCondition = physicalCondition;
      this.Notes = notes;
      this.Status = status;
      this.DateStatusUpdated = dateStatusUpdated;

    }

    //------------------------------------------------------------------
    public void populate(int Id)
    {
      string queryString = "SELECT * FROM Vehicle WHERE (ID = " + Id + ")";
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
              BikeMake = Convert.ToString(rowValue);
            else if (count == 2)
              ModelNumber = Convert.ToString(rowValue);
            else if (count == 3)
              SerialNumber = Convert.ToString(rowValue);
            else if (count == 4)
              Color = Convert.ToString(rowValue);
            else if (count == 5)
              Description = Convert.ToString(rowValue);
            else if (count == 6)
              Location = Convert.ToString(rowValue);
            else if (count == 7)
              PhysicalCondition = Convert.ToString(rowValue);
            else if (count == 8)
              Notes = Convert.ToString(rowValue);
            else if (count == 9)
              Status = Convert.ToString(rowValue);
            else if (count == 10)
              DateStatusUpdated = Convert.ToString(rowValue);
            count = count + 1;
          }
        }
      }
    }

    public void insert()
    {

      string insertQuery =
      "INSERT INTO Vehicle (BikeMake, ModelNumber, SerialNumber, Color, Description, Location, PhysicalCondition, Notes, Status, DateStatusUpdated) " +
      "VALUES (" +
      "'" + this.BikeMake + "', '" +
      this.ModelNumber + "', '" +
      this.SerialNumber + "', '" +
      this.Color + "', '" +
      this.Description + "', '" +
      this.Location + "', '" +
      this.PhysicalCondition + "', '" +
      this.Notes + "', '" +
      this.Status + "', '" +
      this.DateStatusUpdated + "')";
      int returnCode = modifyDatabase(insertQuery);
      if (returnCode != 0)
      {
        Console.WriteLine("Error in inserting Vehicle object into database");
      }
      else
      {
        Console.WriteLine("Vehicle object successfully inserted");
        string idQueryString = "SELECT MAX(ID) FROM Vehicle";
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
      DateStatusUpdated = DateTime.Now.ToString("yyyy-MM-dd");
      string updateQuery = "UPDATE Vehicle SET " +
          " BikeMake = '" + this.BikeMake + "' ," +
          " ModelNumber = '" + this.ModelNumber + "' ," +
          " SerialNumber = '" + this.SerialNumber + "' ," +
          " Color = '" + this.Color + "' ," +
          " Description = '" + this.Description + "', " +
          " PhysicalCondition = '" + this.PhysicalCondition + "', " +
          " Notes = '" + this.Notes + "', " +
          " Status = '" + this.Status + "', " +
          " DateStatusUpdated = '" + this.DateStatusUpdated + "' " +
          " WHERE " +
          " ID = " + this.ID;
      Console.WriteLine(updateQuery);
      int returnCode = modifyDatabase(updateQuery);
      if (returnCode != 0)
        Console.WriteLine("Error in updating Vehicle object into database");
      else
        Console.WriteLine("Vehicle object successfully updated");
    }

    public void delete()
    {
      string deleteQuery = "DELETE FROM Vehicle WHERE " +
          " ID = " + this.ID;
      Console.WriteLine(deleteQuery);
      int returnCode = modifyDatabase(deleteQuery);
      if (returnCode != 0)
        Console.WriteLine("Error in deleting Vehicle object from database");
      else
        Console.WriteLine("Vehicle object successfully deleted");
    }

    public string getBikeMake()
    {
      return this.BikeMake;
    }

    public string getModelNumber()
    {
      return this.ModelNumber;
    }

    public string getSerialNumber()
    {
      return this.SerialNumber;
    }

    public string getColor()
    {
      return this.Color;
    }

    public string getDescription()
    {
      return this.Description;
    }

    public string getLocation()
    {
      return this.Location;
    }

    public string getPhysicalCondition()
    {
      return this.PhysicalCondition;
    }

    public string getNotes()
    {
      return this.Notes;
    }

    public string getStatus()
    {
      return this.Status;
    }

    public string getDateStatusUpdated()
    {
      return this.DateStatusUpdated;
    }

    public void setBikeMake(string bikeMake)
    {
      this.BikeMake = bikeMake;
    }

    public void setModelNumber(string modelNumber)
    {
      this.ModelNumber = modelNumber;
    }

    public void setSerialNumber(string serialNumber)
    {
      this.SerialNumber = serialNumber;
    }

    public void setColor(string color)
    {
      this.Color = color;
    }

    public void setDescription(string description)
    {
      this.Description = description;
    }

    public void setLocation(string location)
    {
      this.Location = location;
    }

    public void setPhysicalCondition(string physicalCondition)
    {
      this.PhysicalCondition = physicalCondition;
    }

    public void setNotes(string notes)
    {
      this.Notes = notes;
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
