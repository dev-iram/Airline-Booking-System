using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cyanair_Airline_Booking_System
{
    public class FlightRoute
    {
        public string DepartureAirport_guid;
        public string DestinationAirport_guid;
        public string DepartAirportName;
        public string DestinAirportName;
        public bool thisflightisvalid;


        public bool _FLightValid { get { return thisflightisvalid; } set { thisflightisvalid = value; } }//property


        public string DateOfFlight;
        public string TimeOfFlight;
        public string Duration;
        public string FlightNo;
        public string SeatTypeBooked;

    }
}


