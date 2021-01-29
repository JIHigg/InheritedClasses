using System;
using System.Collections.Generic;
using System.Text;

namespace InheritedClasses
{
    class TextInputError:UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field." +
                "This fires and error!";
        }
    }
}
