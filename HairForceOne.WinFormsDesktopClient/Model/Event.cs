using System;

namespace HairForceOne.WinFormsDesktopClient.Model
{
    public class Event
    {
        public DateTime SelectedDate { get; set; }
        public int Duration { get; set; }
        public int EmployeeId { get; set; }

        public Event(DateTime selectedDate, int duration, int employeeId)
        {
            this.SelectedDate = selectedDate;
            this.Duration = duration;
            this.EmployeeId = employeeId;
        }
    }
}