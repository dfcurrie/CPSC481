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

                }
            }
            

        }
    }
}
