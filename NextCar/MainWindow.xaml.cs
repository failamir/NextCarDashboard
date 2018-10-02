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

namespace NextCar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Car nextCar;

        public MainWindow()
        {
            InitializeComponent();

            AccubaterryController accubaterryController = new AccubaterryController();

            nextCar = new Car();
            nextCar.setAccubaterryController(accubaterryController);
        }


        private void OnAccuButtonClicked(object sender, RoutedEventArgs e)
        {
            Boolean powerIsOn = nextCar.powerIsReady();
            if (powerIsOn)
            {
                this.nextCar.turnOfPower();
                this.AccuState.Content = "no power";
                this.AccuButton.Content = "OFF";
            }
            else
            {
                this.nextCar.turnOnPower();
                this.AccuState.Content = "power is ready";
                this.AccuButton.Content = "ON";
            }
        }

        private void OnDoorButtonClicked(object sender, RoutedEventArgs e)
        {

        }

        private void OnStartButtonClicked(object sender, RoutedEventArgs e)
        {

        }
    }
}
