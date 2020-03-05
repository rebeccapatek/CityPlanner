using System;
using System.Collections.Generic;
namespace Planner
{
    public class City
    {
        public string name { get; set; }
        public string mayor { get; set; }
        public int yearEstablished { get; set; }
        public List<Building> Buildings = new List<Building>();

        public void AddBuildingToCity(Building building)
        {
            Buildings.Add(building);
        }


    }
}
