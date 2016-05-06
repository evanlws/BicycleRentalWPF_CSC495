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
    /// Interaction logic for deleteWorker.xaml
    /// </summary>
    public partial class deleteWorker1 : Window
    {
      Window myCaller;
        public deleteWorker1(Window mm)
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
