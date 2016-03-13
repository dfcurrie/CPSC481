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
        Window mainWindow;
        public MenuPage() {
            InitializeComponent();
            this.mainWindow = Application.Current.MainWindow;
        }

        private void Trips_DoubleClick(object sender, MouseButtonEventArgs e) {
            NavigationService.Navigate(new Uri("TripsPage.xaml", UriKind.Relative));
            Label action = (Label)mainWindow.FindName("ActionBtn_Txt");
            action.Content = "+";
            Label screenName = (Label)mainWindow.FindName("CurrentScreenLbl");
            screenName.Content = "My Trips";
  
        }

        private void Friends_DoubleClick(object sender, MouseButtonEventArgs e) {
            NavigationService.Navigate(new Uri("FriendPage.xaml", UriKind.Relative));
            Label action = (Label)mainWindow.FindName("ActionBtn_Txt");
            action.Content = "+";
            Label screenName = (Label)mainWindow.FindName("CurrentScreenLbl");
            screenName.Content = "Friend Finder";
        }

        private void Stats_DoubleClick(object sender, MouseButtonEventArgs e) {
            NavigationService.Navigate(new Uri("StatisticsPage.xaml", UriKind.Relative));
            Label action = (Label)mainWindow.FindName("ActionBtn_Txt");
            action.Content = "+";
            Label screenName = (Label)mainWindow.FindName("CurrentScreenLbl");
            screenName.Content = "Statistics";
        }

        private void Info_DoubleClick(object sender, MouseButtonEventArgs e) {
            NavigationService.Navigate(new Uri("InfoPage.xaml", UriKind.Relative));
            Label action = (Label)mainWindow.FindName("ActionBtn_Txt");
            action.Content = "+";
            Label screenName = (Label)mainWindow.FindName("CurrentScreenLbl");
            screenName.Content = "Info";
        }

        private void Deals_DoubleClick(object sender, MouseButtonEventArgs e) {
            NavigationService.Navigate(new Uri("DealsPage.xaml", UriKind.Relative));
            Label action = (Label)mainWindow.FindName("ActionBtn_Txt");
            action.Content = "+";
            Label screenName = (Label)mainWindow.FindName("CurrentScreenLbl");
            screenName.Content = "Deals";
        }
    }
}
