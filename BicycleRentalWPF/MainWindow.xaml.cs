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
using System.Windows.Forms;

/*********
 * Evan Lewis
 * Van Le
 ********/

namespace BicycleRentalWPF
{
 
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
          string workerID = BannerIdTextBox.Text;
          string pwd = PasswordTextBox.Password;
            Worker currentWorker = new Worker();
            currentWorker.populateBannerID(workerID);

            if (!(pwd.Equals(currentWorker.WorkerPassword)))
            {
                System.Windows.Forms.MessageBox.Show("Incorrect Password or BannerID");
            }
            else
            {
                this.Hide();
                MainMenu mmf = new MainMenu(this, currentWorker);
                mmf.Show();
            }              
        }     
    }
}
