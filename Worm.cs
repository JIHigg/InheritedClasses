using System;
using System.Collections.Generic;
using System.Text;

namespace InheritedClasses
{
    /// <summary>
    /// A sub Class of Animal.
    /// </summary>
    class Worm: Animal
    {
        public int NoOfMates { get; set; }
        public double Length { get; set; }
        public Worm(int noOfMates, double length, string name, int size,
           double weight, string habitat ): base(name, size, weight, habitat)
        {
            NoOfMates = noOfMates;
            Length = length;
        }
        public Worm(): this(1, 25, "Worm", 25, 2.1, "Undergound")
        {

        }
        public override string DoSound(string sound)
        {
            return base.DoSound("crunch");
        }

        public override string Stats()
        {
            return base.Stats() + $"This worm has {NoOfMates.ToString()}" +
                $" partners and is {Length.ToString()} cm long.";
        }

    }
}
