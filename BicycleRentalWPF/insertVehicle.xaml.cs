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
    /// Interaction logic for insertVehicle.xaml
    /// </summary>
    public partial class insertVehicle : Window
    {

      Window myCaller;

      public insertVehicle(mainMenu mm)
      {
        InitializeComponent();
        myCaller = mm;
      }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
          string bikeMake = BikeMakeTextBox.Text;
          string modelNumber = ModelNumberTextBox.Text;
          string serialNum = SerialNumberTextBox.Text;
          string color = ColorTextBox.Text;
          string description = DescriptionTextBox.Text;
          string location = LocationTextBox.Text;
          string physicalCondition = PhysicalConditionTextBox.Text;
          string notes = NotesTextBox.Text;
          string status = Convert.ToString(StatusComboBox.SelectedItem);
          string dateStatusUpdated = DateTime.Now.ToString("yyyy-MM-dd");

          Vehicle newVehicle = new Vehicle(bikeMake, modelNumber, serialNum, color, description, location, physicalCondition, notes, status, dateStatusUpdated);
          newVehicle.insert();

          MessageBox.Show("Vehicle insert successful!");

          this.Close();
          myCaller.Show();
        }
    }
}
