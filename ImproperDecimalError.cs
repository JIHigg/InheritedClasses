using System;
using System.Collections.Generic;
using System.Text;

namespace InheritedClasses
{
    class ImproperDecimalError:UserError
    {
        public override string UEMessage()
        {
            return "You have used a decimal in a non-decimal field." +
                "This fired an error!";
        }
    }
}
