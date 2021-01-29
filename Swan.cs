using System;
using System.Collections.Generic;
using System.Text;

namespace InheritedClasses
{
    /// <summary>
    /// A sub Class of Birds.
    /// </summary>
    class Swan : Bird
    {
        private int noOfEggs;

        public int NoOfEggs
        {
            get { return noOfEggs; }
            set { noOfEggs = value; }
        }
        public Swan(double wingspan, string diet, int noOfEggs
            ,string name, int size, double weight, string habitat):base
            (wingspan,diet,name,size,weight,habitat)
        {
            NoOfEggs = noOfEggs;
        }
        public Swan() :this(2, "seaweed", 5, "Swan", 1, 7, "Water")
        {

        }

        public override string Stats()
        {
            return base.Stats() + $"\nClutch Size: {NoOfEggs.ToString()} eggs";
        }
    }
}
