using ErtuncMarsRobot.Actions;
using ErtuncMarsRobot.Commands;
using ErtuncMarsRobot.Plateaus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ErtuncMarsRobot.Robots
{
    public class RobotService
    {
        public Result<List<Robot>> Explore(List<RobotActionRequest> robotActionRequestList)
        {
            var robotList = new List<Robot>();
            foreach (var robotActionRequest in robotActionRequestList.OrderBy(x => x.CommandDate))
            {
                //Plateau coordinates
                var areaCoordinateInput = robotActionRequest.Plateau.ToUpper();
                PlateauValidator pv = new PlateauValidator();
                if (!pv.IsValidAreaData(areaCoordinateInput))
                {
                    return new Result<List<Robot>>("Invalid area data");
                }
                Plateau plateauCoordinate = new Plateau(areaCoordinateInput);

                //Robot coordinates
                var robotCoordinate = robotActionRequest.Robot.ToUpper();
                RobotValidator rv = new RobotValidator();
                if (!rv.IsValidCoordinate(robotCoordinate, plateauCoordinate))
                {
                    return new Result<List<Robot>>("Invalid robot coordinates");
                }
                Robot robot = new Robot(robotCoordinate);

                var commandList = robotActionRequest.Commands.ToUpper().ToCharArray();
                foreach (var commandKey in commandList)
                {
                    var commandEnum = EnumParser.Parse<Command>(commandKey.ToString());
                    ActionProvider ap = new ActionProvider(commandEnum);
                    var robotAction = new RobotAction { Robot = robot, Plateau = plateauCoordinate };
                    var result = ap.DoAction(robotAction);

                    if (!result.IsSuccess)
                    {
                        return new Result<List<Robot>>(result.Message);
                    }
                    robot = result.Data;
                }
                robotList.Add(robot);

            }

            return new Result<List<Robot>>(robotList);
        }
    }
}
