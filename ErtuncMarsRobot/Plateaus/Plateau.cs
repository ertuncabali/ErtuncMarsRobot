using System;
using System.Collections.Generic;
using System.Text;

namespace ErtuncMarsRobot.Plateaus
{
    public class Plateau
    {
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }

        public Plateau(int x, int y)
        {
            this.CoordinateX = x;
            this.CoordinateY = y;
        }

        public Plateau(string input)
        {
            var splitted = input.Split(' ');
            var x = splitted[0];
            var y = splitted[1];
            this.CoordinateX = Convert.ToInt32(x);
            this.CoordinateY = Convert.ToInt32(y);
        }
    }
}
