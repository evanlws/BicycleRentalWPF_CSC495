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
    public partial class UpdateForm : Form
    {
        MainMenuForm1 myCaller;
        string dataToModify;

        public UpdateForm(MainMenuForm1 m, string s)
        {
            
            InitializeComponent();
            if (s.Equals("modifyUser"))
            {
                Julianne.Text = "Enter BannerID of the user";
            }
            if (s.Equals("modifyWorker"))
            {
                Julianne.Text = "Enter BannerID of the Worker";
            }
            if (s.Equals("modifyBicycle"))
            {
                Julianne.Text = "Enter BycycleID of the Bike";
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
