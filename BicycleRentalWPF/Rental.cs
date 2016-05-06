using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BicycleRentalWPF
{

    public class Rental : Persistable
    {
        public int ID { get; set; }
        public int VehicleID { get; set; }
        public int RenterID { get; set; }
        public string DateRented { get; set; }
        public string TimeRented { get; set; }
        public string DateDue { get; set; }
        public string TimeDue { get; set; }
        public string DateReturned { get; set; }
        public string TimeReturned { get; set; }
        public int CheckoutWorkerID { get; set; }
        public int CheckinWorkerID { get; set; }

        public Rental()
            : base()
        {
          connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
        @"Data source=..\BicycleRental.accdb";
        }

      public Rental(int vehicleID, int renterID, string dateRented, string timeRented, string dateDue, string timeDue,
             string dateReturned, string timeReturned,
                int checkoutWorkerID, int checkinWorkerID)
            : base()
        {
          connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
        @"Data source=..\BicycleRental.accdb";
            this.VehicleID = vehicleID;
            this.RenterID = renterID;
            this.DateRented = dateRented;
            this.TimeRented = timeRented;
            this.DateDue = dateDue;
            this.TimeDue = timeDue;
            this.DateReturned = dateReturned;
            this.TimeReturned = timeReturned;
            this.CheckoutWorkerID = checkoutWorkerID;
            this.CheckinWorkerID = checkinWorkerID;

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
                            this.VehicleID = Convert.ToInt32(rowValue);
                        else if (count == 2)
                            this.RenterID = Convert.ToInt32(rowValue);
                        else if (count == 3)
                            this.DateRented = Convert.ToString(rowValue);
                        else if (count == 4)
                            this.TimeRented = Convert.ToString(rowValue);
                        else if (count == 5)
                            this.DateDue = Convert.ToString(rowValue);
                        else if (count == 6)
                            this.TimeDue = Convert.ToString(rowValue);
                        else if (count == 7)
                            this.DateReturned = Convert.ToString(rowValue);
                        else if (count == 8)
                            this.TimeReturned = Convert.ToString(rowValue);
                        else if (count == 9)
                            this.CheckoutWorkerID = Convert.ToInt32(rowValue);
                        else if (count == 10)
                            this.CheckinWorkerID = Convert.ToInt32(rowValue);
                        count = count + 1;
                    }
                }
            }
        }

        public void populate(int ID)
        {
            string queryString = "SELECT * FROM Rental WHERE (ID = " + ID + ")";
            List<Object> results = getValues(queryString);
            populateHelper(results);
        }

        public void populateWithNonReturnedRental(int bikeID)
        {
            string queryString = "SELECT * FROM Rental WHERE (VehicleID = " + bikeID + ") AND (CheckinWorkerID = 0)";
            List<Object> results = getValues(queryString);
            populateHelper(results);
        }

        public void insert()
        {
            string insertQuery =
            "INSERT INTO Rental(VehicleID, RenterID, DateRented, TimeRented, DateDue, TimeDue, DateReturned, TimeReturned, CheckoutWorkerID, CheckinWorkerID) " +
            "VALUES (" +
            "'" + this.VehicleID + "', '" +
            this.RenterID + "', '" +
            this.DateRented + "', '" +
            this.TimeRented + "', '" +
            this.DateDue + "', '" +
            this.TimeDue + "', '" +
            this.DateReturned + "', '" +
            this.TimeReturned + "', '" +
            this.CheckoutWorkerID + "', '" +
            this.CheckinWorkerID + "')";

            int returnCode = modifyDatabase(insertQuery);
            if (returnCode != 0)
            {
                Console.WriteLine("Error in inserting Rental object into database");
            }
            else
            {
                Console.WriteLine("Rental object successfully inserted");
                string idQueryString = "SELECT MAX(ID) FROM Rental";
                List<Object> results = getValues(idQueryString);
                if (results != null)
                {
                    foreach (object result in results)
                    {
                        IEnumerable row = result as IEnumerable;
                        foreach (object rowValue in row)
                        {
                            this.ID = Convert.ToInt32(rowValue);
                        }
                    }
                }
            }
        }

        public void update()
        {
            string updateQuery = "UPDATE Rental SET " +
                " VehicleID = " + this.VehicleID + " ," +
                " RenterID = " + this.RenterID + " ," +
                " DateRented ='" + this.DateRented + "' , " +
                " TimeRented = '" + this.TimeRented + "' ," +
                " DateDue = '" + this.DateDue + "' ," +
                " TimeDue = '" + this.TimeDue + "' ," +
                " DateReturned = '" + this.DateReturned + "' ," +
                " TimeReturned = '" + this.TimeReturned + "' ," +
                " CheckoutWorkerID = " + this.CheckoutWorkerID + " ," +
                " CheckinWorkerID= " + this.CheckinWorkerID  + " " +
                " WHERE " +
                " ID = " + this.ID;
            Console.WriteLine(updateQuery);
            int returnCode = modifyDatabase(updateQuery);
            if (returnCode != 0)
                Console.WriteLine("Error in updating Rental object into database");
            else
                Console.WriteLine("Rental object successfully updated");
        }

        public void delete()
        {
            string deleteQuery = "DELETE FROM Rental WHERE " +
                " ID = " + this.ID;
            Console.WriteLine(deleteQuery);
            int returnCode = modifyDatabase(deleteQuery);
            if (returnCode != 0)
                Console.WriteLine("Error in deleting Rental object from database");
            else
                Console.WriteLine("Rental object successfully deleted");
        }
    }

}
