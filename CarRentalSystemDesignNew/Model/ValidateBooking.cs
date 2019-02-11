using CarRentalSystemDesignNew.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarRentalSystemDesignNew
{
    public class ValidateBookng

    {


        public static ErrorObject IsValid(List<Bookings> list_bookings,string VehicleID, string FromDate, string ToDate, string FromTime, string ToTime)
        {
            if (Convert.ToDateTime(ToDate) < Convert.ToDateTime(FromDate))
            {
                return new ErrorObject(false, "To Date Cannot Be Less than From Date");
                //MessageBox.Show(" To Date Cannot Be Less than From Date");
                //return false;
            }

            if (Convert.ToDateTime(ToTime) < Convert.ToDateTime(FromTime))
            {
                return new ErrorObject(false, "To Time Cannot Be Less than From Time");
                //MessageBox.Show("To Time Cannot Be Less than From Time");
                //return false;
            }



            foreach (var value in list_bookings)
            {
                if ((value.VID == Convert.ToInt32(VehicleID)))
                {
                    //Vehicle is in Booking List
                    if ((value.FromDate == Convert.ToDateTime(FromDate)))
                    {
                        if ((value.ToDate == Convert.ToDateTime(ToDate)))
                        {
                            if ((value.FromTime == Convert.ToDateTime(FromTime)) && (value.ToTime == Convert.ToDateTime(ToTime)) ||
                            (value.FromTime < Convert.ToDateTime(FromTime)) && value.ToTime > Convert.ToDateTime(ToTime))
                            {
                                // display error

                                return new ErrorObject(false, "Selected car Cannot be Reserved for given time. It is already booked.");
                                //MessageBox.Show("Selected car Cannot be Reserved for given time. It is already booked.");
                                //return false;
                            }

                        }
                        else
                        {
                              if(Convert.ToDateTime(FromTime) <= value.ToTime)
                              {
                                  return new ErrorObject(false, "Please select different FromTime");

                                  //MessageBox.Show("Please select different FromTime");
                                  //return false;

                              }
                        }
                        

                    }

                    if((value.FromDate== Convert.ToDateTime(FromDate)) && (value.ToDate > Convert.ToDateTime(ToDate)))
                    {
                        return new ErrorObject(false, "Selected car Cannot be Reserved for given dates. It is already booked.");

                        //MessageBox.Show("Selected car Cannot be Reserved for given dates. It is already booked.");
                        //return false;
                    }
                }
                
            }

            return new ErrorObject(true, "Reservation is Booked Successfully.");
        }
    }

}
