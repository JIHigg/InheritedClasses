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
        public override string DoSound(string sound)
        {
            return base.DoSound(sound);
        }

        public override string Stats()
        {
            return base.Stats() + $"This worm has {NoOfMates.ToString()}" +
                $" partners and is {Length.ToString()} cm long.";
        }

    }
}
