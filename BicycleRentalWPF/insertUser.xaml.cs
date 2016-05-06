using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BicycleRentalWPF
{

    public partial class insertUser : Window
    {

      Window myCaller;

        public insertUser(mainMenu mm)
        {
            InitializeComponent();
            myCaller = mm;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
          string bannerID = BannerIDTextBox.Text;
          string firstName = FirstNameTextBox.Text;
          string lastName = LastNameTextBox.Text;
          string phoneNumber = PhoneNumberTextBox.Text;
          string email = EmailTextBox.Text;
          string UserType = Convert.ToString(UserTypeComboBox.SelectedItem);
          string notes = NoteTextBox.Text;
          string status = Convert.ToString(StatusComboBox.SelectedItem);
          string dateStatusUpdated = DateStatusUpdatedTextField.Text;

          User newUser = new User(bannerID, firstName, lastName, phoneNumber, email, UserType, notes, status, dateStatusUpdated);
          newUser.insert();

          MessageBox.Show("User insert successful!");

          this.Close();
          myCaller.Show();

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
          this.Close();
          myCaller.Show();
            
        }
    }
}
