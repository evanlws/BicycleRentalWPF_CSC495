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
            string workerID = BannerIDBox.Text;
            string pwd = PasswordBox1.Password;
            Worker currentWorker = new Worker();
            currentWorker.populateBannerID(workerID);

            if ( (pwd.Equals(currentWorker.WorkerPassword)))
            {
                System.Windows.Forms.MessageBox.Show("Incorrect Password or BannerID");
            }
            else
            {
                this.Hide();
                MainMenuForm1 mmf = new MainMenuForm1(this, currentWorker);
                mmf.Show();
            }              
        }     
    }
}
