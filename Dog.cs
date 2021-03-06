﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InheritedClasses
{
    /// <summary>
    /// A Class for all dogs.
    /// </summary>
    class Dog : Animal
    {
        private string furColor;

        public string FurColor
        {
            get { return furColor; }
            set { furColor = value; }
        }
        private string breed;

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }
        public Dog(string furColor, string breed, string name, int size,
                    double weight, string habitat ): base(name,size,weight,habitat)
        {
            FurColor = furColor;
            Breed = breed;
        }
        public Dog():this("Brown","Spaniel","Dog",2,15,"Indoors")
        {

        }

        public override string DoSound(string sound)
        {
            return base.DoSound("Woof");
        }

        //A method returning statistics for the dog.
        public override string Stats()
        {
            return base.Stats() + $"\nFur Color: " +
                $" {FurColor}\nBreed: {Breed}";
        }

        //En Metod hämtar bara en statistic för hunden.
        public string GetBreed()
        {
            return "Breed: " + this.Breed;
        }
    }
}
