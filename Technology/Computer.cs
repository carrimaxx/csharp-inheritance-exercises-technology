using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public abstract class Computer : AbstractEntity
    {
        // TODO : Add 3 fields, 2 methods, one constructor
        public int RamInGb { get; set; }
        public int CapacityInGb { get; set; } 
        public string Manufacturer { get; set; } 
        public bool Upgradeable { get; set; }

        public Computer(int ram, int capacity, string manufacturer)
        {
            RamInGb = ram;
            CapacityInGb = capacity;
            Manufacturer = manufacturer;
            ID += 1;
        }

        public void Upgrade()
        {
            if(Manufacturer == "Apple")
            {
                Upgradeable = false;
            }
            else
            {
                Upgradeable = true;
            }
        }

        public string CanTurnIntoServer()
        {
            if(CapacityInGb >= 32)
            {
                return "Yes";
            }
            else
            {
                return "Nope";
            }
        }

    }
}
