using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRentalCLI
{
  class Program
  {
    static void Main(string[] args)
    {

      RentalCollection rc = new RentalCollection();
      rc.populateWithRentedOutBikes();
      Console.WriteLine("number of good bikes: " + rc.rentalsOut.Count);

      


                    //test user class
                    User user1 = new User();
                    user1.populate(1);
                    //test user popluate
                    Console.WriteLine("Test user populate: \n" + "ID " + user1.getBannerId() + " User " + user1.getFirstName() + " " +user1.getLastName ());
                    user1.setFirstName("Van");
                    user1.update();
                    user1.setBannerId("800999991");
                    user1.insert();

                    //user1.delete();
            

            Vehicle v1 = new Vehicle();
            v1.populate(1);
            v1.insert();
            v1.setBikeMake("MakeChange");
            v1.update();
            v1.delete();

                Worker w1 = new Worker();
                w1.populate(3);
                w1.setBannerId("8000111119");
                w1.insert();
                w1.setFirstName("Billy");
                w1.update();
                w1.delete();

                        User user3 = new User();
                        user3.populate(5);

                        Fine f1 = new Fine();
                        f1.setDateFineImposed(DateTime.Now.ToString("yyyy-MM-dd"));
                        f1.setBannerId(user3.getBannerId());
                        f1.populate(2);
                        f1.setFineAmount("100");
                        f1.insert();

                        f1.setFineAmount("200");
                        f1.update();
                      f1.delete();

            
            Rental r1 = new Rental();
            r1.populate(1);
            Console.WriteLine("Test Rental populate: \n" + "VID " + r1.getVehicleID() + " Renter " + r1.getRenterID());
            r1.insert();
            r1.setCheckinWorkerId(1);
           r1.update();

            
            Console.ReadKey();
            
    }
  }
}
