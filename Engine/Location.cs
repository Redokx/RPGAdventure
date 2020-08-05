using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        //properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //constructor
        public Location(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }
    }
}
