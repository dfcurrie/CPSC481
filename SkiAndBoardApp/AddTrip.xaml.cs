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
    public partial class AddTrip : Page {
        Window mainWindow;
        public AddTrip() {
            InitializeComponent();
            this.mainWindow = Application.Current.MainWindow;
            DataContext = mainWindow.DataContext;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            var tripObject = DataContext as TripObject;
            char[] splitChars = { ':' };
            String[] tripStr = Location.SelectedItem.ToString().Split(splitChars);
            String str = tripStr[1].Substring(1);
            str = str + " - " + DateTime.Now.ToShortDateString();
            tripObject.tripList.Insert(0, str);

            Console.WriteLine("Add Trip");
            NavigationService.Navigate(new Uri("TripsPage.xaml", UriKind.Relative));
            Label action = (Label)mainWindow.FindName("ActionBtn_Txt");
            action.Content = "+";
            Label screenName = (Label)mainWindow.FindName("CurrentScreenLbl");
            screenName.Content = "My Trips";
            Console.WriteLine(Location.SelectedItem);
          
        }

        private void Location_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            AddTripBtn.IsEnabled=true;
        }
    }
}
