using System;
using System.Collections.Generic;
using System.Text;

namespace ErtuncMarsRobot
{
    public static class EnumParser
    {
        public static T Parse<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
