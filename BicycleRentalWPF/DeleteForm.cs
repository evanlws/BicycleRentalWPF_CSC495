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
        MainMenu myCaller;
        string stringToDelete;

        public DeleteForm(MainMenu mm, string s)
        {
            InitializeComponent();
            myCaller = mm;

            if (s.Equals("deleteUser"))
            {
                FormTitle.Text = "Enter BannerId of the User you wish to delete";
            }
            else if (s.Equals("deleteWorker"))
            {
                FormTitle.Text = "Enter BannerId of the Worker you wish to delete";
            }
            else if (s.Equals("deleteBicycle"))
            {
                FormTitle.Text = "Enter BicycleId of the Bike you wish to delete";
            }
            stringToDelete = s;
        }


        private void SubmitButton_Click(object sender, EventArgs e)
        {
          if (stringToDelete.Equals("deleteUser"))
            {
                string id = IdTextBox.Text;
                this.Hide();
                UserDataInputForm udif = new UserDataInputForm(this, id, myCaller);
                udif.Show();
            }
          else if (stringToDelete.Equals("deleteWorker"))
            {
                string id = IdTextBox.Text;
                this.Hide();
                WorkerDataInputForm wdif = new WorkerDataInputForm(this, id, myCaller);
                wdif.Show();
            }
          else if (stringToDelete.Equals("deleteBicycle"))
            {
                int id = Convert.ToInt32(IdTextBox.Text);
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
