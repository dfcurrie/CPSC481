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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SkiAndBoardApp {
    /// <summary>
    /// Interaction logic for MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page {
        public MenuPage() {
            InitializeComponent();
        }

        private void Trips_DoubleClick(object sender, MouseButtonEventArgs e) {
            NavigationService.Navigate(new Uri("TripsPage.xaml", UriKind.Relative));
        }

        private void Friends_DoubleClick(object sender, MouseButtonEventArgs e) {
            NavigationService.Navigate(new Uri("FriendPage.xaml", UriKind.Relative));
        }

        private void Stats_DoubleClick(object sender, MouseButtonEventArgs e) {
            NavigationService.Navigate(new Uri("StatisticsPage.xaml", UriKind.Relative));
        }

        private void Info_DoubleClick(object sender, MouseButtonEventArgs e) {
            NavigationService.Navigate(new Uri("InfoPage.xaml", UriKind.Relative));
        }

        private void Deals_DoubleClick(object sender, MouseButtonEventArgs e) {
            NavigationService.Navigate(new Uri("DealsPage.xaml", UriKind.Relative));
        }
    }
}
