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
    /// Interaction logic for insertUser.xaml
    /// </summary>
    public partial class insertUser : Window
    {
        public insertUser()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            bool validData = false;

            User newUser = new User();

            newUser.setBannerId(BannerIDTextBox.Text);
            newUser.setFirstName(FirstNameTextBox.Text);
            newUser.setLastName(LastNameTextBox.Text);
            newUser.setPhoneNumber(PhoneNumberTextBox.Text);
            newUser.setEmailAddress(EmailTextBox.Text);
            newUser.setUserType(UserTypeTextBox.Text);
            newUser.setNotes(NoteTextBox.Text);
            newUser.setStatus(StatusComboBox.Text);
            

    

            //validData = DataValidation.ValidateInsertUser(newUser);


        }
    }
}
