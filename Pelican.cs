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

        public override string Stats()
        {
            return base.Stats() + $"This {Name} has {FeatherColor} feathers.";
        }
    }
}
