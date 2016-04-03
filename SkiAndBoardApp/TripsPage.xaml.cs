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
    public partial class TripsPage : Page {
        Window mainWindow;
        public TripsPage() {
            this.mainWindow = Application.Current.MainWindow;
            DataContext = mainWindow.DataContext;
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e) {

        }

    }

}


