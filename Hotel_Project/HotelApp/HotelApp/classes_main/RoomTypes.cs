using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.classes_main
{
    public class RoomTypes
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public int NumberOfPersons { get; set; }
        public int NumberOfChildren { get; set; }

        // Konstruktor bez parametara
        public RoomTypes()
        {
            
        }

        // Konstruktor s parametrima
        public RoomTypes(int roomTypeID, string roomTypeName, int numOfPersons, int numOfChildren)
        {
            this.ID = roomTypeID;
            this.Name = roomTypeName;
            this.NumberOfPersons = numOfPersons;
            this.NumberOfChildren= numOfChildren;

        }
    }
}
