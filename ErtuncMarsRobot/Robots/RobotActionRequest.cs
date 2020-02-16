using ErtuncMarsRobot.Plateaus;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErtuncMarsRobot.Robots
{
   public class RobotActionRequest
    {
        public string Plateau{ get; set; }
        public string Robot{ get; set; }
        public string Commands { get; set; }
        public DateTime CommandDate { get; set; }
    }
}
