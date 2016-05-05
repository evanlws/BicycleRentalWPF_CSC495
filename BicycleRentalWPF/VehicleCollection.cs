using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRentalWPF
{
  class VehicleCollection : Persistable
  {
    public List<Vehicle> bikes;

    public VehicleCollection()
      : base() // call parent default constructor
    {
      connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
          @"Data source=..\BicycleRental.accdb";
    }

    public void populateWithGoodAndAvailableBikes()
    {

      bikes = new List<Vehicle>();

      string queryString = "SELECT ID FROM Vehicle WHERE PhysicalCondition = 'Good' AND Status = 'Available'";
      List<Object> results = getValues(queryString);
      if (results != null)
      {
        foreach (object result in results)
        {
          IEnumerable<Object> row = result as IEnumerable<Object>;

          foreach (object rowValue in row)
          {
            Vehicle vehicle = new Vehicle();
            vehicle.populate(Convert.ToInt32(rowValue));
            bikes.Add(vehicle);
          }
        }
      }
    }

  }
}
