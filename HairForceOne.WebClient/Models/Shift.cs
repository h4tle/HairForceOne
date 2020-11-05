using System;
using System.Collections.Generic;
using System.Text;

namespace HairForceOne.WebClient.Models
{
    public class Shift
    {
        public TimeSpan StartTime { get; set; } 
        public TimeSpan EndTime { get; set; }
        public DateTime Day { get; set; } // in case of specific day
        public List<Break> Breaks { get; set; }
        public TimeSpan Duration //should still work with timespan? Changed starttime endtime from DateTime > TimeSpan
        {
            get
            {
                return new TimeSpan(EndTime.Ticks - StartTime.Ticks);
            }
        }

        public Shift(DateTime start, DateTime end)
        {
            StartTime = StartTime;
            EndTime = EndTime;
        }
    }


}

