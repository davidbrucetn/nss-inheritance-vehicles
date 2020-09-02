using System;

namespace nss_inheritance_vehicles
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine($"The {MainColor} Ram is now full.");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives by - Bwwob bwwwobbubwub");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"{Name}, the Ram, turns noisily {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"{Name}, the Ram, reluctantly slows and comes to a stop at the Tractor Supply store.");
        }
    }
}