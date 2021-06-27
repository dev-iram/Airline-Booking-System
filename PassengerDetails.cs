using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyanair_Airline_Booking_System
{
    public class PassengerDetails : Person 
    {
        //Inheriting Person class
        public Person PersonDetails;

        //Attributes declarations
        private string PassportNumber;
        private string Nationality;

        public string passportnumber { get { return PassportNumber; } set { PassportNumber = value; } }//property

        public string nationality { get { return Nationality; } set { Nationality = value; } }//property


    }
}
