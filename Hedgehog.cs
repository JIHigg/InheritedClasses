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
        public Hedgehog(int noOfSpikes, string name, int size, double weight,
            string habitat): base(name,size,weight,habitat)
        {
            NoOfSpikes = noOfSpikes;
        }
        public Hedgehog(): this(200, "Hedgehog", 25, 1, "forest")
        {

        }
        public override string DoSound(string sound)
        {
            return base.DoSound("*mumble mumble mumble*");
        }

        public override string Stats()
        {
            return base.Stats() + $"{Name} has {NoOfSpikes.ToString()}" +
                $" spikes on its back." ;
        }

    }
}
