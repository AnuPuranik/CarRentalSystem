using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRentalSystemDesignNew;
using System.Collections.Generic;


namespace CarRentalSystem.UnitTests
{
    [TestClass]
    public class UnitTest1 
    {
        List<Bookings> list_Bookings = new List<Bookings>();



        [TestMethod]
        public void TestMethod1()
        {
            AddtoBookingsList();

            var Check = new CarRentalSystemDesignNew.Validations();


            var result = Check.IsValid();
        }


        public void AddtoBookingsList()
        {
            list_Bookings.Add(new Bookings(new Customers("Daisy", "Tse", Convert.ToDateTime("01/01/2000"), "12345"), "Toyota", Convert.ToDateTime("02/09/2019"), Convert.ToDateTime("02/10/2019"), 1, Convert.ToDateTime("10:00 AM"), Convert.ToDateTime("11:00 AM"), "Airport", "Airport", 1, Convert.ToDateTime("02/09/2019")));
            list_Bookings.Add(new Bookings(new Customers("John", "Doe", Convert.ToDateTime("01/02/2000"), "53426"), "SUV", Convert.ToDateTime("01/01/2019"), Convert.ToDateTime("03/01/2019"), 2, Convert.ToDateTime("10:00 AM"), Convert.ToDateTime("11:00 AM"), "Midtown", "Midtown", 2, Convert.ToDateTime("01/01/2019")));
            list_Bookings.Add(new Bookings(new Customers("kevin", "Campbell", Convert.ToDateTime("02/03/1989"), "65437"), "SUV", Convert.ToDateTime("01/01/2019"), Convert.ToDateTime("02/01/2019"), 3, Convert.ToDateTime("09:00 AM"), Convert.ToDateTime("10:00 pM"), "Midtown", "Midtown", 1, Convert.ToDateTime("02/01/2019")));

        }
    }
}
