﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SkiAndBoardApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            initTime();
        }

        private void initTime() {
            System.Timers.Timer time = new System.Timers.Timer();
            time.Elapsed += new ElapsedEventHandler(updateTime);
            time.Interval = 1000;
            time.Enabled = true;
        }

        private void updateTime(object source, ElapsedEventArgs e) {
            this.Dispatcher.Invoke((Action)(() => {
                this.TimeLbl.Content = DateTime.Now.ToString("hh:mm tt");
            }));
        }

        private void AddTripBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            this.Dispatcher.Invoke((Action)(() => {
                this.TripList.Items.Add("Test Add Button");
            }));
        }
    }
}