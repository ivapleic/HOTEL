using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.classes_main
{
    public class RoomType_SeasonalPrices
    {
        public int ID { get; set; }
        public int RoomTypeID { get; set; }
        public int SeasonalPeriodID { get; set; }
        public decimal Price { get; set; }

        public RoomType_SeasonalPrices(int id, int roomTypeID, int seasonalPeriodID, decimal price)
        {
            ID = id;
            RoomTypeID = roomTypeID;
            SeasonalPeriodID = seasonalPeriodID;
            Price = price;
        }
    }
}
