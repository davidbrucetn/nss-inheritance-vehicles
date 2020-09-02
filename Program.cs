using System;

namespace nss_inheritance_vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Ram MightyMax = new Ram();
            MightyMax.Name = "Mighty Max";
            MightyMax.MainColor = "Silver";
            MightyMax.Weight = 4200;
            MightyMax.RefuelTank();
            MightyMax.Drive();
            MightyMax.Turn("right");
            MightyMax.Stop();

            Console.WriteLine("------------------------");

            Tesla Socket = new Tesla();
            Socket.Name = "Socket";
            Socket.MainColor = "Charcoal";
            Socket.Weight = 3100;
            Socket.ChargeBattery();
            Socket.Drive();
            Socket.Turn("left");
            Socket.Stop();

            Console.WriteLine("------------------------");

            Cessna Skywalker = new Cessna();
            Skywalker.Name = "Skywalker";
            Skywalker.Weight = 5500;
            Skywalker.MainColor = "White";
            Skywalker.Drive();
            Skywalker.Turn("left");
            Skywalker.Stop();

            Console.WriteLine("------------------------");

            Zero Tron = new Zero();
            Tron.Name = "Tron";
            Tron.Weight = 250;
            Tron.MainColor = "Midnight Blue";
            Tron.ChargeBattery();
            Tron.Drive();
            Tron.Turn("right");
            Tron.Stop();

        }
    }
}