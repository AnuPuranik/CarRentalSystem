using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalSystemDesignNew
{
    // Bookings class contain reservation details and it auto generates Booking ID
   public class Bookings
    {
        public Customers c1;
        public string VehicleName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public string Pickup { get; set; }
        public string DropOff { get; set; }
        public int BID { get; set; }
        public int VID { get; set; }
        public double TotalDays { get; set; }
        private static int count = 100;

        // Constructor
        public Bookings(Customers c1, string VehicleName, DateTime FromDate, DateTime ToDate, double TotalDays, DateTime FromTime, DateTime ToTime, string Pickup, string DropOff, int VID, DateTime RentalDate)
        {
            this.c1 = c1;
            this.VehicleName = VehicleName;
            this.FromDate = FromDate;
            this.ToDate = ToDate;
            this.TotalDays = TotalDays;
            this.FromTime = FromTime;
            this.ToTime = ToTime;
            this.Pickup = Pickup;
            this.DropOff = DropOff;
            this.BID = GenerateBookingID();
            this.VID = VID;
            this.RentalDate = RentalDate;
        }
        private static int GenerateBookingID()
        {
            return count++;
        }

    }
}
