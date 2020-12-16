using System;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // TODO: At least one of your fields in should be either static, readonly, or a const.
            Laptop lenovo = new Laptop(12, 256, "Lenovo", "SSD");
            Console.WriteLine(lenovo.CapacityInGb);

            SmartPhone iPhone = new SmartPhone(4, 64, "Apple", false, 12);
            Console.WriteLine(iPhone.CapacityInGb);
        }
    }

}
