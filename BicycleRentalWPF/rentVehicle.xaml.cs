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
    /// Interaction logic for rentBicycle.xaml
    /// </summary>
    public partial class rentVehicle : Window
    {
      Window myCaller;
        public rentVehicle(Window mm)
        {
            InitializeComponent();
            myCaller = mm;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;

        }
    }
}
