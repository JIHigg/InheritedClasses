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
        public override string DoSound(string sound)
        {
            return base.DoSound(sound);
        }

        public override string Stats()
        {
            return $" {base.Stats()} " + $" the wing span is " +
                $"{WingSpan.ToString()}. The {Name} likes to eat {FavoriteDiet}.";
        }

    }
}
