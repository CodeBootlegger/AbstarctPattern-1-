using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.factories;
using ConsoleApp1.Driver;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver1 driver = new Driver1(new AudiFactory());
            driver.Ride();
            Console.WriteLine("==========");
            Driver1 driver2 = new Driver1(new MercedecFactories());
            driver2.Ride();
        }
    }
}
