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
using System.Windows.Navigation;

namespace BicycleRentalWPF
{
    /// <summary>
    /// Interaction logic for mainMenu.xaml
    /// </summary>
    public partial class mainMenu : Window
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void insertUserButton_Click(object sender, RoutedEventArgs e)
        {
            insertUser insertUserView = new insertUser();
            this.Hide();
            insertUserView.ShowDialog();
            this.Show();
        }


        private void deleteUserButton_Click(object sender, RoutedEventArgs e)
        {
            deleteUser1 deleteUserView = new deleteUser1();
            this.Hide();
            deleteUserView.ShowDialog();
            this.Show();
        }

        private void modifyUserButton_Click_1(object sender, RoutedEventArgs e)
        {
            modifyUser1 modifyUserView1 = new modifyUser1();
            this.Hide();
            modifyUserView1.ShowDialog();
            this.Show();
        }

        private void insertWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            insertWorker insertWorkerView= new insertWorker();
            this.Hide();
            insertWorkerView.ShowDialog();
            this.Show();
        }

        private void modifyWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            modifyWorker1 modifyWorker1View = new modifyWorker1();
            this.Hide();
            modifyWorker1View.ShowDialog();
            this.Show();
        }

        private void deleteWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            deleteWorker1 deleteWorker1View = new deleteWorker1();
            this.Hide();
            deleteWorker1View.ShowDialog();
            this.Show();

        }

        private void insertBicycleButton_Click(object sender, RoutedEventArgs e)
        {
            insertVehicle insertVehicleView = new insertVehicle();
            this.Hide();
            insertVehicleView.ShowDialog();
            this.Show();
        }

        private void modifyBicycleButton_Click(object sender, RoutedEventArgs e)
        {
            modifyVehicle1 modifyVehicle1View = new modifyVehicle1();
            this.Hide();
            modifyVehicle1View.ShowDialog();
            this.Show();
        }

        private void deleteBicycleButton_Click(object sender, RoutedEventArgs e)
        {
            deleteVehicle1 deleteVehicle1View = new deleteVehicle1();
            this.Hide();
            deleteVehicle1View.ShowDialog();
            this.Show();
        }

        private void rentBicycleButton_Click(object sender, RoutedEventArgs e)
        {
            rentVehicle rentBicycleView = new rentVehicle();
            this.Hide();
            rentBicycleView.ShowDialog();
            this.Show();

        }

        private void returnBicycleButton_Click(object sender, RoutedEventArgs e)
        {
            returnVehicle returnVehicleView = new returnVehicle();
            this.Hide();
            returnVehicleView.ShowDialog();
            this.Show();

        }

        private void mainMenuBackButton_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginScreen = new LoginWindow();
            loginScreen.Show();
            this.Close();
        }
    }
}
