using System;
using System.Collections.Generic;

namespace InheritedClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            /*//3.1 Try to set values and catch exceptions.*/

            /*Person person = new Person( "john", "smith");*/

            ////First Name
            //try
            //{
            //person.FName = "";

            //}
            //catch (Exception ex)
            //{
            //Console.WriteLine(ex.Message);
            //}

            ////Last name
            //try
            //{
            //person.LName = "ThisNameIsTooLong";

            //}catch(Exception ex)
            //{
            //Console.WriteLine(ex.Message);
            //}

            ////Age
            //try
            //{
            //person.Age = 0;
            //}catch(Exception e)
            //{
            //Console.WriteLine(e.Message);
            //}

            ////Height
            //try
            //{
            //person.Height = 0;
            //}catch(Exception e)
            //{
            //Console.WriteLine(e.Message);
            //}

            ////Weight
            //try
            //{
            //person.Weight = -12;
            //}catch(Exception e)
            //{
            //Console.WriteLine(e.Message);
            //}

            //3.2 PersonHandler Class
            //PersonHandler PH = new PersonHandler();
            //List<Person> People = new List<Person>();

            //Person testSubject = PH.CreatePerson(21, "johan", "Anders", 173, 78);
            //Person nextSubject = PH.CreatePerson(45, "Anna", "Smith", 145, 59);
            //Person thirdSubject = PH.CreatePerson(30, "Michael", "George", 201, 62);
            //Person lastSubject = PH.CreatePerson(4, "Elisabeth", "Anders", 78, 20);

            //People.Add(testSubject);
            //People.Add(nextSubject);
            //People.Add(thirdSubject);
            //People.Add(lastSubject);

            //PH.SetAge(testSubject, 89);
            //PH.SetName(nextSubject, "Terry", "Pratchett");
            //PH.SetHeight(thirdSubject, 145);
            //PH.SetWeight(lastSubject, 190);

        }
    }
}
