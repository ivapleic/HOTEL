using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.classes_main
{
    public class Floor
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }

        public Floor()
        {
            try
            {
                ID = -1;
                Number = 0;
                Description = string.Empty;
            }
            catch (Exception ex)
            {
                //Handle exception
            }
        }
    }


}
