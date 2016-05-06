using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Data.OleDb;
namespace BicycleRentalWPF
{
   
    public class DataValidation
    {
        DatabaseController dbc;
       

        public DataValidation()
        {
            dbc = new DatabaseController();

        }


        public  bool Login(List<string> dataInput)
        {

            dbc.checkBannerID(dataInput[0]);
            dbc.checkBannerID(dataInput[1]);
            return false;
        }


    }

   
    
}
