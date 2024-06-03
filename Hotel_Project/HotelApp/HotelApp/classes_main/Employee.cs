using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.classes_main
{
    public class Employee
    {
        public int ID { get; set; }
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OIB { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public DateTime? Work_Start { get; set; }
        public DateTime? Work_End { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }

        public Employee()
        {
            ID = -1;
            Gender = "";
            FirstName = "";
            LastName = "";
            OIB = "";
            PhoneNumber = "";
            Email = "";
            DateOfBirth = null;
            Address = "";
            City = "";
            CountryID = -1;
            CountryName = "";
            Work_Start = null;
            Work_End = null;
            Password = "";
            IsAdmin = false;
            IsActive = true;
            Description = "";

        }
    }

}
