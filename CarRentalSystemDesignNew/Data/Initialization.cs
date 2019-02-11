using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalSystemDesignNew.Data
{
   public  class Initialization
    {
       public static List<Vehicles> list_vehicles = new List<Vehicles>();
       public static List<Bookings> list_booking = new List<Bookings>();

       public static List<Vehicles> LoadVehicleList()
       {
           list_vehicles.Add(new SUV("Toyota RAV4"));
           list_vehicles.Add(new SUV("Honda CR-V"));
           list_vehicles.Add(new Economy("Ford Fiesta"));
           list_vehicles.Add(new MidSizeSUV("Ford Fusion"));
           list_vehicles.Add(new MidSizeSUV("Honda Accord"));
           list_vehicles.Add(new MidSizeSUV("Toyota Camry"));
           list_vehicles.Add(new SUV("Toyota Camry1"));
           list_vehicles.Add(new MidSizeSUV("Toyota Camry2"));
           list_vehicles.Add(new MidSizeSUV("Toyota Camry3"));
           list_vehicles.Add(new SUV("Toyota Camry4"));
           list_vehicles.Add(new MidSizeSUV("Toyota Camry5"));
           list_vehicles.Add(new SUV("Toyota Camry6"));
           list_vehicles.Add(new MidSizeSUV("Toyota Camry7"));

           return list_vehicles;

       }

       public static List<Bookings> LoadBookingList(string CustFname, string CustLname, DateTime DOB, string Insurance, string Vname, DateTime FromDate,DateTime ToDate,double Total_Days,
         DateTime FromTime, DateTime ToTime, DateTime RentalDate, int VID,string PickUp, string DropOff)
       {
           list_booking.Add(new Bookings(new Customers(CustFname, CustLname, DOB, Insurance), Vname, FromDate, ToDate, Total_Days, FromTime, ToTime, PickUp, DropOff, VID, RentalDate));

           return list_booking;
       }
      
    }
}
