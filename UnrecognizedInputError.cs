using System;
using System.Collections.Generic;
using System.Text;

namespace InheritedClasses
{
    class UnrecognizedInputError:UserError
    {
        public override string UEMessage()
        {
            return "Your input could not be recognized as valid." +
                "This fired an error!";
        }
    }
}
