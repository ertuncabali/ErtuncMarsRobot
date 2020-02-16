using ErtuncMarsRobot.Directions;
using ErtuncMarsRobot.Plateaus;
using ErtuncMarsRobot.Robots;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErtuncMarsRobot.Actions
{
    public class MoveActionBase
    {
        public virtual bool CanMove(RobotAction robotAction)
        {
            var area = robotAction.Plateau;
            var robot = robotAction.Robot;
            var robotDirection = robotAction.Robot.Direction;
            if (area.CoordinateX < robot.PositionX + robotDirection.MovementAddPointX)
            {
                return false;
            }

            if (area.CoordinateY < robot.PositionY + robotDirection.MovementAddPointY)
            {
                return false;
            }
            return true;
        }
    }
}
