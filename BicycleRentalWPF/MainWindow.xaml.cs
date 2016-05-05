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
  public partial class MainWindow : Window
  {
      
        public MainWindow()
    {
      InitializeComponent();
    }

    private void exitButtonClicked(object sender, RoutedEventArgs e)
    {
      System.Environment.Exit(0);
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {

        bool validLogin = false;
        //LOGIN
        Worker worker = new Worker();
        worker.setBannerId(BannerIDTextBox.Text);
        worker.setWorkerPassword(PasswordBox.Password);
           
        //string bannerID = BannerIDTextBox.Text;
        //string password = PasswordBox.Password;

        validLogin = DataValidation.ValidateLogin(worker);

        if(validLogin)
        {
            mainMenu menu = new mainMenu();
            this.Hide();
            menu.Show();   
        }
        else
        {
            MessageBox.Show("Incorrect password, please try again");
        }


    }
  }
}
