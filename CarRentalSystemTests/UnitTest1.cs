using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRentalSystemDesignNew;
using System.Collections.Generic;
using CarRentalSystemDesignNew.Data;
using CarRentalSystemDesignNew.View;


namespace CarRentalSystemTests
{
    [TestClass]
    public class UnitTest1
    {
        public  List<Bookings> list_booking = new List<Bookings>();
       
        [TestMethod]
        public void ValidateBookings_SameDaySameTime_ReturnsFalse()
        {
          LoadListBooking();

            ErrorObject result = ValidateBookng.IsValid(list_booking,"1","02/09/2019","02/09/2019","10:00","11:00");
            Assert.IsFalse(result.GetIsValid());
        }

        [TestMethod]
        public void ValidateBookings_SameDayDifferentTime_ReturnsTrue()
        {
            LoadListBooking();

            ErrorObject result = ValidateBookng.IsValid(list_booking, "1", "02/09/2019", "02/09/2019", "11:30", "12:00");
            Assert.IsTrue(result.GetIsValid());
        }
        [TestMethod]
        public void ValidateBookings_DifferentDayDifferentTime_ReturnsTrue()
        {
            LoadListBooking();
            ErrorObject result = ValidateBookng.IsValid(list_booking, "1", "03/09/2019", "03/09/2019", "11:30", "12:00");
            Assert.IsTrue(result.GetIsValid());

        }

         [TestMethod]
        public void ValidateBookings_FromDateMoreThanToDate_ReturnsFalse()
        {
            LoadListBooking();
            ErrorObject result = ValidateBookng.IsValid(list_booking, "1", "02/09/2019", "01/09/2019", "10:00", "11:00");
            Assert.IsFalse(result.GetIsValid());
        }

         [TestMethod]
         public void ValidateBookings_FromTimeMoreThanToDate_ReturnsFalse()
         {
             LoadListBooking();

             ErrorObject result = ValidateBookng.IsValid(list_booking, "1", "02/09/2019", "02/09/2019", "11:00", "10:00");
             Assert.IsFalse(result.GetIsValid());
         }

         [TestMethod]
         public void ValidateBookings_SamefromDateDifferentTodate_FromTimeEqualsInitialBookingToTime_ReturnsFalse()
         {
             LoadListBooking();

             ErrorObject result = ValidateBookng.IsValid(list_booking, "1", "02/09/2019", "02/10/2019", "11:00", "12:00");
             Assert.IsFalse(result.GetIsValid());
         }

        public void LoadListBooking()
        {
            list_booking = Initialization.LoadBookingList("john", "tyler", Convert.ToDateTime("02/01/1988"), "123", "Toyota", Convert.ToDateTime("02/09/2019"), Convert.ToDateTime("02/09/2019"), 0, Convert.ToDateTime("10:00"), Convert.ToDateTime("11:00"), Convert.ToDateTime("02/09/2019"), 1, "Airport", "Midtown");
            list_booking = Initialization.LoadBookingList("Raj", "Khan", Convert.ToDateTime("02/01/1989"), "345", "Toyota SUV", Convert.ToDateTime("02/09/2019"), Convert.ToDateTime("02/09/2019"), 0, Convert.ToDateTime("10:00"), Convert.ToDateTime("11:00"), Convert.ToDateTime("02/09/2019"), 2, "Airport", "Midtown");
            list_booking = Initialization.LoadBookingList("Kevin", "tse", Convert.ToDateTime("02/01/1991"), "786", "Mid Size SUV", Convert.ToDateTime("02/09/2019"), Convert.ToDateTime("02/10/2019"), 0, Convert.ToDateTime("10:00"), Convert.ToDateTime("11:00"), Convert.ToDateTime("02/09/2019"), 3, "Airport", "Midtown");

        }
    }
}
