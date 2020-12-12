using System;

namespace HairForceOne.WebService.Models
{
    /// <summary>
    /// This class contains the properties for the Booking instance
    /// </summary>
    public class Booking
    {
        /// <summary>
        /// Gets and sets the BookingId
        /// </summary>
        public int BookingId { get; set; }

        /// <summary>
        /// Gets and sets the StartTime
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets and sets the EndTime
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Gets and sets the TotalPrice
        /// </summary>
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// Gets and sets the UserId
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets and sets the EmployeeId
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets and sets the ProductId
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets and sets the ServiceId
        /// </summary>
        public int ServiceId { get; set; }

        /// <summary>
        /// Gets and sets the Comment
        /// </summary>
        public string Comment { get; set; }

        public Booking(int BookingId_, DateTime StartTime_, DateTime EndTime_, decimal TotalPrice_, int UserId_, int EmployeeId_, int ProductId_, int ServiceId_, string Comment_)
        {
            this.BookingId = BookingId_;
            this.StartTime = StartTime_;
            this.EndTime = EndTime_;
            this.TotalPrice = TotalPrice_;
            this.UserId = UserId_;
            this.EmployeeId = EmployeeId_;
            this.ProductId = ProductId_;
            this.ServiceId = ServiceId_;
            this.Comment = Comment_;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Booking"/>
        /// </summary>
        public Booking()
        {
        }
    }
}