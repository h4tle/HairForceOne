using System.Windows.Forms;

namespace HairForceOne.DesktopClient
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void btnScheduleOverview(object sender, System.EventArgs e)
        {

        }

        private void btnEmployeesOverview(object sender, System.EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitAllTimeBookings_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void allTimeBookings1_Load(object sender, System.EventArgs e)
        {

        }

        private void btnShowAllTimeBookings_Click(object sender, System.EventArgs e)
        {
            tablessControl.SelectedIndex = 0;
        }

        private void btnServices_Click(object sender, System.EventArgs e)
        {
            tablessControl.SelectedIndex = 1;
        }
    }
}