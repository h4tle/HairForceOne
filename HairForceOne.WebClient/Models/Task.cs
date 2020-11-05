using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HairForceOne.WebClient.Models
{
    public class Task
    {
        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            private set
            {
                int limit = 50;
                if (!string.IsNullOrEmpty(value))
                {
                    _description = value;
                    if (value.Length > limit)
                    {
                        _description = value.Substring(0, limit);
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public TimeSpan TaskDuration { get; set; }

        public double CostOfService { get; set; }

        public Task(string description, int durationInMinutes)
        {
            Description = description;
            TaskDuration = new TimeSpan(hours: 0, minutes: durationInMinutes, seconds: 0);
        }

        public Task(string description, int durationInMinutes, double costOfService) : this(description, durationInMinutes)
        {
            CostOfService = costOfService;
        }

        public void Describe() 
        {
            Console.WriteLine("Task: " + Description + "\nDuration: " + TaskDuration + "\nPrice: " + CostOfService + "\n");
        }
    }
}
