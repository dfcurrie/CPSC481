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
    public partial class AddFriend : Page {
        Window mainWindow;
        public AddFriend() {
            InitializeComponent();
            this.mainWindow = Application.Current.MainWindow;
            DataContext = globalFriendObject.friends;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            var friendObject = DataContext as FriendsObject;
            foreach (ListBoxItem i in Friends.SelectedItems) {
                char[] splitChars = { ':' };
                String[] tripStr = i.ToString().Split(splitChars);
                String str = tripStr[1].Substring(1);
                if (!FriendsObject.friendList.Contains(str)) {
                    FriendsObject.friendList.Add(str);
                    Console.WriteLine(str);
                }
            }
            SyncBtn.Content = "Synced";
        }
    }
}
