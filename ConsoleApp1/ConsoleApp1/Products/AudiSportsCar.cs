using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Products
{
    class AudiSportsCar:SportsCar
    {
        public override void Ride(SportsCar sportscara)
        {
            Console.WriteLine($"{this.GetType().Name}Win{sportscara.GetType().Name}");
        }
    }
}
