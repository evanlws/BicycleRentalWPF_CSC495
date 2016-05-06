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
    public partial class ReturnBicycleForm : Form
    {
        Form myCaller;
        Object[] bikeIDs;
        Worker currentWorker;

        public ReturnBicycleForm(Form m, Worker w)
        {
            InitializeComponent();
            myCaller = m;
            RentalCollection rc = new RentalCollection();
            rc.populateWithRentedOutBikes();
            bikeIDs = rc.getBikeIDs();
            ChooseBicycleComboBox.Items.AddRange(bikeIDs);
            currentWorker = w;
        }


        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Rental r1 = new Rental();
            int vehicleID = Convert.ToInt32(ChooseBicycleComboBox.SelectedItem);
            r1.populateWithNonReturnedRental(vehicleID);
            r1.DateReturned = DateTime.Now.ToString("yyyy-MM-dd");
            r1.TimeReturned = DateTime.Now.ToString("hh:mm:ss");
            r1.CheckinWorkerID = currentWorker.ID;
            r1.update();

            Vehicle v = new Vehicle();
            v.populate(vehicleID);
            v.Status = "Available";
            v.update();

            System.Windows.Forms.MessageBox.Show("Return successful!");

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
