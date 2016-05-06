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
    /// Interaction logic for modifyWorker.xaml
    /// </summary>
    public partial class modifyWorker1 : Window
    {
      Window myCaller;

      public modifyWorker1(mainMenu mm)
      {
        InitializeComponent();
        myCaller = mm;
      }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
          this.Hide();
          myCaller.Show();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
          string bannerId = BannerIDTextBox.Text;
          Worker worker = new Worker();
          worker.populateBannerID(bannerId);
          modifyWorker2 mu2 = new modifyWorker2(myCaller, worker);
        }
    }
}
