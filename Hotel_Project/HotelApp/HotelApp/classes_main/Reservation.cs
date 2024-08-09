using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.classes_main
{
    public class Reservation
    {
            public int ID { get; set; }                       
            public int EmployeeID { get; set; }               
            public int RoomID { get; set; }                   
            public int TariffTypeID { get; set; }            
            public int ReservationStatusID { get; set; }      
            public int Number { get; set; }                      
            public DateTime ReservationDate { get; set; }     
            public DateTime StartDate { get; set; }           
            public DateTime EndDate { get; set; }             
            public DateTime? CheckInDate { get; set; }        
            public DateTime? CheckOutDate { get; set; }       
            public string Description { get; set; }          
     
    }
}
