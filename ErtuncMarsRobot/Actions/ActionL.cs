using ErtuncMarsRobot.Directions;
using ErtuncMarsRobot.Robots;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErtuncMarsRobot.Actions
{
    public class ActionL : TurnActionBase, IAction
    {
        public Result<Robot> DoAction(RobotAction robotAction)
        {
            var newDirection = robotAction.Robot.Direction.LeftDirection;
            robotAction.Robot.Direction = GetNewDirectionOfRobot(newDirection);
            return  new Result<Robot>(robotAction.Robot);
        }
    }
}
