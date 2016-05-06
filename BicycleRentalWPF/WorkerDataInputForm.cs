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
    public partial class WorkerDataInputForm : Form
    {
        Form myCaller;
        MainMenuForm1 mainMenu;
        string InteractionState;
        string id;

        public WorkerDataInputForm(MainMenuForm1 m)
        {
            InitializeComponent();
            myCaller = m;
            WorkerPasswordBox.PasswordChar = '*';
            InteractionState = "nothing";
            RyanC.Text = "Enter new Worker data";

            Object[] credential = new Object[2];
            credential[0] = "Administrator";
            credential[1] = "Ordinary";
            CredentialComboBox.Items.AddRange(credential);

            Object[] status = new Object[2];
            status[0] = "Active";
            status[1] = "Inactive";
            StatusComboBox.Items.AddRange(status);

            StatusComboBox.SelectedIndex = 0;

        }

        public WorkerDataInputForm(UpdateForm uf, string s, MainMenuForm1 m)
        {
            InitializeComponent();
            myCaller = uf;
            mainMenu = m;
            WorkerPasswordBox.PasswordChar = '*';

            Object[] credential = new Object[2];
            credential[0] = "Faculty/Staff";
            credential[1] = "Student";
            CredentialComboBox.Items.AddRange(credential);

            Object[] status = new Object[2];
            status[0] = "Active";
            status[1] = "Inactive";
            StatusComboBox.Items.AddRange(status);

            Worker existingWorker = new Worker();

            existingWorker.populateBannerID(s);
            RyanC.Text = "Modify Worker Data";
            BannerIDBox.Text = existingWorker.BannerID;
            FirstNameBox.Text = existingWorker.FirstName;
            LastNameBox.Text = existingWorker.LastName;
            PhoneNumberBox.Text = existingWorker.PhoneNumber;
            EmailBox.Text = existingWorker.EmailAddress;
            CredentialComboBox.SelectedIndex = CredentialComboBox.FindStringExact(existingWorker.Credential);
            WorkerPasswordBox.Text = existingWorker.WorkerPassword;
            NotesBox.Text = existingWorker.Notes;
            StatusComboBox.SelectedIndex = StatusComboBox.FindStringExact(existingWorker.Status);
           
            InteractionState = "update";
            id = s;
        }

        public WorkerDataInputForm(DeleteForm df, string s, MainMenuForm1 m)
        {
            InitializeComponent();
            myCaller = df;
            mainMenu = m;
            RyanC.Text = "Hit submit to confirm deletion";
            WorkerPasswordBox.PasswordChar = '*';

            Object[] credential = new Object[2];
            credential[0] = "Faculty/Staff";
            credential[1] = "Student";
            CredentialComboBox.Items.AddRange(credential);

            Object[] status = new Object[2];
            status[0] = "Active";
            status[1] = "Inactive";
            StatusComboBox.Items.AddRange(status);

            Worker existingWorker = new Worker();


            existingWorker.populateBannerID(s);

            BannerIDBox.Text = existingWorker.BannerID;
            FirstNameBox.Text = existingWorker.FirstName;
            LastNameBox.Text = existingWorker.LastName;
            PhoneNumberBox.Text = existingWorker.PhoneNumber;
            EmailBox.Text = existingWorker.EmailAddress;
            StatusComboBox.SelectedIndex = StatusComboBox.FindStringExact(existingWorker.Status);
            WorkerPasswordBox.Text = existingWorker.WorkerPassword;
            NotesBox.Text = existingWorker.Notes;
            StatusComboBox.SelectedIndex = StatusComboBox.FindStringExact(existingWorker.Status);

            InteractionState = "delete";
            id = s; 
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            if (InteractionState.Equals("nothing"))
            {
                string bannerID = BannerIDBox.Text;
                string firstName = FirstNameBox.Text;
                string lastName = LastNameBox.Text;
                string phoneNumber = PhoneNumberBox.Text;
                string email = EmailBox.Text;
                string credential = Convert.ToString(CredentialComboBox.SelectedItem);
                string workerPassword = WorkerPasswordBox.Text;
                string notes = NotesBox.Text;
                string status = Convert.ToString(StatusComboBox.SelectedItem);

                Worker newWorker = new Worker(bannerID, firstName, lastName, phoneNumber,
                    email, credential, workerPassword, notes);
                newWorker.insert();

                System.Windows.Forms.MessageBox.Show("Worker insert successful!");

                this.Hide();
                myCaller.Show();
            }
            else if (InteractionState.Equals("update"))
            {
                Worker existingWorker = new Worker();
                existingWorker.populateBannerID(id);

                existingWorker.BannerID = BannerIDBox.Text;
                existingWorker.FirstName = FirstNameBox.Text;
                existingWorker.LastName = LastNameBox.Text;
                existingWorker.PhoneNumber = PhoneNumberBox.Text;
                existingWorker.EmailAddress = EmailBox.Text;
                existingWorker.Credential = Convert.ToString(CredentialComboBox.SelectedItem);
                existingWorker.WorkerPassword = WorkerPasswordBox.Text;
                existingWorker.Notes = NotesBox.Text;
                existingWorker.Status = Convert.ToString(StatusComboBox.SelectedItem);
         
                existingWorker.update();

                System.Windows.Forms.MessageBox.Show("Worker update successful!");

                this.Hide();
                mainMenu.Show();
            }
            else if (InteractionState.Equals("delete"))
            {
                Worker existingWorker = new Worker();
                existingWorker.populateBannerID(id);

                existingWorker.delete();

                System.Windows.Forms.MessageBox.Show("Worker deletion successful!");

                this.Hide();
                mainMenu.Show();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
          myCaller.Show();
            this.Hide();
        }

    }
}
