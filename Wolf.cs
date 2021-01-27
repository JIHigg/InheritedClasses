using System;
using System.Collections.Generic;
using System.Text;

namespace InheritedClasses
{
    /// <summary>
    /// A sub class of Animal.
    /// </summary>
    class Wolf:Animal
    {
        private int packSize;
        private int area;
        public int PackSize { get; set; }
        public int Area { get; set; }
        public override string DoSound(string sound)
        {
            return base.DoSound(sound);
        }

        public override string Stats()
        {
            return base.Stats() + $"The {Name} has a pack of" +
                $" {PackSize.ToString()} and roams an area of {Area.ToString()}km.";
        }

    }
}
