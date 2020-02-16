using System;
using System.Collections.Generic;
using System.Text;
using ErtuncMarsRobot.Robots;

namespace ErtuncMarsRobot.Actions
{
    public class ActionM : MoveActionBase, IAction
    {
        public Result<Robot> DoAction(RobotAction robotAction)
        {
            if (CanMove(robotAction))
            {
                robotAction.Robot.PositionX += robotAction.Robot.Direction.MovementAddPointX;
                robotAction.Robot.PositionY += robotAction.Robot.Direction.MovementAddPointY;
                return new Result<Robot>(robotAction.Robot);
            }
            return new Result<Robot>("Robot sınırı geçemez");
        }

    }
}
