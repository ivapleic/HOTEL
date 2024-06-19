using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.classes_main
{
    public class RoomAccessory
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public RoomAccessory()
        {
            try
            {
                ID = -1;
                Name = string.Empty;
            }
            catch (Exception ex)
            {
                //catch exception
            }
        }
    }
}
