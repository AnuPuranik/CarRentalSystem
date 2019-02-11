using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using CarRentalSystemDesignNew.Model;
using CarRentalSystemDesignNew.Data;


namespace CarRentalSystemDesignNew.View
{
   public  class ReturnDataTables
    {
      

       public static DataTable Vehicles_DataTable(List<Vehicles> list_vehicles, DataTable dtvehicles)
       {
           dtvehicles.Rows.Clear();
           foreach (var item in list_vehicles)
           {
               dtvehicles.Rows.Add(item.GetType().Name, item.GetVehicleID(), item.VehicleName, item.GetVehicleCount(), item.CalculateRates(), item.GetIsAvailable(), 1.00, item.GetTotalVehicleCount(), item.GetSeatingCapacity());
           }
           return dtvehicles;
       }

       public static DataTable Reservations_DataTable(List<Bookings> list_Bookings, DataTable dtreservation)
       {
           dtreservation.Rows.Clear();
           foreach (var value in list_Bookings)
           {
               dtreservation.Rows.Add(value.VehicleName,
                   value.c1.CustomerFname,
                   value.c1.CustomerLname,
                   value.FromDate,
                   value.ToDate,
                   value.FromTime,
                   value.ToTime,
                   value.TotalDays,
                   value.Pickup,
                   value.DropOff,
                   value.c1.CID,
                    value.VID,
                    value.BID,
                    value.c1.InsuranceNumber,
                    value.RentalDate);

           }


           return dtreservation;
       }
    }
}
