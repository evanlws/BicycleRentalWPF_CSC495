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
    public partial class DeleteForm : Form
    {
        MainMenuForm1 myCaller;
        string dataToDelete;

        public DeleteForm(MainMenuForm1 m, string s)
        {
            InitializeComponent();
            if (s.Equals("deleteUser"))
            {
                FormTitle.Text = "Enter BannerID of User to delete";
            }
            else if (s.Equals("deleteWorker"))
            {
                FormTitle.Text = "Enter BannerID of Worker to delete";
            }
            else if (s.Equals("deleteBicycle"))
            {
                FormTitle.Text = "Enter BicycleID of Bike to delete";
            }
            myCaller = m;
            dataToDelete = s;
        }


        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (dataToDelete.Equals("deleteUser"))
            {
                string id = IDBox.Text;
                this.Hide();
                UserDataInputForm udif = new UserDataInputForm(this, id, myCaller);
                udif.Show();
            }
            else if (dataToDelete.Equals("deleteWorker"))
            {
                string id = IDBox.Text;
                this.Hide();
                WorkerDataInputForm wdif = new WorkerDataInputForm(this, id, myCaller);
                wdif.Show();
            }
            else if (dataToDelete.Equals("deleteBicycle"))
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
