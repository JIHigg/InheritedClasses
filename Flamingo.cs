using System;
using System.Collections.Generic;
using System.Text;

namespace InheritedClasses
{
    /// <summary>
    /// A sub Class of Bird.
    /// </summary>
    class Flamingo: Bird
    {
        private double neckLength;

        public double NeckLength
        {
            get { return neckLength; }
            set { neckLength = value; }
        }
        public Flamingo(double wingspan, string diet, double necklength,
            string name, int size, double weight, string habitat): base(wingspan,diet,
                name, size,weight,habitat)
        {
            NeckLength = necklength;
        }

        public Flamingo():this(95,"insects", 50.5, "Flamingo", 1, 3.5, "tropical coast")
        {

        }

        public override string Stats()
        {
            return base.Stats() + $"\nNeck Length: " +
                $"{NeckLength.ToString()} cm";
        }

    }
}
