using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BicycleRentalWPF
{

    public class Worker : Persistable
    {
        public int ID { get; set; }
        public string BannerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Credential { get; set; }
        public string DateOfInitialRegistration { get; set; }
        public string WorkerPassword { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
        public string DateStatusUpdated { get; set; }
    
        public Worker()
            : base()
        {
          connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
        @"Data source=..\BicycleRental.accdb";
        }

        public Worker(string bannerID, string firstName, string lastName, string phoneNumber,
            string emailAddress, string credentials, string workerPassword,
            string notes, string status)
            : base()
        {
          connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
        @"Data source=..\BicycleRental.accdb";
            this.BannerID = bannerID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.EmailAddress = emailAddress;
            this.Credential = credentials;
            this.DateOfInitialRegistration = DateTime.Now.ToString("yyyy-MM-dd");
            this.WorkerPassword = workerPassword;
            this.Notes = notes;
            this.Status = status;
            this.DateStatusUpdated = DateTime.Now.ToString("yyyy-MM-dd");

        }

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
                        if (count == 0)
                            this.ID = Convert.ToInt32(rowValue);
                        else if (count == 1)
                            this.BannerID = Convert.ToString(rowValue);
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
                            this.DateOfInitialRegistration = Convert.ToString(rowValue);
                        else if (count == 8)
                            this.WorkerPassword = Convert.ToString(rowValue);
                        else if (count == 9)
                            this.Notes = Convert.ToString(rowValue);
                        else if (count == 10)
                            this.Status = Convert.ToString(rowValue);
                        else if (count == 11)
                            this.DateStatusUpdated = Convert.ToString(rowValue);
                        count = count + 1;
                    }
                }
            }
        }

      public void populate(int ID)
        {
            string queryString = "SELECT * FROM Worker WHERE (ID = " + ID + ")";
            List<Object> results = getValues(queryString);
            populateHelper(results);
        }

      public void populateBannerID(string ID)
        {
            string queryString = "SELECT * FROM Worker WHERE (BannerID = '" + ID + "')";
            List<Object> results = getValues(queryString);
            populateHelper(results);
        }

        public void insert()
        {
            string insertQuery =
            "INSERT INTO Worker (BannerID, FirstName, LastName, PhoneNumber, EmailAddress, Credential, InitialRegistrationDate, WorkerPassword, Notes, Status, DateStatusUpdated) " +
            "VALUES (" +
            "'" + this.BannerID + "', '" +
            this.FirstName + "', '" +
            this.LastName + "', '" +
            this.PhoneNumber + "', '" +
            this.EmailAddress + "', '" +
            this.Credential + "', '" +
            this.DateOfInitialRegistration + "', '" +
            this.WorkerPassword + "', '" +
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
                    foreach (object result in results)
                    {
                        IEnumerable row = result as IEnumerable;
                        foreach (object rowValue in row)
                        {
                            this.BannerID = Convert.ToString(rowValue);
                        }
                    }
                }
            }
        }

        public void update()
        {
            string updateQuery = "UPDATE Worker SET " +
                " BannerID = '" + this.BannerID + "' ," +
                " FirstName = '" + this.FirstName + "' ," +
                " LastName = '" + this.LastName + "' , " +
                " PhoneNumber = '" + this.PhoneNumber + "' ," +
                " EmailAddress = '" + this.EmailAddress + "' ," +
                " Credential = '" + this.Credential + "' ," +
                " InitialRegistrationDate = '" + this.DateOfInitialRegistration + "' ," +
                " WorkerPassword = '" + this.WorkerPassword + "' ," +
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

    
    }
}
