using System;
using System.Collections.Generic;
using System.Text;

namespace InheritedClasses
{
    class NumberTooLowError:UserError
    {
        public override string UEMessage()
        {
            return "You have entered a number below what is acceptable." +
                "This fired an error!";
        }
    }
}
