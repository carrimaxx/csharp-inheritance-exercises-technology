using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Laptop : Computer
    {
        // TODO : add at least 1 additional field, 1 additional method
        public string CapacityType { get; set; }

        public Laptop(int ram, int capacity, string manufacturer, string capacityType) : base (ram, capacity, manufacturer)
        {
            CapacityType = capacityType;
            RamInGb = ram;
            CapacityInGb = capacity;
            Manufacturer = manufacturer;
        }

        //public int IdNumber() // not sureeee
        //{
        //    ID += 1;
        //}
    }
}
