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
        
        public int PackSize { get; set; }
        public int HuntingArea { get; set; }
        public Wolf(string name, int size, double weight, string habitat,
            int packSize, int area): base(name, size, weight, habitat)
        {
            PackSize = packSize;
            HuntingArea = area;
        }
        public Wolf(): this("Wolf", 1, 60, "forest", 8, 100)
        {

        }
        public override string DoSound(string sound)
        {
            return base.DoSound("Hooowl");
        }

        public override string Stats()
        {
            return base.Stats() + $"\nPack Size: " +
                $" {PackSize.ToString()} \nHunting Area: {HuntingArea.ToString()}km.";
        }

    }
}
