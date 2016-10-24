using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warframe_Custom_Class
{
    class Warframe
    { // Create the data types for each warframe, Name, Health, Shield, Armor, Energy pool and 4 abilities
        private int ID { get; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Shield { get; set; }
        public int Armor { get; set; }
        public int Energy { get; set; }
        public string Ability1 { get; set; }
        public string Ability2 { get; set; }
        public string Ability3 { get; set; }
        public string Ability4 { get; set; }
    }
}
