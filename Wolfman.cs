using System;
using System.Collections.Generic;
using System.Text;

namespace InheritedClasses
{
    class Wolfman: Wolf,IPerson
    {
        public Wolfman(): base("Werewolf", 2, 80, "Forest", 1, 20)
        {

        }
        void IPerson.Talk(string sound, string translation)
        {
            Console.WriteLine(DoSound(sound) + $" But what he really means is '{translation}'.");
        }
    }
}
