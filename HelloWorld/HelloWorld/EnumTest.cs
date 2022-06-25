using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class EnumTest
    {
        public enum Title : int
        { 
            助教,
            讲师,
            副教授 = 4,
            教授
        }
    }
}
