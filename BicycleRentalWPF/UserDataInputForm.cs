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
    public partial class UserDataInputForm : Form
    {
        
        Form myCaller;
        MainMenu mainMenu;
        string FormAction;
        string bannerID = " ";

        public UserDataInputForm(MainMenu m)
        {
            InitializeComponent();
            myCaller = m;
            FormAction = "insert";
            UserDataLabel.Text = "Enter new User data";

            

            Object [] userType = new Object[2];
            userType[0] = "Faculty/Staff";
            userType[1] = "Student";
            UserTypeComboBox.Items.AddRange(userType);

            Object[] status = new Object[2];
            status[0] = "Active";
            status[1] = "Inactive";
            StatusComboBox.Items.AddRange(status);

            StatusComboBox.SelectedIndex = 0;

        }

        public UserDataInputForm(UpdateForm uf, string s, MainMenu m)
        {
            InitializeComponent();
            myCaller = uf;
            this.mainMenu = m;
            User existingUser = new User();

            Object[] userType = new Object[2];
            userType[0] = "Faculty/Staff";
            userType[1] = "Student";
            UserTypeComboBox.Items.AddRange(userType);

            Object[] status = new Object[2];
            status[0] = "Active";
            status[1] = "Inactive";
            StatusComboBox.Items.AddRange(status);

           


            existingUser.populateWithBannerID(s);
            UserDataLabel.Text = "Modify User Data";
            BannerIDBox.Text = existingUser.BannerID;
            FirstNameBox.Text = existingUser.FirstName;
            LastNameBox.Text = existingUser.LastName;
            PhoneNumberBox.Text = existingUser.PhoneNumber;
            EmailBox.Text = existingUser.EmailAddress;
            UserTypeComboBox.SelectedIndex = UserTypeComboBox.FindStringExact(existingUser.UserType);
            NotesBox.Text = existingUser.Notes;
            StatusComboBox.SelectedIndex = StatusComboBox.FindStringExact(existingUser.Status);
           

            FormAction = "update";
            bannerID = s;
        }

        public UserDataInputForm(DeleteForm df, string s, MainMenu m)
        {
            InitializeComponent();
            myCaller = df;
            UserDataLabel.Text = "Hit submit to confirm deletion";
            this.mainMenu = m;
            User existingUser = new User();

            Object[] userType = new Object[2];
            userType[0] = "Faculty/Staff";
            userType[1] = "Student";
            UserTypeComboBox.Items.AddRange(userType);

            Object[] status = new Object[2];
            status[0] = "Active";
            status[1] = "Inactive";
            StatusComboBox.Items.AddRange(status);

            existingUser.populateWithBannerID(s);

            BannerIDBox.Text = existingUser.BannerID;
            FirstNameBox.Text = existingUser.FirstName;
            LastNameBox.Text = existingUser.LastName;
            PhoneNumberBox.Text = existingUser.PhoneNumber;
            EmailBox.Text = existingUser.EmailAddress;
            UserTypeComboBox.SelectedIndex = UserTypeComboBox.FindStringExact(existingUser.UserType);
            NotesBox.Text = existingUser.Notes;
            StatusComboBox.SelectedIndex = StatusComboBox.FindStringExact(existingUser.Status);          

            FormAction = "delete";
            bannerID = s;

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

          if (FormAction.Equals("insert"))
            {
                string bannerID = BannerIDBox.Text;
                string firstName = FirstNameBox.Text;
                string lastName = LastNameBox.Text;
                string phoneNumber = PhoneNumberBox.Text;
                string email = EmailBox.Text;
                string userType = Convert.ToString(UserTypeComboBox.SelectedItem);
                string notes = NotesBox.Text;
                string status = Convert.ToString(StatusComboBox.SelectedItem);
                

                User newUser = new User(bannerID, firstName, lastName, phoneNumber, email,
                    userType, notes);
                newUser.insert();

                System.Windows.Forms.MessageBox.Show("User insert successful!");

                this.Hide();
                myCaller.Show();
                
            }

            else if(FormAction.Equals("update"))
            {
                User existingUser = new User();
                existingUser.populateWithBannerID(bannerID);

                existingUser.BannerID = BannerIDBox.Text;
                existingUser.FirstName = FirstNameBox.Text;
                existingUser.LastName = LastNameBox.Text;
                existingUser.PhoneNumber = PhoneNumberBox.Text;
                existingUser.EmailAddress = EmailBox.Text;
                existingUser.UserType = Convert.ToString(UserTypeComboBox.SelectedItem);
                existingUser.Notes = NotesBox.Text;
                existingUser.Status = Convert.ToString(StatusComboBox.SelectedItem);
                

                existingUser.update();

                System.Windows.Forms.MessageBox.Show("User update successful!");

                this.Hide();
                mainMenu.Show();

            }
            else if (FormAction.Equals("delete"))
            {
                User existingUser = new User();
                existingUser.populateWithBannerID(bannerID);

                existingUser.delete();

                System.Windows.Forms.MessageBox.Show("User deletion successful!");

                this.Hide();
                mainMenu.Show();
            }
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            myCaller.Show();
        }

        private void UserDataInputForm_Load(object sender, EventArgs e)
        {

        }
    }
}
