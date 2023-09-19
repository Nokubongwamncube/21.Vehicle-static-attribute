using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Vehicle_static_attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicles vehicle1 = new Vehicles("Madza", "White", 4);
            Vehicles vehicle2 = new Vehicles("suzuki", "Yellow", 4);

            Console.WriteLine(vehicle1.Model);
            Console.WriteLine(Vehicles.vehicleCount);

            //freeeze
            Console.Read();

        }
    }
}
