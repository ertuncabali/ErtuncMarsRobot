using ErtuncMarsRobot.Plateaus;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErtuncMarsRobot.Robots
{
   public class RobotAction
    {
        public Plateau Plateau{ get; set; }
        public Robot Robot{ get; set; }
        public string Commands { get; set; }
        public DateTime CommandDate { get; set; }
    }
}
