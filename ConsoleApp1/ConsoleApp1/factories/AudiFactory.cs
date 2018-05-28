using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Products;

namespace ConsoleApp1.factories
{
   public class AudiFactory:CarFactory
    {
        public override FamilyCar CreatFamilyCar()
        {
            return new AudiFamilyCar();
        }
        public override SportsCar CreatSportsCar()
        {
            return new AudiSportsCar();
        }
    }
}
