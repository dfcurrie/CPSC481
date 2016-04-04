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
    /// Interaction logic for DealsPage.xaml
    /// </summary>
    public partial class DealsPageDeal3 : Page {
        public DealsPageDeal3() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("DealsPage.xaml", UriKind.Relative));
        }
    }
}
