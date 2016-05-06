using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleRentalWPF
{
    public partial class BicycleDataInputForm : Form
    {
        Form myCaller;
        MainMenu mainMenu;
        int id;
        string FormAction;

        public BicycleDataInputForm(MainMenu mm)
        {
            InitializeComponent();
            myCaller = mm;

            BicycleDataInputFormTitle.Text = "Insert new Bicycle data";
            

            Object[] location = new Object[7];
            location[0] = "Benedict Hall";
            location[1] = "Harmon Hall";
            location[2] = "McFarlane Hall";
            location[3] = "Mortimer Hall";
            location[4] = "Student Union";
            location[5] = "Thompson Hall";
            location[6] = "Welcome Center";
            LocationComboBox.Items.AddRange(location);

            Object[] physical = new Object[2];
            physical[0] = "Good";
            physical[1] = "Damaged";
            PhysicalConditionComboBox.Items.AddRange(physical);

            Object[] status = new Object[2];
            status[0] = "Available";
            status[1] = "Unavailable";
            StatusComboBox.Items.AddRange(status);

            StatusComboBox.SelectedIndex = 0;

            FormAction = "insert";
        }

        public BicycleDataInputForm(UpdateForm uf, int i, MainMenu mm)
        {
            InitializeComponent();

            myCaller = uf;
            mainMenu = mm;

            BicycleDataInputFormTitle.Text = "Modify Bicycle data";

            Object[] location = new Object[7];
            location[0] = "Benedict Hall";
            location[1] = "Harmon Hall";
            location[2] = "McFarlane Hall";
            location[3] = "Mortimer Hall";
            location[4] = "Student Union";
            location[5] = "Thompson Hall";
            location[6] = "Welcome Center";
            LocationComboBox.Items.AddRange(location);

            Object[] physical = new Object[2];
            physical[0] = "Good";
            physical[1] = "Damaged";
            PhysicalConditionComboBox.Items.AddRange(physical);

            Object[] status = new Object[2];
            status[0] = "Available";
            status[1] = "Unavailable";
            StatusComboBox.Items.AddRange(status);

            

            Vehicle existingVehicle = new Vehicle();

            existingVehicle.populate(i);
            BikeMakeBox.Text = existingVehicle.BikeMake ;
            ModelNumberBox.Text = existingVehicle.ModelNumber;
            SerialNumberBox.Text = existingVehicle.SerialNumber;
            ColorBox.Text = existingVehicle.Color;
            DescriptionBox.Text = existingVehicle.Description;
            LocationComboBox.SelectedIndex = LocationComboBox.FindStringExact(existingVehicle.Location);
            PhysicalConditionComboBox.SelectedIndex = PhysicalConditionComboBox.FindStringExact(existingVehicle.PhysicalCondition);
            NotesBox.Text = existingVehicle.Notes;
            StatusComboBox.SelectedIndex = StatusComboBox.FindStringExact(existingVehicle.Status);
           
            FormAction = "update";
            id = i;
        }

         public BicycleDataInputForm(DeleteForm df, int i, MainMenu m)
        {
            InitializeComponent();
            myCaller = df;
            mainMenu = m;

            Object[] location = new Object[7];
            location[0] = "Benedict Hall";
            location[1] = "Harmon Hall";
            location[2] = "McFarlane Hall";
            location[3] = "Mortimer Hall";
            location[4] = "Student Union";
            location[5] = "Thompson Hall";
            location[6] = "Welcome Center";
            LocationComboBox.Items.AddRange(location);

            Object[] physical = new Object[2];
            physical[0] = "Good";
            physical[1] = "Damaged";
            PhysicalConditionComboBox.Items.AddRange(physical);

            Object[] status = new Object[2];
            status[0] = "Available";
            status[1] = "Unavailable";
            StatusComboBox.Items.AddRange(status);

            Vehicle existingVehicle = new Vehicle();

            existingVehicle.populate(i);
            BicycleDataInputFormTitle.Text = "Are you sure? Click submit to delete this Bicycle";
            BikeMakeBox.Text = existingVehicle.BikeMake;
            ModelNumberBox.Text = existingVehicle.ModelNumber;
            SerialNumberBox.Text = existingVehicle.SerialNumber;
            ColorBox.Text = existingVehicle.Color;
            DescriptionBox.Text = existingVehicle.Description;
            LocationComboBox.SelectedIndex = LocationComboBox.FindStringExact(existingVehicle.Location);
            PhysicalConditionComboBox.SelectedIndex = PhysicalConditionComboBox.FindStringExact(existingVehicle.PhysicalCondition);
            NotesBox.Text = existingVehicle.Notes;
            StatusComboBox.SelectedIndex = StatusComboBox.FindStringExact(existingVehicle.Status);

            FormAction = "delete";
            id = i;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (FormAction.Equals("insert"))
            {
                string bikeMake = BikeMakeBox.Text;
                string modelNumber = ModelNumberBox.Text;
                string serialNumber = SerialNumberBox.Text;
                string color = ColorBox.Text;
                string description = DescriptionBox.Text;
                string location = Convert.ToString(LocationComboBox.SelectedItem);
                string physicalDescription = Convert.ToString(PhysicalConditionComboBox.SelectedItem);
                string notes = NotesBox.Text;
                string status = Convert.ToString(StatusComboBox.SelectedItem);

                Vehicle newVehicle = new Vehicle(bikeMake, modelNumber, serialNumber,
                    color, description, location, physicalDescription, notes);
                newVehicle.insert();

                System.Windows.Forms.MessageBox.Show("Successfully inserted bicycle");

                this.Hide();
                myCaller.Show();
            }
            else if(FormAction.Equals("update"))
            {
                Vehicle existingVehicle = new Vehicle();
                existingVehicle.populate(id);

                existingVehicle.BikeMake = BikeMakeBox.Text;
                existingVehicle.ModelNumber = ModelNumberBox.Text;
                existingVehicle.SerialNumber = SerialNumberBox.Text;
                existingVehicle.Color = ColorBox.Text;
                existingVehicle.Description = DescriptionBox.Text;
                existingVehicle.Location = Convert.ToString(LocationComboBox.SelectedItem);
                existingVehicle.PhysicalCondition = Convert.ToString(PhysicalConditionComboBox.SelectedItem);
                existingVehicle.Notes = NotesBox.Text;
                existingVehicle.Status = Convert.ToString(StatusComboBox.SelectedItem);

                existingVehicle.update();

                System.Windows.Forms.MessageBox.Show("Successfully updated bicycle");

                this.Hide();
                mainMenu.Show();
            }
            else if (FormAction.Equals("delete"))
            {
                Vehicle existingVehicle = new Vehicle();
                existingVehicle.populate(id);

                existingVehicle.delete();

                System.Windows.Forms.MessageBox.Show("Successfully deleted bicycle");

                this.Hide();
                mainMenu.Show();
            }
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            myCaller.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
