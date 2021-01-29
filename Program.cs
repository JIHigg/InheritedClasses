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
            PersonHandler PH = new PersonHandler();
            List<Person> People = new List<Person>();

            Person testSubject = PH.CreatePerson(21, "johan", "Anders", 173, 78);
            Person nextSubject = PH.CreatePerson(45, "Anna", "Smith", 145, 59);
            Person thirdSubject = PH.CreatePerson(30, "Michael", "George", 201, 62);
            Person lastSubject = PH.CreatePerson(4, "Elisabeth", "Anders", 78, 20);

            People.Add(testSubject);
            People.Add(nextSubject);
            People.Add(thirdSubject);
            People.Add(lastSubject);

            PH.SetAge(testSubject, 89);
            PH.SetName(nextSubject, "Terry", "Pratchett");
            PH.SetHeight(thirdSubject, 145);
            PH.SetWeight(lastSubject, 190);

            //F.13) Om fåglaren behöver ett nytt attribut, kan vi lägga det i Bird Klassen.
            //F.14) Om alla djur behöver det nya attributet, ska vi lägga det i Animal Klassen.

            Bird crow = new Bird();
            Dog dog = new Dog("Gold", "Golden Retriever", "Golden Retriever", 1, 30, "domestic");
            Flamingo flamingo = new Flamingo();
            Hedgehog hedgehog = new Hedgehog();
            Horse horse = new Horse();
            Pelican pelican = new Pelican();
            Swan swan = new Swan();
            Wolf wolf = new Wolf();
            Wolfman bugbear = new Wolfman();

            List<Animal> Animals = new List<Animal>
            {
                dog,
                flamingo,
                crow,
                hedgehog,
                horse,
                pelican,
                swan,
                wolf,
                
                new Wolfman(),
                new Bird(115, "rabbits", "Hawk", 100, 10, "Forest"),
                new Dog("black","Labrador", "Black Lab", 150, 40, "sofa")
            };

            Console.WriteLine("Here are all the animals in my list");
            Console.WriteLine("------------------------------------");

            foreach (Animal animal in Animals)
            {
                    Console.WriteLine(animal.Name);
                    Console.WriteLine(animal.DoSound("Hello"));
                    Console.WriteLine("\n");
                 
                if(animal is IPerson human)
                {
                    human.Talk("*Hoooowwwlll", "Hello");
                }
            }

            List<Dog> Dogs = new List<Dog>();
            //Dogs.Add(horse); - Fungerar inte
            //F.9) Instansen måste vara en Dog eller Dog sub-klass.
            //F.10) Listen måste vara en Animal klass för att alla 
            // klasser skall kunna lagras tillsammans.

            foreach(Animal animal in Animals)
            {
                //Hämtar och skriver ut varje Property för varje Instans i Listan.
                Console.WriteLine(animal.Stats());

                if(animal is Dog hund)
                {
                    Console.WriteLine(hund.GetBreed());
                }

                //animal.GetBreed(); - Fungerar inte
                //F.17) Metoden kan inte åt från Animals listan för att 
                // metoden är inte skapa i Animal klassen.
            }
            foreach(Animal hund in Animals)
            {
                if (hund is Dog dog1)
                {
                    Console.WriteLine(hund.Stats());
                }
            }

            var UserErrors = new List<UserError>()
            {
                 new NumericInputError(),
                 new TextInputError(),
            };

            UserErrors.Add(new ImproperDecimalError());
            UserErrors.Add(new NumberTooLowError());
            UserErrors.Add(new UnrecognizedInputError());

            foreach(UserError error in UserErrors)
            {
                Console.WriteLine(error.UEMessage());
            }

            //F.11) Polymorfism är viktigt att bemästra eftersom det är ett
            //      effektivt sätt att skriva större projekt.
            //F.12) Polymorfism kan förändra och förbättra kod via en bra struktur 
            //      genom att tillåta ett effktivt sätt att ändra kod uppifrån och 
            //      ner och minska överflödig kod.
            //F.13) En Abstrakt klass gör det möjligt att ange och implementera 
            //      metoder och objekt, ett Interface tillåter bara att ange dem.
            //      En underklass kan också bara ha en Abstrakt klass, men flera Interfacer.
        }
    }
}
