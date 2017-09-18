using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothCalculator.Classes;

namespace TollBoothCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> vehicles = new List<IVehicle>();
            vehicles.Add(new Car(false));
            vehicles.Add(new Car(true));
            vehicles.Add(new Tank());
            vehicles.Add(new Truck(4));
            vehicles.Add(new Truck(6));
            vehicles.Add(new Truck(8));

            Random rnd = new Random();
            int totalMilesTraveled = 0;
            double totalTollRevenue = 0.0;
            Console.WriteLine("Vehicle\t\tDistance Traveled\tToll $");
            Console.WriteLine("----------------------------------------------");
            foreach(IVehicle vehicle in vehicles) 
            {
                int distance = rnd.Next(10, 240);
                double toll = vehicle.CalculateToll(distance);
                Console.WriteLine(vehicle.Type + "\t\t" + distance + "\t\t\t" + toll.ToString("C"));
                totalMilesTraveled += distance;
                totalTollRevenue += toll;
            }
            Console.WriteLine();
            Console.WriteLine("Total Miles Traveled: " + totalMilesTraveled);
            Console.WriteLine("Total Tollbooth Revenue: " + totalTollRevenue.ToString("C"));
            Console.WriteLine();
        }
    }
}
