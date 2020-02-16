using ErtuncMarsRobot.Directions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErtuncMarsRobot.Actions
{
    public class TurnActionBase
    {
        public virtual Direction GetNewDirectionOfRobot(string directionName)
        {
            DirectionService ds = new DirectionService();
            var result = ds.GetDirectionByName(directionName);
            return result;
        }
    }
}
