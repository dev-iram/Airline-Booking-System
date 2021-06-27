using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyanair_Airline_Booking_System
{
    public class Bookings : PassengerDetails
    {
        public string BookingReference = "";
        public DateTime DateOfBooking;

        //Inheriting PassengerDetails Class
        //public PassengerDetails PassengerDetails;



        public string CreateNewBookingReference()

        {

            //This generates the day the booking was booked !!! 
            var dateAndTime = DateTime.Now;
            int year = dateAndTime.Year;
            int month = dateAndTime.Month;
            int day = dateAndTime.Day;

            //CY01012020-00000 FORMAT OF BOOKING REF ! 
            System.Random rand = new System.Random((int)System.DateTime.Now.Ticks);
            int random = rand.Next(1, 1000000);
            this.BookingReference = random.ToString();
            BookingReference =  "CY" + day + month + year + "-" + BookingReference;

            return BookingReference;
        }
    }
}
