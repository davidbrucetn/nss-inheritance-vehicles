using System;

namespace nss_inheritance_vehicles
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine($"The {MainColor} Zero electric motorcycle is now charged.");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero whizzes by - Whoooosh!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"{Name}, the Zero, leans {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"{Name}, the Zero, pops a wheely then returns to the ground and slides to a stop.");
        }
    }
}