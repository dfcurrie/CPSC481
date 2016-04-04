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
    public partial class StatisticsPage : Page {
        public StatisticsPage() {
            InitializeComponent();

            Friend1_pic.Visibility = System.Windows.Visibility.Visible;
            Friend1_numRuns.Visibility = System.Windows.Visibility.Visible;
            Friend1_dist.Visibility = System.Windows.Visibility.Visible;
            Friend1_airTime.Visibility = System.Windows.Visibility.Visible;
            Friend1_elev.Visibility = System.Windows.Visibility.Visible;
            Friend1_vertical.Visibility = System.Windows.Visibility.Visible;
            Friend1_maxSpeed.Visibility = System.Windows.Visibility.Visible;
            Friend1_cal.Visibility = System.Windows.Visibility.Visible;
            Friend1_avgHR.Visibility = System.Windows.Visibility.Visible;
            Friend1_time.Visibility = System.Windows.Visibility.Visible;

            Friend2_pic.Visibility = System.Windows.Visibility.Hidden;
            Friend2_numRuns.Visibility = System.Windows.Visibility.Hidden;
            Friend2_dist.Visibility = System.Windows.Visibility.Hidden;
            Friend2_airTime.Visibility = System.Windows.Visibility.Hidden;
            Friend2_elev.Visibility = System.Windows.Visibility.Hidden;
            Friend2_vertical.Visibility = System.Windows.Visibility.Hidden;
            Friend2_maxSpeed.Visibility = System.Windows.Visibility.Hidden;
            Friend2_cal.Visibility = System.Windows.Visibility.Hidden;
            Friend2_avgHR.Visibility = System.Windows.Visibility.Hidden;
            Friend2_time.Visibility = System.Windows.Visibility.Hidden;

            Friend3_pic.Visibility = System.Windows.Visibility.Hidden;
            Friend3_numRuns.Visibility = System.Windows.Visibility.Hidden;
            Friend3_dist.Visibility = System.Windows.Visibility.Hidden;
            Friend3_airTime.Visibility = System.Windows.Visibility.Hidden;
            Friend3_elev.Visibility = System.Windows.Visibility.Hidden;
            Friend3_vertical.Visibility = System.Windows.Visibility.Hidden;
            Friend3_maxSpeed.Visibility = System.Windows.Visibility.Hidden;
            Friend3_cal.Visibility = System.Windows.Visibility.Hidden;
            Friend3_avgHR.Visibility = System.Windows.Visibility.Hidden;
            Friend3_time.Visibility = System.Windows.Visibility.Hidden;

        }

     
        private void Friend1_Selected(object sender, RoutedEventArgs e)
        {
            Friend1_pic.Visibility = System.Windows.Visibility.Visible;
            Friend1_numRuns.Visibility = System.Windows.Visibility.Visible;
            Friend1_dist.Visibility = System.Windows.Visibility.Visible;
            Friend1_airTime.Visibility = System.Windows.Visibility.Visible;
            Friend1_elev.Visibility = System.Windows.Visibility.Visible;
            Friend1_vertical.Visibility = System.Windows.Visibility.Visible;
            Friend1_maxSpeed.Visibility = System.Windows.Visibility.Visible;
            Friend1_cal.Visibility = System.Windows.Visibility.Visible;
            Friend1_avgHR.Visibility = System.Windows.Visibility.Visible;
            Friend1_time.Visibility = System.Windows.Visibility.Visible;

            Friend2_pic.Visibility = System.Windows.Visibility.Hidden;
            Friend2_numRuns.Visibility = System.Windows.Visibility.Hidden;
            Friend2_dist.Visibility = System.Windows.Visibility.Hidden;
            Friend2_airTime.Visibility = System.Windows.Visibility.Hidden;
            Friend2_elev.Visibility = System.Windows.Visibility.Hidden;
            Friend2_vertical.Visibility = System.Windows.Visibility.Hidden;
            Friend2_maxSpeed.Visibility = System.Windows.Visibility.Hidden;
            Friend2_cal.Visibility = System.Windows.Visibility.Hidden;
            Friend2_avgHR.Visibility = System.Windows.Visibility.Hidden;
            Friend2_time.Visibility = System.Windows.Visibility.Hidden;

            Friend3_pic.Visibility = System.Windows.Visibility.Hidden;
            Friend3_numRuns.Visibility = System.Windows.Visibility.Hidden;
            Friend3_dist.Visibility = System.Windows.Visibility.Hidden;
            Friend3_airTime.Visibility = System.Windows.Visibility.Hidden;
            Friend3_elev.Visibility = System.Windows.Visibility.Hidden;
            Friend3_vertical.Visibility = System.Windows.Visibility.Hidden;
            Friend3_maxSpeed.Visibility = System.Windows.Visibility.Hidden;
            Friend3_cal.Visibility = System.Windows.Visibility.Hidden;
            Friend3_avgHR.Visibility = System.Windows.Visibility.Hidden;
            Friend3_time.Visibility = System.Windows.Visibility.Hidden;
        }

        private void Friend2_Selected(object sender, RoutedEventArgs e)
        {
            Friend2_pic.Visibility = System.Windows.Visibility.Visible;
            Friend2_numRuns.Visibility = System.Windows.Visibility.Visible;
            Friend2_dist.Visibility = System.Windows.Visibility.Visible;
            Friend2_airTime.Visibility = System.Windows.Visibility.Visible;
            Friend2_elev.Visibility = System.Windows.Visibility.Visible;
            Friend2_vertical.Visibility = System.Windows.Visibility.Visible;
            Friend2_maxSpeed.Visibility = System.Windows.Visibility.Visible;
            Friend2_cal.Visibility = System.Windows.Visibility.Visible;
            Friend2_avgHR.Visibility = System.Windows.Visibility.Visible;
            Friend2_time.Visibility = System.Windows.Visibility.Visible;

            Friend1_pic.Visibility = System.Windows.Visibility.Hidden;
            Friend1_numRuns.Visibility = System.Windows.Visibility.Hidden;
            Friend1_dist.Visibility = System.Windows.Visibility.Hidden;
            Friend1_airTime.Visibility = System.Windows.Visibility.Hidden;
            Friend1_elev.Visibility = System.Windows.Visibility.Hidden;
            Friend1_vertical.Visibility = System.Windows.Visibility.Hidden;
            Friend1_maxSpeed.Visibility = System.Windows.Visibility.Hidden;
            Friend1_cal.Visibility = System.Windows.Visibility.Hidden;
            Friend1_avgHR.Visibility = System.Windows.Visibility.Hidden;
            Friend1_time.Visibility = System.Windows.Visibility.Hidden;

            Friend3_pic.Visibility = System.Windows.Visibility.Hidden;
            Friend3_numRuns.Visibility = System.Windows.Visibility.Hidden;
            Friend3_dist.Visibility = System.Windows.Visibility.Hidden;
            Friend3_airTime.Visibility = System.Windows.Visibility.Hidden;
            Friend3_elev.Visibility = System.Windows.Visibility.Hidden;
            Friend3_vertical.Visibility = System.Windows.Visibility.Hidden;
            Friend3_maxSpeed.Visibility = System.Windows.Visibility.Hidden;
            Friend3_cal.Visibility = System.Windows.Visibility.Hidden;
            Friend3_avgHR.Visibility = System.Windows.Visibility.Hidden;
            Friend3_time.Visibility = System.Windows.Visibility.Hidden;
        }

        private void Friend3_Selected(object sender, RoutedEventArgs e)
        {
            Friend3_pic.Visibility = System.Windows.Visibility.Visible;
            Friend3_numRuns.Visibility = System.Windows.Visibility.Visible;
            Friend3_dist.Visibility = System.Windows.Visibility.Visible;
            Friend3_airTime.Visibility = System.Windows.Visibility.Visible;
            Friend3_elev.Visibility = System.Windows.Visibility.Visible;
            Friend3_vertical.Visibility = System.Windows.Visibility.Visible;
            Friend3_maxSpeed.Visibility = System.Windows.Visibility.Visible;
            Friend3_cal.Visibility = System.Windows.Visibility.Visible;
            Friend3_avgHR.Visibility = System.Windows.Visibility.Visible;
            Friend3_time.Visibility = System.Windows.Visibility.Visible;

            Friend1_pic.Visibility = System.Windows.Visibility.Hidden;
            Friend1_numRuns.Visibility = System.Windows.Visibility.Hidden;
            Friend1_dist.Visibility = System.Windows.Visibility.Hidden;
            Friend1_airTime.Visibility = System.Windows.Visibility.Hidden;
            Friend1_elev.Visibility = System.Windows.Visibility.Hidden;
            Friend1_vertical.Visibility = System.Windows.Visibility.Hidden;
            Friend1_maxSpeed.Visibility = System.Windows.Visibility.Hidden;
            Friend1_cal.Visibility = System.Windows.Visibility.Hidden;
            Friend1_avgHR.Visibility = System.Windows.Visibility.Hidden;
            Friend1_time.Visibility = System.Windows.Visibility.Hidden;

            Friend2_pic.Visibility = System.Windows.Visibility.Hidden;
            Friend2_numRuns.Visibility = System.Windows.Visibility.Hidden;
            Friend2_dist.Visibility = System.Windows.Visibility.Hidden;
            Friend2_airTime.Visibility = System.Windows.Visibility.Hidden;
            Friend2_elev.Visibility = System.Windows.Visibility.Hidden;
            Friend2_vertical.Visibility = System.Windows.Visibility.Hidden;
            Friend2_maxSpeed.Visibility = System.Windows.Visibility.Hidden;
            Friend2_cal.Visibility = System.Windows.Visibility.Hidden;
            Friend2_avgHR.Visibility = System.Windows.Visibility.Hidden;
            Friend2_time.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
