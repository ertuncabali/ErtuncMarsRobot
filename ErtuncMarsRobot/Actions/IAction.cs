using ErtuncMarsRobot.Plateaus;
using ErtuncMarsRobot.Robots;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErtuncMarsRobot.Actions
{
    public interface IAction
    {
        Result<Robot> DoAction(RobotAction robot);

    }
}
