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
    /// Interaction logic for InfoPage.xaml
    /// </summary>
    /// 

    public partial class WelcomePage : Page 
    {
        Window mainWindow;
        WelcomeInfoSun page1 = new WelcomeInfoSun();
        WelcomeInfoCop page2 = new WelcomeInfoCop();

        public WelcomePage() {
            InitializeComponent();
            this.mainWindow = Application.Current.MainWindow;
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cbi = ((sender as ComboBox).SelectedItem as ComboBoxItem);
            if (cbi.Content.ToString() == "Sunshine")
            {
                stackPanel1.Children.Clear();
                stackPanel1.Children.Add(page1);
            }
            else if (cbi.Content.ToString() == "Canada Olympic Park")
            {
                stackPanel1.Children.Clear();
                stackPanel1.Children.Add(page2);
            }

        }



    }
}
