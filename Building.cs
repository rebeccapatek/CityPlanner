using System;
namespace Planner
{
    public class Building
    {
        private string _designer { get; set; }
        private DateTime _dateConstructed { get; set; }

        private string _address { get; set; }

        private string _owner { get; set; }

        public int stories { get; set; }

        public double width { get; set; }
        public double depth { get; set; }
        public double volume
        {
            get
            {
                return width * depth * (3 * stories);
            }
        }
        public Building(string address)
        {
            _address = address;
        }
        public void Construct()
        {
            _dateConstructed = DateTime.Now;

        }
        public void Purchase(string owner)
        {
            _owner = owner;

        }
        public void Design(string designer)
        {
            _designer = designer;
        }
        public void Print()
        {
            Console.WriteLine(_address);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{volume} cubic meters of space");
        }

    }
}
