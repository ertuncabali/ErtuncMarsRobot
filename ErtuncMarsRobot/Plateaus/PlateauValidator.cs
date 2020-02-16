using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ErtuncMarsRobot.Robots
{
    public class PlateauValidator
    {
        public bool IsValidAreaData(string input)
        {
            input = input.Trim();

            if (input.Length > 3)
            {
                return false;
            }

            var splitted = input.Split(' ').ToArray();

            if (splitted.Length != 2)
            {
                return false;
            }

            foreach (var data in splitted)
            {
                if (!char.IsDigit(data.First()))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
