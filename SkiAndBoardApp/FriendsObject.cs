using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

public class FriendsObject {
    public FriendsObject() {
        friendList = new ObservableCollection<string>();
    }        

    public static ObservableCollection<string> friendList { get; set; }
}
