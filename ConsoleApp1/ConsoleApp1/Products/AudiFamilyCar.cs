using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Products
{
   public class AudiFamilyCar:FamilyCar
    {
        public override void Ride(FamilyCar familycar)
        {
            Console.WriteLine($"{this.GetType().Name}Win{familycar.GetType().Name}");
        }
    }
}
