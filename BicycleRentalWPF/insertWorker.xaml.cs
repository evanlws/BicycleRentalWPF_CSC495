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
    /// <summary>
    /// Interaction logic for insertWorker.xaml
    /// </summary>
    public partial class insertWorker : Window
    {

      Window myCaller;

      public insertWorker(mainMenu mm)
      {
        InitializeComponent();
        myCaller = mm;
      }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
          string bannerID = BannerIDTextBox.Text;
          string firstName = FirstNameTextBox.Text;
          string lastName = LastNameTextBox.Text;
          string phoneNumber = PhoneNumberTextBox.Text;
          string email = EmailTextBox.Text;
          string credential = CredentialTextBox.Text;
          string notes = NoteTextBox.Text;
          string status = Convert.ToString(StatusComboBox.SelectedItem);
          string dateStatusUpdated = DateTime.Now.ToString("yyyy-MM-dd");

          Worker newWorker = new Worker(bannerID, firstName, lastName, phoneNumber, email, credential, notes, status, dateStatusUpdated);
          newWorker.insert();

          MessageBox.Show("Worker insert successful!");

          this.Close();
          myCaller.Show();
        }
    }
}
