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
    public partial class FriendPage : Page {
        public FriendPage() {
            InitializeComponent();
            DataContext = globalFriendObject.friends;
            if (curTripObject.curTrip != null) {
                string[] split = curTripObject.curTrip.Split('-');
                if (split[0] == "Sunshine ") {
                    Console.WriteLine("Sunshine");
                } else if (split[0] == "Canada Olympic Park ") {
                    Console.WriteLine("COP");
                    TrailMap.Source = new BitmapImage(new Uri("trail-map_canada-olympic-park-calgary_n4805-21377-0_raw.jpg", UriKind.Relative));
                }
            }
        }

        private void FriendFinderList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            foreach (String i in FriendFinderList.SelectedItems) {
                RayceLoc.Visibility = System.Windows.Visibility.Hidden;
                LaVerneLoc.Visibility = System.Windows.Visibility.Hidden;
                CurrieLoc.Visibility = System.Windows.Visibility.Hidden;
                if (i == "Rayce Rossum") {
                    RayceLoc.Visibility = System.Windows.Visibility.Visible;
                } else if (i == "LaVerne Woroschuk") {
                    LaVerneLoc.Visibility = System.Windows.Visibility.Visible;
                } else if (i == "David Currie") {
                    CurrieLoc.Visibility = System.Windows.Visibility.Visible;
                }
            }
        }
    }
}