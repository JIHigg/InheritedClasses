using System;
using System.Collections.Generic;
using System.Text;

namespace InheritedClasses
{
    /// <summary>
    /// A sub Class of Bird.
    /// </summary>
    class Pelican: Bird
    {
        private string featherColor;

        public string FeatherColor
        {
            get { return featherColor; }
            set { featherColor = value; }
        }
        public Pelican(double wingspan, string diet, string featherColor,
            string name, int size, double weight, string habitat): base
            (wingspan,diet,name,size,weight,habitat)
        {
            FeatherColor = featherColor;
        }

        public Pelican(): this(2.5, "fish", "black and white", "Pelican", 1, 4, "Coastline")
        {

        }

        public override string Stats()
        {
            return base.Stats() + $"\nColor of Feathers: " + FeatherColor.ToString();
        }
    }
}
