using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*********
 * Evan Lewis
 * Van Le
 ********/

namespace BicycleRentalWPF
{

    public class VehicleCollection : Persistable
    {
        public List<Vehicle> bikes = new List<Vehicle>();

      public VehicleCollection()
            : base()
        {
          connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
        @"Data source=..\BicycleRental.accdb";
        }

        public void populateWithGoodAndAvailableBikes()
        {
            string queryString = "SELECT ID FROM Vehicle WHERE (PhysicalCondition = 'Good' AND Status = 'Available')";
            List<Object> results = getValues(queryString);
            if (results != null)
            {
                foreach (object result in results)
                {
                    IEnumerable<Object> row = result as IEnumerable<Object>;
                    
                    int vId = Convert.ToInt32(row.ElementAt(0));
                    Vehicle aVehicle = new Vehicle();
                    aVehicle.populate(vId);
                    bikes.Add(aVehicle);
                }
            }
        }

        public Object [] getBikeIDs()
        {
            Object [] bikeIDs= new Object[bikes.Count()];
            int count = 0;
            foreach(Vehicle v in bikes)
            {
                int vID = v.ID;
                bikeIDs[count] = vID;
                count++;
            }
            return bikeIDs;
        }

      public override String ToString()
        {
            String valToReturn = "";
            for (int cnt = 0; cnt < bikes.Count; cnt++)
            {
                valToReturn += bikes.ElementAt(cnt).ID + " ";
            }
            return valToReturn;
        }

    }
}
            
        

