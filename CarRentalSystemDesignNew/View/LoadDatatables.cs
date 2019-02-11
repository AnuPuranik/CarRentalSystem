using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CarRentalSystemDesignNew.View
{
    public class LoadDatatables
    {
       static  DataTable dtreservations = new DataTable();
       static  DataTable dtVehicles = new DataTable();


        public static DataTable LoadVehilcesDataTable()
        {
            dtVehicles.Columns.AddRange(new DataColumn[9] { new DataColumn("Vehicle Type", typeof(string)),
                                                    new DataColumn("Vehicle Id", typeof(int)),
                                                    new DataColumn("Vehicle Name", typeof(string)),
                                                    new DataColumn("Total Cars Available", typeof(int)),
                                                    new DataColumn("Rate", typeof(double)),
                                                    new DataColumn("IsAvailable", typeof(Boolean)),
                                                    new DataColumn("Available Fuel", typeof(double)),
                                                    new DataColumn("Total No. Of Vehicles", typeof(int)),
                                                    new DataColumn("Seating Capacity", typeof(int))});

            return dtVehicles;
        
        }


        public static DataTable LoadReservationsDataTable()
        {
            dtreservations.Columns.AddRange(new DataColumn[15]{ new DataColumn("Vehicle Name", typeof(string)),
                                                                new DataColumn("Customer Fname", typeof(string)),
                                                                new DataColumn("Customer Lname", typeof(string)),
                                                                new DataColumn("From Date", typeof(DateTime)),
                                                               new DataColumn("To Date", typeof(DateTime)),
                                                               new DataColumn("From Time", typeof(DateTime)),
                                                              new DataColumn("To Time", typeof(DateTime)),
                                                              new DataColumn("Total Days", typeof(int)),
                                                              new DataColumn("Pick Up", typeof(string)),
                                                              new DataColumn("Drop Off", typeof(string)),
                                                               new DataColumn("Customer ID", typeof(int)),
                                                                new DataColumn("Vehicle Id", typeof(int)),
                                                               new DataColumn("Booking ID", typeof(int)),
                                                               new DataColumn("Insurance Number", typeof(string)),
                                                              new DataColumn("Rental Date", typeof(DateTime))  });
            return dtreservations; 
        }
    }
}
