using System;

namespace InheritedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person( "john", "smith");
            try
            {
                person.Age = -2;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
