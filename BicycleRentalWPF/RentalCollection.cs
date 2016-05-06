using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRentalWPF
{

    public class RentalCollection : Persistable
    {
        private List<Rental> rentalsOut = new List<Rental>();
        
        public RentalCollection() : base()
        {
          connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
        @"Data source=..\BicycleRental.accdb";
        }

        public void populateWithRentedOutBikes()
        {
            string queryString = "SELECT ID FROM Rental WHERE (CheckinWorkerId = 0)";
            List<Object> results = getValues(queryString);
            if (results != null)
            {
                foreach (object result in results)
                {
                    IEnumerable<Object> row = result as IEnumerable<Object>;
                    int count = 0;
                    foreach (object rowValue in row)
                    {
                        if (count == 0)
                        {
                            int rId = Convert.ToInt32(rowValue);
                            Rental aRental = new Rental();
                            aRental.populate(rId);
                            rentalsOut.Add(aRental);
                        }
                       
                    }
                }
            }
        }

        public Object[] getBikeIDs()
        {
            Object[] bikeIDs = new Object[rentalsOut.Count()];
            int count = 0;
            foreach (Rental r in rentalsOut)
            {
                int vID = r.VehicleID;
                bikeIDs[count] = vID;
                count++;
            }
            return bikeIDs;
        }

      public override String ToString()
        {
            String valToReturn = "";
            for (int cnt = 0; cnt < rentalsOut.Count; cnt++)
            {
                valToReturn += rentalsOut.ElementAt(cnt).ID + " ";
            }
            return valToReturn;
        }

    }
    
}



