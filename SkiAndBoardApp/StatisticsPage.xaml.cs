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
            if (curTripObject.curTrip != null)
            {
                string[] split = curTripObject.curTrip.Split('-');
                if (split[0] == "Sunshine ")
                {
                    statsMap.Source = new BitmapImage(new Uri("stats1.jpg", UriKind.Relative));
                    ChangeBox1.Text = "7                                        7.1km                        0.0seconds";
                    ChangeBox2.Text = "1000m                                     8000m                             16km/h";
                    ChangeBox3.Text = "600                                     110bpm                             2h30m";
                }
                else if (split[0] == "Canada Olympic Park ")
                {
                    statsMap.Source = new BitmapImage(new Uri("stats5.jpg", UriKind.Relative));
                    ChangeBox1.Text = "7                                        2.1km                        0.1seconds";
                    ChangeBox2.Text = "1000m                                     8000m                             36km/h";
                    ChangeBox3.Text = "600                                     110bpm                             1h30m";
                }
            }

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
                            ChangeBox1.Text = "5                                        2.3km                        0.2seconds";
                            ChangeBox2.Text = "1000m                                     8000m                             30km/h";
                            ChangeBox3.Text = "600                                     100bpm                             1h30m";
                        }
                        else if (i == "LaVerne Woroschuk")
                        {
                            statsMap.Source = new BitmapImage(new Uri("stats3.jpg", UriKind.Relative));
                            ChangeBox1.Text = "23                                        9.8km                        0.2seconds";
                            ChangeBox2.Text = "1000m                                     23000m                             20km/h";
                            ChangeBox3.Text = "800                                     100bpm                             1h20m";
                        }
                        else if (i == "David Currie")
                        {
                            statsMap.Source = new BitmapImage(new Uri("stats4.jpg", UriKind.Relative));
                            ChangeBox1.Text = "5                                        2.3km                        0.2seconds";
                            ChangeBox2.Text = "1000m                                     8000m                             30km/h";
                            ChangeBox3.Text = "600                                     100bpm                             1h30m";
                        }
                    }
                }
                else if (split[0] == "Canada Olympic Park ")
                {
                    foreach (String i in StatListBox.SelectedItems)
                    {
                        if (i == "Rayce Rossum")
                        {
                            statsMap.Source = new BitmapImage(new Uri("stats6.jpg", UriKind.Relative));
                            ChangeBox1.Text = "9                                        5.3km                        0.2seconds";
                            ChangeBox2.Text = "1000m                                     8000m                             30km/h";
                            ChangeBox3.Text = "600                                     600bpm                             1h30m";
                        }
                        else if (i == "LaVerne Woroschuk")
                        {
                            statsMap.Source = new BitmapImage(new Uri("stats7.jpg", UriKind.Relative));
                            ChangeBox1.Text = "5                                        2.3km                        0.2seconds";
                            ChangeBox2.Text = "1000m                                     8000m                             30km/h";
                            ChangeBox3.Text = "600                                     800bpm                             1h30m";
                        }
                        else if (i == "David Currie")
                        {
                            statsMap.Source = new BitmapImage(new Uri("stats8.jpg", UriKind.Relative));
                            ChangeBox1.Text = "23                                        2.3km                        0.2seconds";
                            ChangeBox2.Text = "1000m                                     23000m                           30km/h";
                            ChangeBox3.Text = "600                                       200bpm                             1h30m";
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
                    ChangeBox1.Text = "16                                        7.1km                        0.0seconds";
                    ChangeBox2.Text = "1000m                                     8000m                             16km/h";
                    ChangeBox3.Text = "600                                     110bpm                             2h30m";
                }
                else if (split[0] == "Canada Olympic Park ")
                {
                    statsMap.Source = new BitmapImage(new Uri("stats5.jpg", UriKind.Relative));
                    ChangeBox1.Text = "7                                        2.1km                        0.1seconds";
                    ChangeBox2.Text = "1000m                                     8000m                             36km/h";
                    ChangeBox3.Text = "600                                     110bpm                             1h30m";

                }
            }
        }
    }
}
