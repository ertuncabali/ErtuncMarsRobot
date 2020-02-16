using System;
using System.Collections.Generic;
using System.Text;
using ErtuncMarsRobot.Robots;

namespace ErtuncMarsRobot.Actions
{
    public class ActionR : TurnActionBase, IAction
    {
        public Result<Robot> DoAction(RobotAction robotAction)
        {
            var newDirection = robotAction.Robot.Direction.RigthDirection;
            robotAction.Robot.Direction = GetNewDirectionOfRobot(newDirection);
            return  new Result<Robot>(robotAction.Robot);
        }
    }
}
