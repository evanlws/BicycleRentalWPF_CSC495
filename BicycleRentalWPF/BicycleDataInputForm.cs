﻿using System;
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
        MainMenuForm1 mainMenu;
        int id;
        string InteractionState;

        public BicycleDataInputForm(MainMenuForm1 m)
        {
            InitializeComponent();

            RajIsMyFavorite.Text = "Insert new Bicycle data";
            

            Object[] location = new Object[10];
            location[0] = "Benedict";
            location[1] = "Brockway";
            location[2] = "Harmon";
            location[3] = "McFarlane";
            location[4] = "Mortimer";
            location[5] = "Seymour College Union";
            location[6] = "Thompson";
            location[7] = "Town Holmes";
            location[8] = "Tuttle";
            location[9] = "Welcome Center";
            LocationComboBox.Items.AddRange(location);

            Object[] physical = new Object[2];
            physical[0] = "Good";
            physical[1] = "Damaged";
            PhysicalConditionComboBox.Items.AddRange(physical);

            Object[] status = new Object[2];
            status[0] = "Active";
            status[1] = "Inactive";
            StatusComboBox.Items.AddRange(status);

            StatusComboBox.SelectedIndex = 0;

            myCaller = m;
            InteractionState = "nothing";
        }

        public BicycleDataInputForm(UpdateForm uf, int i, MainMenuForm1 m)
        {
            InitializeComponent();

            myCaller = uf;
            mainMenu = m;

            RajIsMyFavorite.Text = "Modify Bicycle data";

            Object[] location = new Object[10];
            location[0] = "Benedict";
            location[1] = "Brockway";
            location[2] = "Harmon";
            location[3] = "McFarlane";
            location[4] = "Mortimer";
            location[5] = "Seymour College Union";
            location[6] = "Thompson";
            location[7] = "Town Holmes";
            location[8] = "Tuttle";
            location[9] = "Welcome Center";
            LocationComboBox.Items.AddRange(location);

            Object[] physical = new Object[2];
            physical[0] = "Good";
            physical[1] = "Damaged";
            PhysicalConditionComboBox.Items.AddRange(physical);

            Object[] status = new Object[2];
            status[0] = "Active";
            status[1] = "Inactive";
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
           
            InteractionState = "update";
            id = i;
        }

         public BicycleDataInputForm(DeleteForm df, int i, MainMenuForm1 m)
        {
            InitializeComponent();
            myCaller = df;
            mainMenu = m;

            Object[] location = new Object[10];
            location[0] = "Benedict";
            location[1] = "Brockway";
            location[2] = "Harmon";
            location[3] = "McFarlane";
            location[4] = "Mortimer";
            location[5] = "Seymour College Union";
            location[6] = "Thompson";
            location[7] = "Town Holmes";
            location[8] = "Tuttle";
            location[9] = "Welcome Center";
            LocationComboBox.Items.AddRange(location);

            Object[] physical = new Object[2];
            physical[0] = "Good";
            physical[1] = "Damaged";
            PhysicalConditionComboBox.Items.AddRange(physical);

            Object[] status = new Object[2];
            status[0] = "Active";
            status[1] = "Inactive";
            StatusComboBox.Items.AddRange(status);

            Vehicle existingVehicle = new Vehicle();

            existingVehicle.populate(i);
            RajIsMyFavorite.Text = "Hit submit to confirm deletion";
            BikeMakeBox.Text = existingVehicle.BikeMake;
            ModelNumberBox.Text = existingVehicle.ModelNumber;
            SerialNumberBox.Text = existingVehicle.SerialNumber;
            ColorBox.Text = existingVehicle.Color;
            DescriptionBox.Text = existingVehicle.Description;
            LocationComboBox.SelectedIndex = LocationComboBox.FindStringExact(existingVehicle.Location);
            PhysicalConditionComboBox.SelectedIndex = PhysicalConditionComboBox.FindStringExact(existingVehicle.PhysicalCondition);
            NotesBox.Text = existingVehicle.Notes;
            StatusComboBox.SelectedIndex = StatusComboBox.FindStringExact(existingVehicle.Status);

            InteractionState = "delete";
            id = i;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (InteractionState.Equals("nothing"))
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

                System.Windows.Forms.MessageBox.Show("Bike insert successful!");

                this.Hide();
                myCaller.Show();
            }
            else if(InteractionState.Equals("update"))
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

                System.Windows.Forms.MessageBox.Show("Bike update successful!");

                this.Hide();
                mainMenu.Show();
            }
            else if (InteractionState.Equals("delete"))
            {
                Vehicle existingVehicle = new Vehicle();
                existingVehicle.populate(id);

                existingVehicle.delete();

                System.Windows.Forms.MessageBox.Show("Bike delete successful!");

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