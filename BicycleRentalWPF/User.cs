using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRentalCLI
{
  class User : Persistable
  {
    private int ID
    {
      get;
      set;
    }
    private string BannerId
    {
      get;
      set;
    }
    private string FirstName
    {
      get;
      set;
    }
    private string LastName
    {
      get;
      set;
    }
    private string PhoneNumber
    {
      get;
      set;
    }
    private string EmailAddress
    {
      get;
      set;
    }
    private string UserType
    {
      get;
      set;
    }
    private string Notes
    {
      get;
      set;
    }
    private string Status
    {
      get;
      set;
    }
    private string DateStatusUpdated
    {
      get;
      set;
    }

    public User()
      : base() // call parent default constructor
    {
      connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
    @"Data source=..\BicycleRental.accdb";
    }
    //------------------------------------------------------------------
    public User(string bannerId, string firstName, string lastName,
       string phoneNumber, string emailAddress, string userType, string notes, string status, string dateStatusUpdated)
      : base()
    {
      connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
    @"Data source=..\BicycleRental.accdb";

      this.BannerId = bannerId;
      this.FirstName = firstName;
      this.LastName = lastName;
      this.PhoneNumber = phoneNumber;
      this.EmailAddress = emailAddress;
      this.UserType = userType;
      this.Notes = notes;
      this.Status = status;
      this.DateStatusUpdated = dateStatusUpdated;

    }
    //------------------------------------------------------------------
    public void populate(int Id)
    {
      string queryString = "SELECT * FROM [User] WHERE (ID = " + Id + ")";
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
              BannerId = Convert.ToString(rowValue);
            else if (count == 2)
              FirstName = Convert.ToString(rowValue);
            else if (count == 3)
              LastName = Convert.ToString(rowValue);
            else if (count == 4)
              PhoneNumber = Convert.ToString(rowValue);
            else if (count == 5)
              EmailAddress = Convert.ToString(rowValue);
            else if (count == 6)
              UserType = Convert.ToString(rowValue);
            else if (count == 7)
              Notes = Convert.ToString(rowValue);
            else if (count == 8)
              Status = Convert.ToString(rowValue);
            else if (count == 9)
              DateStatusUpdated = Convert.ToString(rowValue);
            count = count + 1;
          }
        }
      }
    }

    public void insert()
    {

      string insertQuery =
      "INSERT INTO [User] (BannerId, FirstName, LastName, PhoneNumber, EmailAddress, UserType, Notes, Status) " +
      "VALUES (" +
      "'" + this.BannerId + "', '" +
      this.FirstName + "', '" +
      this.LastName + "', '" +
      this.PhoneNumber + "', '" +
      this.EmailAddress + "', '" +
      this.UserType + "', '" +
      this.Notes + "', '" +
      this.Status + "')";
      int returnCode = modifyDatabase(insertQuery);
      if (returnCode != 0)
      {
        Console.WriteLine("Error in inserting User object into database");
      }
      else
      {
        Console.WriteLine("User object successfully inserted");
        string idQueryString = "SELECT MAX(BannerID) FROM [User]";
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

    public void update()
    {
      DateStatusUpdated = DateTime.Now.ToString("yyyy-MM-dd");
      string updateQuery = "UPDATE [User] SET " +
          " BannerId = '" + this.BannerId + "' ," +
          " FirstName = '" + this.FirstName + "' ," +
          " LastName = '" + this.LastName + "' ," +
          " PhoneNumber = '" + this.PhoneNumber + "' ," +
          " EmailAddress = '" + this.EmailAddress + "' ," +
          " UserType = '" + this.UserType + "', " +
          " Notes = '" + this.Notes + "', " +
          " Status = '" + this.Status + "', " +
          " DateStatusUpdated = '" + this.DateStatusUpdated + "'" +
          " WHERE " +
          " ID = " + this.ID;
      Console.WriteLine(updateQuery);
      int returnCode = modifyDatabase(updateQuery);
      if (returnCode != 0)
        Console.WriteLine("Error in updating User object into database");
      else
        Console.WriteLine("User object successfully updated");
    }

    public void delete()
    {
      string deleteQuery = "DELETE FROM [User] WHERE " +
          " ID = " + this.ID;
      Console.WriteLine(deleteQuery);
      int returnCode = modifyDatabase(deleteQuery);
      if (returnCode != 0)
        Console.WriteLine("Error in deleting User object from database");
      else
        Console.WriteLine("User object successfully deleted");
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

    public string getPhoneNumber()
    {
      return this.PhoneNumber;
    }

    public string getEmailAddress()
    {
      return this.EmailAddress;
    }

    public string getUserType()
    {
      return this.UserType;
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

    public void setPhoneNumber(string address)
    {
      this.PhoneNumber = address;
    }

    public void setEmailAddress(string city)
    {
      this.EmailAddress = city;
    }

    public void setUserType(string state)
    {
      this.UserType = state;
    }

    public void setNotes(string dob)
    {
      this.Notes = dob;
    }

    public void setDateStatusUpdated(string dateStatusUpdated)
    {
      this.DateStatusUpdated = dateStatusUpdated;
    }
  }
}
