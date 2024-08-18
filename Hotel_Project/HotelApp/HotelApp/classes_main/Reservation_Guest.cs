using System;

namespace HotelApp.classes_main
{
    public class Reservation_Guest
    {
        public int ID { get; set; } 
        public int ReservationID { get; set; } 
        public int GuestID { get; set; } 
        public DateTime DateStart { get; set; } 
        public DateTime DateEnd { get; set; } 
        public bool IsAdditionalPerson { get; set; } 

        public Reservation_Guest() { }

        public Reservation_Guest(int id, int reservationId, int guestId, DateTime dateStart, DateTime dateEnd, bool isAdditionalPerson)
        {
            ID = id;
            ReservationID = reservationId;
            GuestID = guestId;
            DateStart = dateStart;
            DateEnd = dateEnd;
            IsAdditionalPerson = isAdditionalPerson;
        }
    }
}
