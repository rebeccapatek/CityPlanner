using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                width = 5.20,
                depth = 8.45,
                stories = 3,

            };
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Holden");
            FiveOneTwoEigth.Design("steve brownlee");
            Building OneOneSecond = new Building("11 Second Ave")
            {
                width = 6.02,
                depth = 4.50,
                stories = 2,
            };
            OneOneSecond.Construct();
            OneOneSecond.Purchase("Coffey");
            OneOneSecond.Design("steve brownlee");

            City LasVegas = new City()
            {
                name = "Las Vegas",
                mayor = "Holden Parker",
                yearEstablished = 1918
            };
            LasVegas.AddBuildingToCity(FiveOneTwoEigth);
            LasVegas.AddBuildingToCity(OneOneSecond);
            foreach (Building building in LasVegas.Buildings)
            {
                building.Print();
            }

        }

    }
}
