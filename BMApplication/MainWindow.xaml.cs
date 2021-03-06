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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Maps.MapControl.WPF;

namespace BMApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            
        }

        private void ModeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { 
            string value = ((ComboBoxItem)ModeComboBox.SelectedItem).Content.ToString();
            switch (value)
            {
                case "Road":
                    myMap.Mode = new RoadMode();
                    break;
                case "Aerial":
                    myMap.Mode = new AerialMode(true);
                    break;
                default:
                    break;
            }
        }
    }
}
