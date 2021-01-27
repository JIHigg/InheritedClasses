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

        public override string Stats()
        {
            return base.Stats() + $"The {Name} has {NoOfEggs.ToString()} eggs.";
        }
    }
}
