using System;

namespace nss_inheritance_vehicles
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine($"The {MainColor} Tesla is now charged.");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives by - Whmmmmm!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"{Name}, the Tesla, turns quietly {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine($"{Name}, the Tesla, pulls into the Neiman Marcus parking lot to a silent stop.");
        }
    }
}