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

    private void exitButtonClicked(object sender, RoutedEventArgs e)
    {
      System.Environment.Exit(0);
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      string bannerId = BannerIDTextBox.Text;
      string password = PasswordBox.Password;
      Worker worker = new Worker();

      worker.populateBannerId(bannerId);

      if (!(password.Equals(worker.getCredential())))
      {
        this.Hide();
        mainMenu mm = new mainMenu();
        mm.Show();
      }
      else
      {
        MessageBox.Show("Incorrect password or BannerID");
      }


    }
  }
}
