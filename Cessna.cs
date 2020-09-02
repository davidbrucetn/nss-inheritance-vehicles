using System;

namespace nss_inheritance_vehicles
{
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flies over - Chitty bang-bang Chitty-chitty bang-bang!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"{Name}, the Cessna, banks {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"{Name}, the Cessna, lands and rolls to stop on the runway.");
        }
    }
}