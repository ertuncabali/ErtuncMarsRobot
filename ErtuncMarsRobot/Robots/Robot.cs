using ErtuncMarsRobot.Directions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErtuncMarsRobot.Robots
{
    public class Robot
    {
        public Robot(string input)
        {
            var splitted = input.Split(' ');
            var x = splitted[0];
            var y = splitted[1];
            var direction = splitted[2];
            this.PositionX = Convert.ToInt32(x);
            this.PositionY = Convert.ToInt32(y);
            var ds = new DirectionService();
            this.Direction = ds.GetDirectionByName(direction);
        }

        public Robot(int x, int y, string directionName)
        {
            PositionX = x;
            PositionY = y;
            var ds = new DirectionService();
            Direction = ds.GetDirectionByName(directionName);
        }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public Direction Direction { get; set; }

        public override string ToString()
        {
            var result = string.Format("{0} {1} {2}", PositionX, PositionY, Direction.Name);
            return result;
        }
    }
}
