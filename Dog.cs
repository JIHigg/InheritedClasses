using System;
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
            return base.DoSound(sound);
        }

        //A method returning statistics for the dog.
        public override string Stats()
        {
            return base.Stats() + $"{Name} has a beautiful coat of" +
                $" {FurColor} fur and is a {Breed} type of dog.";
        }
    }
}
