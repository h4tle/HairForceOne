using System;
using System.Collections.Generic;

namespace HairForceOne.WebService.Model
{
    /// <summary>
    /// This class contains the properties for the Booking instance
    /// </summary>
    public class Booking
    {
        /// <summary>
        /// Gets and sets the BookingId for the Booking instance
        /// </summary>
        public int BookingId { get; set; }

        /// <summary>
        /// Gets and sets the TotalPrice in DKK for the Booking instance
        /// </summary>
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// Gets and sets the EmployeeId for the Booking instance
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets and sets the UserId for the Booking instance
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets and sets the Comment for the Booking instance
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets and sets the StartTime as DateTime for the Booking instance
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets and sets the Duration in minuts for the Booking instance
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Gets and sets the CreatedAt as DateTime for the Booking instance
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets and sets the IsDone as boolean for the Booking instance
        /// </summary>
        public bool IsDone { get; set; }

        /// <summary>
        /// Gets and sets the Products list for the Booking instance
        /// </summary>
        public List<Product> Products { get; set; }

        /// <summary>
        /// Gets and sets the Services list for the Booking instance
        /// </summary>
        public List<Service> Services { get; set; }

        public Booking(int BookingId_, decimal TotalPrice_, int EmployeeId_, int UserId_, string Comment_, DateTime StartTime_, int Duration_, DateTime CreatedAt_, bool IsDone_)
        {
            this.BookingId = BookingId_;
            this.TotalPrice = TotalPrice_;
            this.EmployeeId = EmployeeId_;
            this.UserId = UserId_;
            this.Comment = Comment_;
            this.StartTime = StartTime_;
            this.Duration = Duration_;
            this.CreatedAt = CreatedAt_;
            this.IsDone = IsDone_;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Booking"/>
        /// </summary>
        public Booking()
        {
        }
    }
}