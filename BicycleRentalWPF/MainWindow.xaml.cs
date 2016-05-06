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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BicycleRentalWPF
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  /// 
  public partial class LoginWindow : Window
  {
      
    public LoginWindow()
    {
      InitializeComponent();
    }

    //exits the program
    private void exitButtonClicked(object sender, RoutedEventArgs e)
    {
      System.Environment.Exit(0);
    }

    //checks user name and password entered and continues to main menu if correct
    private void submitButtonClicked(object sender, RoutedEventArgs e)
    {
      string bannerId = BannerIDTextBox.Text;
      string pwd = PasswordBox.Password;
      Worker currentWorker = new Worker();
      currentWorker.populateBannerID(bannerId);

      if (!(pwd.Equals(currentWorker.getCredential())))
      {
        MessageBox.Show("Incorrect password, please try again");
      }
      else
      {
        this.Hide();
        mainMenu mm = new mainMenu();
        mm.Show();
      }
    }
 
  }
}
