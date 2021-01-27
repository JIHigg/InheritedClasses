using System;
using System.Collections.Generic;
using System.Text;

namespace InheritedClasses
{
    /// <summary>
    /// A Class for Horse Animals.
    /// </summary>
    class Horse : Animal
    {
        public int NoOfLegs { get; set; }
        public override string DoSound(string sound)
        {
            return base.DoSound(sound);
        }

        public override string Stats()
        {
            return base.Stats() + $"A {Name} can have {NoOfLegs.ToString()} legs.";
        }

    }
}
