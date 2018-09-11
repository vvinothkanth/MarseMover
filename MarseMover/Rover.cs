// Problem Title : Marse Rover
// Starting Date :
//
//
//
//

namespace MarceRover
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Rover Class
    /// </summary>
    public class Rover
    {
        public int Id { get; set; }

        public int XPoint { get; set; }

        public int YPoint { get; set; }

        public char DirectionKey { get; set; }


        /// <summary>
        /// To set rover position
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="xPoint">X Point</param>
        /// <param name="yPoint">Y Point</param>
        /// <param name="direction">Direction</param>
        public void SetPosition(int id, int xPoint, int yPoint, char direction)
        {
            Id = id;
            XPoint = xPoint;
            YPoint = yPoint;
            DirectionKey = char.ToUpper(direction);
        }

        /// <summary>
        /// To get the current position of th rover
        /// </summary>
        /// <returns></returns>
        public string GetCurrentPosition()
        {
            return string.Format("{0} {1} {2}", XPoint, YPoint, DirectionKey);
        }


        public void ResetXPoint(int point)
        {
            XPoint = point;
        }

        public void ResetYPoint(int point)
        {
            YPoint = point;
        }

        public void ResetDirection(char direction)
        {
            DirectionKey = direction;
        }

        /// <summary>
        /// To get next direction of given command
        /// </summary>
        /// <param name="currentDirection">direction</param>
        /// <param name="command">command(L/R)</param>
        /// <returns>next direction</returns>
        public char GetNextDirection(char currentDirection, char command)
        {
            char nextDirection = ' ';
            try
            {
                if (char.ToUpper(command) == (char)RelativeDirection.Left)
                {
                    nextDirection = Direction.GetNextDirectionFromLeft(currentDirection);
                }
                else if (char.ToUpper(command) == (char)RelativeDirection.Right)
                {
                    nextDirection = Direction.GetNextDirectionFromRight(currentDirection);
                }
                else
                {
                    throw new ArgumentException("The command only contain L and R");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return nextDirection;
        }

        /// <summary>
        /// To get next point from givent points
        /// </summary>
        /// <param name="xPoint">X Point</param>
        /// <param name="yPoint">Y Point</param>
        /// <param name="currentDirection">Direction</param>
        /// <param name="step">steps</param>
        /// <returns>next point</returns>
        public int[] GetNextPoint(int xPoint, int yPoint, char currentDirection, int step)
        {
            int[] nextPoint = new int[2] { xPoint , yPoint };
            try
            {
                switch (char.ToUpper(currentDirection))
                {
                    case (char)CommanDirection.East:
                        nextPoint[0] = Point.Increament(xPoint, step);
                        break;

                    case (char)CommanDirection.West:
                        nextPoint[0] = Point.Decrement(xPoint, step);
                        break;

                    case (char)CommanDirection.North:
                        nextPoint[1] = Point.Increament(yPoint, step);
                        break;

                    case (char)CommanDirection.South:
                        nextPoint[1] = Point.Decrement(yPoint, step);
                        break;

                    default:

                        throw new ArgumentException("The direction key not in exsist");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return nextPoint;
        }
    }
}
