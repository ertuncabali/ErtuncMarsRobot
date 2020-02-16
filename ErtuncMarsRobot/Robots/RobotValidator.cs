using ErtuncMarsRobot.Plateaus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ErtuncMarsRobot.Robots
{
    public class RobotValidator
    {
        public bool IsValidCoordinate(string input, Plateau plateau)
        {
            input = input.Trim();

            // Input 5 hane gelmeli
            // 1 2 N
            if (input.Length > 5)
            {
                return false;
            }

            var splitted = input.Split(' ').ToArray();
            // Boşluklarla split edilmiş veri sayısı 3 olmalı
            // 1,2,N
            if (splitted.Length != 3)
            {
                return false;
            }

            var x = Convert.ToChar(splitted[0]);
            var y = Convert.ToChar(splitted[1]);
            var direction = Convert.ToChar(splitted[2]);

            // x ve y sayısal , direction harf olmalı
            if (!char.IsDigit(x) || !char.IsDigit(y) || !char.IsLetter(direction))
            {
                return false;
            }

            // robot başlangıç koordinatı platonun coordinatlarından farklı koordinatta olamaz
            if (Convert.ToInt32(x.ToString()) > plateau.CoordinateX || Convert.ToInt32(y.ToString()) > plateau.CoordinateY)
            {
                return false;
            }

            // robot başlangıç koordinatları 0dan küçük olamaz
            if (Convert.ToInt32(x.ToString()) < 0 || Convert.ToInt32(y.ToString()) < 0)
            {
                return false;
            }

            return true;
        }
    }
}
