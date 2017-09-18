using PostageCalculator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the weight of the package: ");
            string weightInput = Console.ReadLine();
            int weightValue = int.Parse(weightInput);

            Console.Write("(P)ounds or (O)unces: ");
            string weightType = Console.ReadLine();
            if(weightType == "P")
            {
                weightValue = weightValue * 16; //get the weight in ounces
            }

            Console.Write("What distance will it be traveling (in miles): ");
            string milesInput = Console.ReadLine();
            int milesValue = int.Parse(milesInput);

            List<IDeliveryService> services = new List<IDeliveryService>()
            {
                new PostalServiceFirstClass(),
                new PostalServiceSecondClass(),
                new PostalServiceThirdClass(),
                new FexEdShipping(),
                new SPUFourDayGround(),
                new SPUTwoDayGround(),
                new SPUNextDayGround()
            };

            Console.WriteLine();
            Console.WriteLine("Delivery Method".PadRight(30) + "$ cost".PadRight(10));
            Console.WriteLine("".PadRight(40, '-'));

            foreach (IDeliveryService service in services)
            {
                double postage = service.CalculateRate(weightValue, milesValue);


                Console.WriteLine(service.Name.PadRight(30) + postage.ToString("C").PadRight(10));
            }
        }
    }
}
