using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.factories;
using ConsoleApp1.Products;

namespace ConsoleApp1.Driver
{
   public class Driver1
    {
        private FamilyCar familycar;
        private SportsCar sportscar;
        public Driver1(CarFactory factory)
        {
            familycar = factory.CreatFamilyCar();
            sportscar = factory.CreatSportsCar();
        }

        public void Ride()
        {
            sportscar.Ride(sportscar);
        }
      
    }

}
