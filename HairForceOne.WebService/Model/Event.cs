using System;
// models??
namespace HairForceOne.WebService.Models
    // skal måske slettes
{
    /// <summary>
    /// This class contains the properties for the Event instance
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Gets and sets the Employee
        /// </summary>
        public Employee employee { get; set; }

        /// <summary>
        /// Gets and sets the SelectedDate
        /// </summary>
        public DateTime SelectedDate { get; set; }

        /// <summary>
        /// Gets and sets the Duration
        /// </summary>
        public int Duration { get; set; }
    }
}