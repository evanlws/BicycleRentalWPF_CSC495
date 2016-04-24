using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRentalCLI
{
  class RentalCollection : Persistable
  {
    public List<Rental> rentalsOut;

    public RentalCollection()
      : base() // call parent default constructor
    {
      connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
          @"Data source=..\BicycleRental.accdb";
    }

    public void populateWithRentedOutBikes()
    {

      rentalsOut = new List<Rental>();

      string queryString = "SELECT ID FROM Rental WHERE CheckOutWorkerID IS NOT NULL AND CheckInWorkerID = 0";
      List<Object> results = getValues(queryString);
      if (results != null)
      {
        foreach (object result in results)
        {
          IEnumerable<Object> row = result as IEnumerable<Object>;

          foreach (object rowValue in row)
          {
            Rental rental = new Rental();
            rental.populate(Convert.ToInt32(rowValue));
            rentalsOut.Add(rental);
          }
        }
      }
    }

  }
}
