using System;
using System.Collections.Generic;
using System.Text;

namespace InheritedClasses
{
    /// <summary>
    /// A base Person Class for collecting traits of a person.
    /// </summary>
    class Person
    {
        public Person()
        {

        }
        public Person( string fName, string lName)
        {
            FName = fName;
            LName = lName;
        }
        private int age;

        public int Age
        {
            get { return age; }
            set 
            {
                if (value < 1)
                    throw new Exception("Age must be more than zero");
                else
                    age = value; }
        }
        private string fName;

        public string FName
        {
            get { return fName; }
            set 
            {
                if (value.Length < 2 || value.Length > 10 )
                    throw new Exception("Please enter a first name that" +
                                        "no is longer than ten characters.");
                 else
                     fName = value; }
        }
        private string lName;

        public string LName
        {
            get { return lName; }
            set 
            {
                if (value.Length <3 || value.Length > 15)
                    throw new Exception("Please enter a name that is " +
                                        "no longer than fifteen character.");
                lName = value; }
        }
        private double height;

        public double Height
        {
            get { return height; }
            set 
            {
                if (value <= 0)
                    throw new Exception("Please enter height in cm.");

                height = value; }
        }
        private double weight;

        public double Weight
        {
            get { return weight; }
            set 
            {
                if (value < 0)
                    throw new Exception("Please enter weight in kg.");
                weight = value; }
        }



    }
}
