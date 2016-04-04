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
    /// Interaction logic for StatisticsPage.xaml
    /// </summary>
    public partial class StatisticsPage : Page
    {
        public StatisticsPage()
        {
            InitializeComponent();
            DataContext = globalFriendObject.friends;
        }

        private void StatListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (curTripObject.curTrip != null)
            {
                string[] split = curTripObject.curTrip.Split('-');
                if (split[0] == "Sunshine ")
                {
                    foreach (String i in StatListBox.SelectedItems)
                    {
                        if (i == "Rayce Rossum")
                        {
                            statsMap.Source = new BitmapImage(new Uri("stats2.jpg", UriKind.Relative));
                        }
                        else if (i == "LaVerne Woroschuk")
                        {
                            statsMap.Source = new BitmapImage(new Uri("stats3.jpg", UriKind.Relative));
                        }
                        else if (i == "David Currie")
                        {
                            statsMap.Source = new BitmapImage(new Uri("stats1.jpg", UriKind.Relative));
                        }
                    }
                }
                else if (split[0] == "Canada Olympic Park ")
                {
                    foreach (String i in StatListBox.SelectedItems)
                    {
                        if (i == "Rayce Rossum")
                        {
                            statsMap.Source = new BitmapImage(new Uri("stats2.jpg", UriKind.Relative));
                        }
                        else if (i == "LaVerne Woroschuk")
                        {
                            statsMap.Source = new BitmapImage(new Uri("stats3.jpg", UriKind.Relative));
                        }
                        else if (i == "David Currie")
                        {
                            statsMap.Source = new BitmapImage(new Uri("stats1.jpg", UriKind.Relative));
                        }
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (curTripObject.curTrip != null)
            {
                string[] split = curTripObject.curTrip.Split('-');
                if (split[0] == "Sunshine ")
                {
                    statsMap.Source = new BitmapImage(new Uri("stats1.jpg", UriKind.Relative));
                }
                else if (split[0] == "Canada Olympic Park ")
                {
                    statsMap.Source = new BitmapImage(new Uri("stats3.jpg", UriKind.Relative));

                }
            }
        }
    }
}
