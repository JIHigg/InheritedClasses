using System;
using System.Collections.Generic;
using System.Text;

namespace InheritedClasses
{
    /// <summary>
    /// A Class for all birds.
    /// </summary>
    class Bird : Animal
    {
        public double WingSpan { get; set; }
        public string FavoriteDiet { get; set; }

        public Bird(double wingspan, string diet, string name, int size,
            double weight, string habitat): base(name,size,weight,habitat)
        {
            WingSpan = wingspan;
            FavoriteDiet = diet;
        }
        public Bird(): this(.36, "Seeds", "Crow", 1, 1.2, "Forest")
        {

        }
        public override string DoSound(string sound)
        {
            return base.DoSound("CawCaw");
        }

        public override string Stats()
        {
            return $" {base.Stats()} " + $" the wing span is " +
                $"{WingSpan.ToString()}. The {Name} likes to eat {FavoriteDiet}.";
        }

    }
}
