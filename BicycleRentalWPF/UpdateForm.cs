using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*********
 * Evan Lewis
 * Van Le
 ********/

namespace BicycleRentalWPF
{
    public partial class UpdateForm : Form
    {
        MainMenu myCaller;
        string dataToModify;

        public UpdateForm(MainMenu m, string s)
        {
            
            InitializeComponent();
            if (s.Equals("modifyUser"))
            {
                ObjectIdLabel.Text = "Enter BannerID of the user";
            }
            if (s.Equals("modifyWorker"))
            {
                ObjectIdLabel.Text = "Enter BannerID of the Worker";
            }
            if (s.Equals("modifyBicycle"))
            {
                ObjectIdLabel.Text = "Enter BycycleID of the Bike";
            }
            myCaller = m;
            dataToModify = s;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (dataToModify.Equals("modifyUser"))
            {
                string id = IDBox.Text;
                this.Hide();
                UserDataInputForm udif = new UserDataInputForm(this, id, myCaller);
                udif.Show();
            }
            if (dataToModify.Equals("modifyWorker"))
            {
                string id = IDBox.Text;
                this.Hide();
                WorkerDataInputForm wdif = new WorkerDataInputForm(this, id, myCaller);
                wdif.Show();
            }
            if(dataToModify.Equals("modifyBicycle"))
            {
                int id = Convert.ToInt32(IDBox.Text);
                this.Hide();
                BicycleDataInputForm bdif = new BicycleDataInputForm(this, id, myCaller);
                bdif.Show();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            myCaller.Show();
        }

    }
}
