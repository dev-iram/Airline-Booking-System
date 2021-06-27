using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyanair_Airline_Booking_System
{
    public class Person
    {
        private string FullName;
        private string PhoneNumber;
        private string EmailAddress;
        private string Gender;

        public string fullname { get { return FullName; } set { FullName = value; } }//property

        public string phonenumber { get { return PhoneNumber; } set { PhoneNumber = value; } }//property

        public string emailaddress { get { return EmailAddress; } set { EmailAddress = value; } }//property

        public string gender { get { return Gender; } set { Gender = value; } }//property

    }
}
