using ErtuncMarsRobot.Plateaus;
using ErtuncMarsRobot.Robots;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ErtuncMarsRobot.Tests
{
    public class RobotTest
    {
        [Fact]
        public void HappyPath1()
        {
            var plateauCoordinates = "5 5";
            var robotCoordinates = "1 2 N";
            var commands = "LMLMLMLMM";

            var robotActionList = new List<RobotActionRequest>();
            robotActionList.Add(new RobotActionRequest
            {
                Robot = robotCoordinates,
                Commands = commands,
                Plateau = plateauCoordinates,
                CommandDate = DateTime.Now,
            });

            RobotService rs = new RobotService();
            var result = rs.Explore(robotActionList);

            Assert.True(result.IsSuccess);

            var data = result.Data.First();
            Assert.Equal(1, data.PositionX);
            Assert.Equal(3, data.PositionY);
            Assert.Equal("N", data.Direction.Name);
        }

        [Fact]
        public void HappyPath2()
        {
            var plateauCoordinates = "5 5";
            var robotCoordinates = "3 3 E";
            var commands = "MMRMMRMRRM";

            var robotActionList = new List<RobotActionRequest>();
            robotActionList.Add(new RobotActionRequest
            {
                Robot = robotCoordinates,
                Commands = commands,
                Plateau = plateauCoordinates,
                CommandDate = DateTime.Now
            });

            RobotService rs = new RobotService();
            var result = rs.Explore(robotActionList);

            Assert.True(result.IsSuccess);

            var data = result.Data.First();
        
            Assert.Equal(5, data.PositionX);
            Assert.Equal(1, data.PositionY);
            Assert.Equal("E", data.Direction.Name);
        }
        
        [Fact]
        public void OutOfArea()
        {
            var plateauCoordinates = "5 5";
            var robotCoordinates = "3 3 E";
            var commands = "MMMM";

            var robotActionList = new List<RobotActionRequest>();
            robotActionList.Add(new RobotActionRequest
            {
                Robot = robotCoordinates,
                Commands = commands,
                Plateau = plateauCoordinates,
                CommandDate = DateTime.Now
            });

            RobotService rs = new RobotService();
            var result = rs.Explore(robotActionList);

            Assert.False(result.IsSuccess);
            var message = result.Message;
            
            Assert.Equal("Robot sýnýrý geçemez", message);
        }

        [Fact]
        public void AreaCoordinatesWrong()
        {
            var plateauCoordinates = "125";
            var robotCoordinates = "3 3 E";
            var commands = "MMMM";

            var robotActionList = new List<RobotActionRequest>();
            robotActionList.Add(new RobotActionRequest
            {
                Robot = robotCoordinates,
                Commands = commands,
                Plateau = plateauCoordinates,
                CommandDate = DateTime.Now
            });

            RobotService rs = new RobotService();
            var result = rs.Explore(robotActionList);

            Assert.False(result.IsSuccess);
            var message = result.Message;

            Assert.Equal("Invalid area data", message);
        }

        [Fact]
        public void RobotCoordinatesWrong()
        {
            var plateauCoordinates = "5 5";
            var robotCoordinates = "3 32E";
            var commands = "MMMM";

            var robotActionList = new List<RobotActionRequest>();
            robotActionList.Add(new RobotActionRequest
            {
                Robot = robotCoordinates,
                Commands = commands,
                Plateau = plateauCoordinates,
                CommandDate = DateTime.Now
            });

            RobotService rs = new RobotService();
            var result = rs.Explore(robotActionList);

            Assert.False(result.IsSuccess);
            var message = result.Message;

            Assert.Equal("Invalid robot coordinates", message);
        }
    }
}
