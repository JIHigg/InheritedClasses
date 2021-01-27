using System;
using System.Collections.Generic;
using System.Text;

namespace InheritedClasses
{
    /// <summary>
    /// A sub Class of Animal.
    /// </summary>
    class Hedgehog: Animal
    {
        public int NoOfSpikes { get; set; }

        public override string DoSound(string sound)
        {
            return base.DoSound(sound);
        }

        public override string Stats()
        {
            return base.Stats() + $"{Name} has {NoOfSpikes.ToString()}" +
                $" spikes on its back." ;
        }

    }
}
