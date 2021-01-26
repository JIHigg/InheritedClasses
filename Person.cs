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
            set { if (value < 1)
                    throw new Exception("Age must be more than zero");
            else
                age = value; }
        }
        private string fName;

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }
        private string lName;

        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }
        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }



    }
}
