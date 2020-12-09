using HairForceOne.DesktopClient.Reusable;
using System;
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

        private void tabPage3_Click(object sender, System.EventArgs e)
        {

        }

        private void btnProducts_Click(object sender, System.EventArgs e)
        {
            tablessControl.SelectedIndex = 2;
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            populateItems();
        }

        private void populateItems()
        {
            var panel = allTimeBookings1.FlowLayoutListPanel;
           
            TimeBooking[] listItems = new TimeBooking[20];
            // Loop through each and set custom properties
            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new TimeBooking();
                //listItems[i].startTime = blah

                if (panel.Controls.Count < 0)
                {
                    panel.Controls.Clear();
                }
                else
                {
                    panel.Controls.Add(listItems[i]);
                }
            }


        }
    }
}