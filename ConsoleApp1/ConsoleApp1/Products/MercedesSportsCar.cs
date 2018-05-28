using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Products
{
    class MercedesSportsCar:SportsCar
    {
        public override void Ride(SportsCar sportcar)
        {
            Console.WriteLine($"{this.GetType().Name}Win{sportcar.GetType().Name}");
        }
    }
}
