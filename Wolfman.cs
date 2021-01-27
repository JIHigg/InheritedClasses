using System;
using System.Collections.Generic;
using System.Text;

namespace InheritedClasses
{
    class Wolfman: Wolf,IPerson
    {
        void IPerson.Talk(string sound, string translation)
        {
            Console.WriteLine(DoSound(sound) + $" But what he really means is '{translation}'.");
        }
    }
}
