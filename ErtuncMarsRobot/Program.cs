using ErtuncMarsRobot.Robots;
using System;
using System.Collections.Generic;

namespace ErtuncMarsRobot
{
    class Program
    {
        public static void Main()
        {
            //Plateau coordinates
            var areaCoordinateInput = Console.ReadLine();
            List<RobotActionRequest> robotActionList = new List<RobotActionRequest>();

            for (int i = 0; i < 2; i++)
            {
                //Robot coordinates
                var robotCoordinate = Console.ReadLine();

                //Robot Commands
                var commands = Console.ReadLine();

                //Robot Action Data
                var actionData = new RobotActionRequest
                {
                    Robot = robotCoordinate,
                    Commands = commands,
                    Plateau = areaCoordinateInput,
                    CommandDate = DateTime.Now
                };
                robotActionList.Add(actionData);
            }
            
            // Starts Robot to Explore
            RobotService rs = new RobotService();
            var result = rs.Explore(robotActionList);

            //Writes robots coordinates
            if (!result.IsSuccess)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                foreach (var robot in result.Data)
                {
                    Console.WriteLine(robot);
                }
            }
        }



    }
}
