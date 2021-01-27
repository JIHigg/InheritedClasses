using System;
using System.Collections.Generic;
using System.Text;

namespace InheritedClasses
{
    /// <summary>
    /// An abstract class for all Animals.
    /// </summary>
    abstract class Animal
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public double Weight { get; set; }
        public string Habitat { get; set; }
        public virtual string DoSound(string sound)
        {
            return $"A { this.GetType().Name} makes a '{sound}' sound. ";
        }

        public virtual string Stats()
        {
            return $"A {GetType().Name} is {this.Size.ToString()} cm " +
                $"long, {this.Weight.ToString()} kg, and lives in {this.Habitat}.";
        }
    }
}
