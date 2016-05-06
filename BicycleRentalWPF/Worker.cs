using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRentalWPF
{
  public class Worker : Persistable
  {
    private int ID { get; set; }
    private string BannerID { get; set; }
    private string FirstName { get; set; }
    private string LastName { get; set; }
    private string PhoneNumber { get; set; }
    private string EmailAddress { get; set; }
    private string Credential { get; set; }
    private string InitialRegistrationDate { get; set; }
    private string Notes { get; set; }
    private string Status { get; set; }
    private string DateStatusUpdated { get; set; }

    public Worker()
      : base() // call parent default constructor
    {
      connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
          @"Data source=..\BicycleRental.accdb";
    }
    //------------------------------------------------------------------
    public Worker(string bannerId, string firstName, string lastName, string phoneNumber, string emailAddress, string credential, string dateOfInitialRegistration, string notes, string status, string dateStatusUpdated)
      : base()
    {
      connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
          @"Data source=..\BicycleRental.accdb";

      this.BannerID = bannerId;
      this.FirstName = firstName;
      this.LastName = lastName;
      this.PhoneNumber = phoneNumber;
      this.EmailAddress = emailAddress;
      this.Credential = credential;
      this.InitialRegistrationDate = dateOfInitialRegistration;
      this.Notes = notes;
      this.Status = status;
      this.DateStatusUpdated = dateStatusUpdated;

    }

    //------------------------------------------------------------------
    public void populate(int Id)
    {
      string queryString = "SELECT * FROM Worker WHERE (ID = " + Id + ")";
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
              FirstName = Convert.ToString(rowValue);
            else if (count == 3)
              LastName = Convert.ToString(rowValue);
            else if (count == 4)
              PhoneNumber = Convert.ToString(rowValue);
            else if (count == 5)
              EmailAddress = Convert.ToString(rowValue);
            else if (count == 6)
              Credential = Convert.ToString(rowValue);
            else if (count == 7)
              InitialRegistrationDate = Convert.ToString(rowValue);
            else if (count == 9)
              Notes = Convert.ToString(rowValue);
            else if (count == 10)
              Status = Convert.ToString(rowValue);
            else if (count == 11)
              DateStatusUpdated = Convert.ToString(rowValue);
            count = count + 1;
          }
        }
      }
    }

    public void populateBannerId(string bannerId)
    {
      string queryString = "SELECT * FROM Worker WHERE (BannerId = '" + bannerId + "')";
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
              FirstName = Convert.ToString(rowValue);
            else if (count == 3)
              LastName = Convert.ToString(rowValue);
            else if (count == 4)
              PhoneNumber = Convert.ToString(rowValue);
            else if (count == 5)
              EmailAddress = Convert.ToString(rowValue);
            else if (count == 6)
              Credential = Convert.ToString(rowValue);
            else if (count == 7)
              InitialRegistrationDate = Convert.ToString(rowValue);
            else if (count == 9)
              Notes = Convert.ToString(rowValue);
            else if (count == 10)
              Status = Convert.ToString(rowValue);
            else if (count == 11)
              DateStatusUpdated = Convert.ToString(rowValue);
            count = count + 1;
          }
        }
      }
    }

    public void insert()
    {

      InitialRegistrationDate = DateTime.Now.ToString("yyyy-MM-dd");
      string insertQuery =
      "INSERT INTO [Worker] (BannerID, FirstName, LastName, PhoneNumber, EmailAddress, Credential, InitialRegistrationDate, Notes, Status, DateStatusUpdated) " +
      "VALUES (" +
      "'" + this.BannerID + "', '" +
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
              this.ID = Convert.ToInt32(rowValue);
            }
          }
        }
      }
    }

    public void update()
    {
      DateStatusUpdated = DateTime.Now.ToString("yyyy-MM-dd");
      string updateQuery = "UPDATE Worker SET " +
    " BannerId = '" + this.BannerID + "' ," +
    " FirstName = '" + this.FirstName + "' ," +
    " LastName = '" + this.LastName + "' ," +
    " PhoneNumber = '" + this.PhoneNumber + "' ," +
    " EmailAddress = '" + this.EmailAddress + "', " +
    " Credential = '" + this.Credential + "', " +
    " InitialRegistrationDate = '" + this.InitialRegistrationDate + "', " +
    " Notes = '" + this.Notes + "', " +
    " Status = '" + this.Status + "', " +
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
      return this.BannerID;
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
      this.BannerID = bannerId;
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
