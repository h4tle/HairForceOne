using System;

// models??
namespace HairForceOne.WebService.Model
// skal måske slettes
{
    /// <summary>
    /// This class contains the properties for the Event instance
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Gets and sets the Duration
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Gets and sets the SelectedDate
        /// </summary>
        public DateTime SelectedDate { get; set; }

        /// <summary>
        /// Gets and sets the EmployeeId
        /// </summary>
        public int EmployeeId { get; set; }
    }
}