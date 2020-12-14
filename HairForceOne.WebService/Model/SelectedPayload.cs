using System;

namespace HairForceOne.WebService.Controllers
    // skal ændres til event måske? Det hedder den på desktop klient
{
    /// <summary>
    /// This class contains the properties for the SelectedPayload instance
    /// </summary>
    public class SelectedPayload
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