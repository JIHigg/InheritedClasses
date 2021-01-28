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
        public Horse(int noOfLegs, string name, int size, double weight,
            string habitat): base(name,size,weight,habitat)
        {
            NoOfLegs = noOfLegs;
        }
        public Horse(): this(4,"Horse",2,400, "meadows and plains")
        {

        }
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
