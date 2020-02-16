using System;
using System.Collections.Generic;
using System.Text;

namespace ErtuncMarsRobot.Directions
{
    public class Direction : IDirection
    {
        public string Name { get; set; }
        public string LeftDirection { get; set; }
        public string RigthDirection { get; set; }
        public int MovementAddPointX { get; set; }
        public int MovementAddPointY { get; set; }

        public Direction(string Name, string LeftDirection, int MovementAddPointX, string RigthDirection, int MovementAddPointY)
        {
            this.Name = Name;
            this.LeftDirection = LeftDirection;
            this.MovementAddPointX = MovementAddPointX;
            this.MovementAddPointY = MovementAddPointY;
            this.RigthDirection = RigthDirection;
        }

    }
}
