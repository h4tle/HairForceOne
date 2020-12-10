using System;

namespace HairForceOne.WinFormsDesktopClient.Model
{
    public class Event
    {
        public DateTime SelectedDate { get; set; }
        public int Duration { get; set; }
        public Employee Employee { get; set; }

        public Event(DateTime selectedDate, int duration, Employee employee)
        {
            this.SelectedDate = selectedDate;
            this.Duration = duration;
            this.Employee = employee;
        }
    }
}