﻿using System;
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
    /// Interaction logic for modifyVechicle2.xaml
    /// </summary>
    public partial class modifyVechicle2 : Window
    {
        public modifyVechicle2()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
