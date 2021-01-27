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

        public override string Stats()
        {
            return base.Stats() + $"{Name} have a neck length of " +
                $"{NeckLength.ToString()} cm.";
        }

    }
}
