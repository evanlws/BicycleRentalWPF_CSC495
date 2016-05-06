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
    /// Interaction logic for modifyUser.xaml
    /// </summary>
    public partial class modifyUser2 : Window
    {
      Window myCaller;
      User user;

      public modifyUser2(Window mm, User user)
       {
            InitializeComponent();
            myCaller = mm;
            this.user = user;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
          this.Close();
          myCaller.Show();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
          user.setBannerId(BannerIDTextBox.Text);
          user.setFirstName(FirstNameTextBox.Text);
          user.setLastName(LastNameTextBox.Text);
          user.setPhoneNumber(PhoneNumberTextBox.Text);
          user.setEmailAddress(EmailTextBox.Text);
          user.setUserType(Convert.ToString(UserTypeComboBox.SelectedItem));
          user.setNotes(NoteTextBox.Text);
          user.setStatus(Convert.ToString(StatusComboBox.SelectedItem));
          user.update();

          MessageBox.Show("User update successful!");

          this.Close();
          myCaller.Show();
        }
    }
}
