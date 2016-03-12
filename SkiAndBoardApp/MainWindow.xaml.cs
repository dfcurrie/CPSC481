using System;
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
            MainFrame.Navigate(new TripsPage());
        }

        private void Window_loaded(object sender, RoutedEventArgs e) {
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

        private void AddTripBtn_Click(object sender, RoutedEventArgs e) {
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e) {
            this.MainFrame.Navigate(new Uri("TripsPage.xaml", UriKind.Relative));
        }


    }
}