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
    public partial class MainMenuForm1 : Form
    {
        MainWindow myCaller;
        public Worker currentWorker;

        public MainMenuForm1(MainWindow m, Worker cw)
        {
            InitializeComponent();
            myCaller = m;
            currentWorker = cw;
        }

        private void InsertUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDataInputForm udif = new UserDataInputForm(this);
            udif.Show();
        }

      private void InsertWorkerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkerDataInputForm wdif = new WorkerDataInputForm(this);
            wdif.Show();
        }
      
      private void InsertBicycleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BicycleDataInputForm bdif = new BicycleDataInputForm(this);
            bdif.Show();
        }

      private void ModifyUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateForm uf = new UpdateForm(this, "modifyUser");
            uf.Show();
            
        }

      private void ModifyWorkerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateForm uf = new UpdateForm(this, "modifyWorker");
            uf.Show();
        }

      private void ModifyBicycleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateForm uf = new UpdateForm(this,"modifyBicycle");
            uf.Show();
        }

      private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteForm df = new DeleteForm(this, "deleteUser");
            df.Show();
        }

      private void DeleteWorkerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteForm df = new DeleteForm(this, "deleteWorker");
            df.Show();
        }

      private void DeleteBicycleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteForm df = new DeleteForm(this, "deleteBicycle");
            df.Show();
        }

      private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            myCaller.Show();
        }

      private void RentBicycleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentABicycleForm rbf = new RentABicycleForm(this, currentWorker);
            rbf.Show();
        }

      private void ReturnBicycleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnBicycleForm rbf = new ReturnBicycleForm(this, currentWorker);
            rbf.Show();
        }

      private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }


      private void InsertUserButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UserDataInputForm udif = new UserDataInputForm(this);
            udif.Show();
        }
    }
}
