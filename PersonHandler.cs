using System;
using System.Collections.Generic;
using System.Text;

namespace InheritedClasses
{
    class PersonHandler
    {

        /// <summary>
        /// Sets the age for a Person
        /// </summary>
        /// <param name="pers"></param>
        /// <param name="age"></param>
        public void SetAge(Person pers, int age)
        {
            try
            {
                pers.Age = age;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        /// <summary>
        /// Sets the full name for a Person
        /// </summary>
        /// <param name="pers"></param>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        public void SetName(Person pers, string fName, string lName)
        {
            try
            {
                pers.FName = fName;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                pers.LName = lName;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Sets Height for Person
        /// </summary>
        /// <param name="pers"></param>
        /// <param name="height"></param>
        public void SetHeight(Person pers, double height)
        {
            try
            {
                pers.Height = height;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Sets Weight for Person
        /// </summary>
        /// <param name="pers"></param>
        /// <param name="weight"></param>
        public void SetWeight(Person pers, double weight)
        {
            try
            {
                pers.Weight = weight;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        /// <summary>
        /// Method to create a Person.
        /// </summary>
        /// <param name="age"></param>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="height"></param>
        /// <param name="weight"></param>
        /// <returns></returns>
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
           var  P = new PersonHandler();
            Person per = new Person();
            P.SetAge(per, age);
            P.SetName(per, fname, lname);
            P.SetHeight(per, height);
            P.SetWeight(per, weight);
            return per;
           
        }

    }
}
