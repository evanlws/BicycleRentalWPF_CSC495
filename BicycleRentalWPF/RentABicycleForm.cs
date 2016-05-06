using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleRentalWPF
{
    public partial class RentABicycleForm : Form
    {
        Form myCaller;
        String bannerID;
        Object [] bikeIDs;
        Worker currentWorker;

        public RentABicycleForm(Form m, Worker w)
        {
            InitializeComponent();
            myCaller = m;
              VehicleCollection vc = new VehicleCollection();
            vc.populateWithGoodAndAvailableBikes();
            bikeIDs = vc.getBikeIDs();
            ChooseBicycleComboBox.Items.AddRange(bikeIDs);
            currentWorker = w;
   
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            User existingUser = new User();
            existingUser.populateWithBannerID(BannerIDBox.Text);

            
            int renterID = existingUser.ID;
            int vehicleID = Convert.ToInt32(ChooseBicycleComboBox.SelectedItem);
            DateTime dt = DateTime.Now;
            DateTime dtDue = dt.AddDays(3);
            String dateRented = dt.Year + "-" + dt.Month + "-" + dt.Day;
            String timeRented = dt.Hour + ":" + dt.Minute + ":" + dt.Second;
            String dateDue = dtDue.Year + "-" + dtDue.Month + "-" + dtDue.Day;
            String timeDue = timeRented;
            String dateReturned = null;
            String timeReturned = null;
            int checkoutWorkerID = currentWorker.ID;
            int checkinWorkerID = 0;
            Rental r1 = new Rental(vehicleID, renterID, dateRented, timeRented,
             dateDue, timeDue, dateReturned, timeReturned,
                checkoutWorkerID, checkinWorkerID);

            Vehicle v = new Vehicle();
            v.populate(vehicleID);
            v.Status = "Unavailable";
            v.update();

            r1.insert();

            System.Windows.Forms.MessageBox.Show("Rental successful!");

            this.Hide();
            myCaller.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            myCaller.Show();
        }
   
    }
}
