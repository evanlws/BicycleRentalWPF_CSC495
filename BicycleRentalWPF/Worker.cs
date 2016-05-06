using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRentalWPF
{
  public class Worker : Persistable
  {
    public int ID { get; set; }
    public string BannerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string EmailAddress { get; set; }
    public string Credential { get; set; }
    public string InitialRegistrationDate { get; set; }
    public string Notes { get; set; }
    public string Status { get; set; }
    public string DateStatusUpdated { get; set; }

    //constructor 
    public Worker()
      : base()
    {
      connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
          @"Data source=..\BicycleRental.accdb";
    }
    //constructor
    public Worker(string bannerID, string firstName, string lastName, string phoneNumber,
        string emailAddress, string credentials, string notes)
      : base()
    {
      connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
          @"Data source=..\BicycleRental.accdb";
      this.BannerId = bannerID;
      this.FirstName = firstName;
      this.LastName = lastName;
      this.PhoneNumber = phoneNumber;
      this.EmailAddress = emailAddress;
      this.Credential = credentials;
      this.InitialRegistrationDate = DateTime.Now.ToString("yyyy-MM-dd");
      this.Notes = notes;
      this.Status = "Active";
      this.DateStatusUpdated = DateTime.Now.ToString("yyyy-MM-dd");

    }

    //populate helper
    private void populateHelper(List<Object> results)
    {
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
              this.ID = Convert.ToInt32(rowValue);
            else if (count == 1)
              this.BannerId = Convert.ToString(rowValue);
            else if (count == 2)
              this.FirstName = Convert.ToString(rowValue);
            else if (count == 3)
              this.LastName = Convert.ToString(rowValue);
            else if (count == 4)
              this.PhoneNumber = Convert.ToString(rowValue);
            else if (count == 5)
              this.EmailAddress = Convert.ToString(rowValue);
            else if (count == 6)
              this.Credential = Convert.ToString(rowValue);
            else if (count == 7)
              this.InitialRegistrationDate = Convert.ToString(rowValue);
            else if (count == 8)
              this.Notes = Convert.ToString(rowValue);
            else if (count == 9)
              this.Status = Convert.ToString(rowValue);
            else if (count == 10)
              this.DateStatusUpdated = Convert.ToString(rowValue);
            count = count + 1;
          }
        }
      }
    }
    //populates worker object
    public void populate(int ID)
    {
      string queryString = "SELECT * FROM Worker WHERE (ID = " + ID + ")";
      List<Object> results = getValues(queryString);
      populateHelper(results);
    }
    //populate with bannerID
    public void populateBannerID(string ID)
    {
      string queryString = "SELECT * FROM Worker WHERE (BannerId = '" + ID + "')";
      List<Object> results = getValues(queryString);
      populateHelper(results);
    }

    //inserts worker into worker table
    public void insert()
    {
      string insertQuery =
      "INSERT INTO Worker (BannerId, FirstName, LastName, PhoneNumber, EmailAddress, Credential, InitialRegistrationDate, Notes, Status, DateStatusUpdated) " +
      "VALUES (" +
      "'" + this.BannerId + "', '" +
      this.FirstName + "', '" +
      this.LastName + "', '" +
      this.PhoneNumber + "', '" +
      this.EmailAddress + "', '" +
      this.Credential + "', '" +
      this.InitialRegistrationDate + "', '" +
      this.Notes + "', '" +
      this.Status + "', '" +
      this.DateStatusUpdated + "')";

      int returnCode = modifyDatabase(insertQuery);
      if (returnCode != 0)
      {
        Console.WriteLine("Error in inserting Worker object into database");
      }
      else
      {
        Console.WriteLine("Worker object successfully inserted");
        string idQueryString = "SELECT MAX(ID) FROM Worker";
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
              this.BannerId = Convert.ToString(rowValue);
            }
          }
        }
      }
    }

    //updates worker in Worker table
    public void update()
    {
      string updateQuery = "UPDATE Worker SET " +
          " BannerId = '" + this.BannerId + "' ," +
          " FirstName = '" + this.FirstName + "' ," +
          " LastName = '" + this.LastName + "' , " +
          " PhoneNumber = '" + this.PhoneNumber + "' ," +
          " EmailAddress = '" + this.EmailAddress + "' ," +
          " Credential = '" + this.Credential + "' ," +
          " InitialRegistrationDate = '" + this.InitialRegistrationDate + "' ," +
          " Notes = '" + this.Notes + "' ," +
          " Status = '" + this.Status + "' ," +
          " DateStatusUpdated = '" + this.DateStatusUpdated + "' " +
          " WHERE " +
          " ID = " + this.ID;
      Console.WriteLine(updateQuery);
      int returnCode = modifyDatabase(updateQuery);
      if (returnCode != 0)
        Console.WriteLine("Error in updating Worker object into database");
      else
        Console.WriteLine("Worker object successfully updated");
    }

    //Deletes worker from worker table
    public void delete()
    {
      string deleteQuery = "DELETE FROM Worker WHERE " +
          " ID = " + this.ID;
      Console.WriteLine(deleteQuery);
      int returnCode = modifyDatabase(deleteQuery);
      if (returnCode != 0)
        Console.WriteLine("Error in deleting Worker object from database");
      else
        Console.WriteLine("Worker object successfully deleted");
    }

    public string getBannerId()
    {
      return this.BannerId;
    }

    public string getFirstName()
    {
      return this.FirstName;
    }

    public string getLastName()
    {
      return this.LastName;
    }

    public string getPhoneNumnber()
    {
      return this.PhoneNumber;
    }

    public string getEmailAddress()
    {
      return this.EmailAddress;
    }

    public string getCredential()
    {
      return this.Credential;
    }

    public string getDateOfInitialRegistration()
    {
      return this.InitialRegistrationDate;
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

    public void setBannerId(string bannerId)
    {
      this.BannerId = bannerId;
    }

    public void setFirstName(string firstName)
    {
      this.FirstName = firstName;
    }

    public void setLastName(string lastName)
    {
      this.LastName = lastName;
    }

    public void setPhoneNumner(string phoneNumber)
    {
      this.PhoneNumber = phoneNumber;
    }

    public void setEmailAddress(string emailAddress)
    {
      this.EmailAddress = emailAddress;
    }

    public void setCredential(string credential)
    {
      this.Credential = credential;
    }

    public void setDateOfInitialRegistration(string dateOfInitialRegistration)
    {
      this.InitialRegistrationDate = dateOfInitialRegistration;
    }

    public void setNotes(string notes)
    {
      this.Notes = notes;
    }

    public void setStatus(string status)
    {
      this.Status = status;
    }

    public void dateStatusUpdated(string dateStatusUpdated)
    {
      this.DateStatusUpdated = dateStatusUpdated;
    }
  }
}
