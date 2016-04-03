using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

public class TripObject {
    public TripObject() {
        tripList = new ObservableCollection<string>();
        tripList.Add("Test1");
        tripList.Add("Test2");
        tripList.Add("Test3");
    }

    public ObservableCollection<string> tripList { get; set; }
}
