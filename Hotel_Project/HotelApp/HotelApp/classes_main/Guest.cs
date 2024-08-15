using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.classes_main
{
    internal class Guest
    {
        public int ID { get; set; }  
        public int CountryID { get; set; } 
        public int IdentificationID { get; set; } 
        public string Gender { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; }  
        public string OIB { get; set; }  
        public string Address { get; set; } 
        public string City { get; set; }  
        public string Phone { get; set; } 
        public string Mobile { get; set; }  
        public string Email { get; set; }  
        public DateTime BirthDate { get; set; } 
        public string BirthPlace { get; set; } 
        public int BirthStateID { get; set; } 
        public string Nationality { get; set; } 
        public string Description { get; set; } 

        public Guest(int id, int countryId, int identificationId, string identificationText, string gender,
                     string firstName, string lastName, string oib, string address, string city,
                     string phone, string mobile, string email, DateTime birthDate, string birthPlace,
                     int birthStateId, string nationality, string description)
        {
            ID = id;
            CountryID = countryId;
            IdentificationID = identificationId;
            Gender = gender;
            FirstName = firstName;
            LastName = lastName;
            OIB = oib;
            Address = address;
            City = city;
            Phone = phone;
            Mobile = mobile;
            Email = email;
            BirthDate = birthDate;
            BirthPlace = birthPlace;
            BirthStateID = birthStateId;
            Nationality = nationality;
            Description = description;
        }

        public Guest() { }
    }
}
