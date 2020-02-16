using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ErtuncMarsRobot.Directions
{
    public class DirectionService
    {
        public Direction GetDirectionByName(string name)
        {
            var directionList = ListDirections();
            return directionList.FirstOrDefault(x => x.Name == name.ToUpper());
        }

        private List<Direction> ListDirections()
        {
            var north = new Direction(CompassPoints.North, CompassPoints.West, 0, CompassPoints.East, 1);
            var west = new Direction(CompassPoints.West, CompassPoints.South, -1, CompassPoints.North, 0);
            var south = new Direction(CompassPoints.South, CompassPoints.East, 0, CompassPoints.West, -1);
            var east = new Direction(CompassPoints.East, CompassPoints.North, 1, CompassPoints.South, 0);

            var directionList = new List<Direction>();
            directionList.Add(north);
            directionList.Add(west);
            directionList.Add(south);
            directionList.Add(east);

            return directionList;
        }
    }
}
