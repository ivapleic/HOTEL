using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.classes_main
{
    public class Identification
    {
        public int ID { get; set; }  
        public string Name { get; set; }  

        public Identification(int id, string name, string indexKey)
        {
            ID = id;
            Name = name;
        }

        public Identification() { }
    }
}
