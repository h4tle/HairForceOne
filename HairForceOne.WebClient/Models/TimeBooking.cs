using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HairForceOne.WebClient.Models
{
    public class TimeBooking
    {
        public DateTime StartTime { get; set; }

        public Customer Customer { get; set; }

        public Employee Employee { get; set; }

        public DateTime EndTime
        {
            get
            {
                //return StartTime.Add(Duration);
                return StartTime.Add(Duration);
            }
        }
        public List<Task> Tasks { get; set; }
        public TimeSpan Duration // gets duration based on tasks in timebooking
        {
            get
            {
                TimeSpan tempTime = new TimeSpan(0, 0, 0);
                foreach (Task t in Tasks)
                {
                    tempTime = tempTime.Add(t.TaskDuration);
                }
                return tempTime;
            }
        }

        public TimeBooking()
        {
            StartTime = new DateTime(year: 2020, month: 11, day: 21, hour: 16, minute: 0, second: 0); // should be parameter
            Tasks = new List<Task>();
        }

        public void addTask(Task t)
        {
            Tasks.Add(t);
        }

        public void describe()
        {
            Console.WriteLine("TimeBooking:");
            Console.WriteLine("Start: " + StartTime);
            Console.WriteLine("Duration of tasks: " + Duration);
            Console.WriteLine("End time: " + EndTime + "\n");

            foreach (var task in Tasks)
            {
                task.Describe();
            }

            Console.WriteLine("__________________________________________________");
        }


    }
}
