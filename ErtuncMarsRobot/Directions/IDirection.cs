using System;
using System.Collections.Generic;
using System.Text;

namespace ErtuncMarsRobot.Directions
{
    public interface IDirection
    {
        string Name { get; set; }
        string LeftDirection { get; set; }
        int MovementAddPointX { get; set; }
        string RigthDirection { get; set; }
        int MovementAddPointY { get; set; }
    }
}
