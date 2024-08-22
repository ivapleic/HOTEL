using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.classes_main
{
    public class Reservation_Service
    {
        public int ID { get; set; }              
        public int ReservationID { get; set; }  
        public int ServiceID { get; set; }       
        public int Quantity { get; set; }       
        public DateTime DateReservation { get; set; }  
        public DateTime DateConsumption { get; set; }  

        public Reservation_Service()
        {
        }

        public Reservation_Service(int id, int reservationID, int serviceID, int quantity, DateTime dateReservation, DateTime dateConsumption)
        {
            ID = id;
            ReservationID = reservationID;
            ServiceID = serviceID;
            Quantity = quantity;
            DateReservation = dateReservation;
            DateConsumption = dateConsumption;
        }
    }
}
