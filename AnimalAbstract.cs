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
        public Animal(string name, int size, double weight, string habitat)
        {
            Name = name;
            Size = size;
            Weight = weight;
            Habitat = habitat;
        }
        public virtual string DoSound(string sound)
        {
            return $"A { this.GetType().Name} makes a '{sound}' sound. ";
        }

        public virtual string Stats()
        {
            return $"Animal: {this.Name}\nSize: {this.Size.ToString()} m \n" +
                $"Weight: {this.Weight.ToString()} kg \nHabitat: {this.Habitat}";
        }
    }
}
