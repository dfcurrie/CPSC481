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
using System.Collections;

namespace SkiAndBoardApp {
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
            DataContext = new TripObject();
        }

        private void Window_loaded(object sender, RoutedEventArgs e) {
            initTime();
            Application.Current.MainWindow = this;
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

        private void ActionBtn_Click(object sender, RoutedEventArgs e) {

            if (CurrentScreenLbl.Content.ToString().Contains("My Trip")) {
                MainFrame.Navigate(new Uri("AddTrip.xaml", UriKind.Relative));
                CurrentScreenLbl.Content = "Add Trip";
                ActionBtn_Txt.Content = "";
                Console.WriteLine("Add Trip");
            } 
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e) {
            if (curTripObject.curTrip!= null) {
            string[] split = curTripObject.curTrip.Split('-');

            Console.WriteLine(split[1].Substring(1));

            if (Convert.ToDateTime(split[1].Substring(1)) == DateTime.Today)
            { 
                this.CurrentScreenLbl.Content = "Menu";
                this.ActionBtn_Txt.Content = "";
                this.MainFrame.Navigate(new Uri("MenuPage.xaml", UriKind.Relative));
             }

            if (Convert.ToDateTime(split[1].Substring(1)) < DateTime.Today)
            {
                this.CurrentScreenLbl.Content = "Menu";
                this.ActionBtn_Txt.Content = "";
                this.MainFrame.Navigate(new Uri("MenuPage2.xaml", UriKind.Relative));
            }
            } else {
                this.CurrentScreenLbl.Content = "Menu";
                this.ActionBtn_Txt.Content = "";
                this.MainFrame.Navigate(new Uri("MenuPage2.xaml", UriKind.Relative));
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e) {
            if (this.MainFrame.NavigationService.CanGoBack) {
                this.MainFrame.NavigationService.GoBack();
                this.ActionBtn_Txt.Content = "+";
            }
        }


    }
}