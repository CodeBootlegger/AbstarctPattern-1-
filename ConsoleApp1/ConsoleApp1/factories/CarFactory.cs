using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Products;

namespace ConsoleApp1.factories
{
   public abstract class CarFactory
    {
        public abstract FamilyCar CreatFamilyCar();

        public abstract SportsCar CreatSportsCar();
      
    }
}
