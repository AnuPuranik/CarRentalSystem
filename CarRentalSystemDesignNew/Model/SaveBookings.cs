using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CarRentalSystemDesignNew.View;
using CarRentalSystemDesignNew.Model;
using CarRentalSystemDesignNew.Data;

namespace CarRentalSystemDesignNew.Model
{
   public  class SaveBookings
    {
       public static List<Bookings> list_result = new List<Bookings>();
        static string CustFname, CustLname, PickUp, DropOff, Vname = string.Empty, Insurance, PhoneNumber;
       static  int VID;
       static double Total_Days;
       static DateTime FromDate = DateTime.Now, ToDate = DateTime.Now, RentalDate = DateTime.Now, FromTime = DateTime.Now, ToTime = DateTime.Now, DOB = DateTime.Now;


       public static List<Bookings> Save(string lblCustFname, string lblCustLname, string Fromdtpicker, string Todatepicker, string FromTimepicker, string ToTimepicker,
           string Rentaldatepicker, string cmb1, string cmb2, string lblVname, string VId, string Insur, string DOBdtpicker, string Phno)
       {




           CustFname = string.IsNullOrEmpty(lblCustFname) ? "" : lblCustFname;
           CustLname = string.IsNullOrEmpty(lblCustLname) ? "" : lblCustLname;

           if (!string.IsNullOrEmpty(Fromdtpicker))
           {
               FromDate = Convert.ToDateTime(Fromdtpicker);
           }

           if (!string.IsNullOrEmpty(Todatepicker))
           {
               ToDate = Convert.ToDateTime(Todatepicker);
           }
           if (!string.IsNullOrEmpty(Rentaldatepicker))
           {
               RentalDate = Convert.ToDateTime(Rentaldatepicker);
           }

           if (!string.IsNullOrEmpty(ToTimepicker))
           {
               FromTime = Convert.ToDateTime(ToTimepicker);
           }
           if (!string.IsNullOrEmpty(ToTimepicker))
           {
               ToTime = Convert.ToDateTime(ToTimepicker);
           }

           Total_Days = (ToDate - FromDate).TotalDays;
           PickUp = string.IsNullOrEmpty(cmb1) ? "" : cmb1;
           DropOff = string.IsNullOrEmpty(cmb2) ? "" : cmb2;
           Vname = string.IsNullOrEmpty(lblVname) ? "" : lblVname;
           VID = string.IsNullOrEmpty(VId) ? 0 : Convert.ToInt32(VId);
           Insurance = string.IsNullOrEmpty(Insur) ? "" : Insur;
           if (!string.IsNullOrEmpty(DOBdtpicker))
           {
               DOB = Convert.ToDateTime(DOBdtpicker);
           }
           PhoneNumber = string.IsNullOrEmpty(Phno) ? "" : Phno;
          list_result= LoadReservationList();

          return list_result;
       }
       
       public static  List<Bookings> LoadReservationList()
       {
           
          list_result= Initialization.LoadBookingList(CustFname, CustLname, DOB, Insurance, Vname, FromDate,ToDate,Total_Days,Convert.ToDateTime(FromTime.ToString("HH:mm")),Convert.ToDateTime(ToTime.ToString("HH:mm")),RentalDate,VID,PickUp,DropOff);
          return list_result;
           
       }


    }
}
