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
    /// Interaction logic for modifyUser1.xaml
    /// </summary>
    public partial class modifyUser1 : Window
    {
      Window myCaller;

      public modifyUser1(mainMenu mm)
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
          User user = new User();
          user.populateBannerID(bannerId);
          modifyUser2 mu2 = new modifyUser2(myCaller, user);
        }
    }
}
