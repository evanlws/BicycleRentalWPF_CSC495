using System;
using System.Collections.Generic;
using System.Data.OleDb;
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
            DataValidation dv = new DataValidation();   
        bool validLogin = true;
        List<string> dataInput = new List<string>(){ BannerIDTextBox.Text, PasswordBox.Password };

        validLogin = dv.Login(dataInput);   //check if ID and Password matches
       
            if (validLogin)
        {
            mainMenu menu = new mainMenu(); //go to main menu
            menu.ShowDialog();
            this.Close();

            }
        else
        {
            MessageBox.Show("Incorrect password, please try again");
        }


    }
  }
}
