using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

public class TripObject {
    public TripObject() {
        tripList = new ObservableCollection<string>();
        tripList.Add("Canada Olympic Park - 3/10/2016");
        tripList.Add("Sunshine - 1/15/2016");
    }

    public ObservableCollection<string> tripList { get; set; }
}
