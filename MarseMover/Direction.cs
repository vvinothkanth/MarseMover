using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarceRover
{
    /// <summary>
    /// 
    /// </summary>
    enum Degree
    {
        N = 0,
        E = 90,
        S = 180,
        W = 270
    }

    /// <summary>
    /// 
    /// </summary>
    enum CommanDirection
    {
        North = 'N',
        East = 'E',
        West = 'W',
        South = 'S'
    }

    /// <summary>
    /// 
    /// </summary>
    enum RelativeDirection
    {
        Left = 'L',
        Right = 'R'
    }

    /// <summary>
    /// 
    /// </summary>
    public class Direction
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="degree"></param>
        /// <returns></returns>
        public static char ToName(int degree)
        {
            char key = ' ';
            try
            {
                switch (degree)
                {
                    case (int)Degree.N:
                        key = Degree.N.ToString().ToCharArray()[0];
                        break;

                    case (int)Degree.E:
                        key = Degree.E.ToString().ToCharArray()[0];
                        break;

                    case (int)Degree.S:
                        key = Degree.S.ToString().ToCharArray()[0];
                        break;

                    case (int)Degree.W:
                        key = Degree.W.ToString().ToCharArray()[0];
                        break;

                    default:
                        throw new Exception("Degree Contains only 0,90,180 and 270");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw new Exception(ex.Message);
            }

            return key;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int ToDegree(char key)
        {
            int degree = 0;
            try
            {
                switch (char.ToUpper(key))
                {
                    case (char)CommanDirection.North:
                        degree = (int)Degree.N;
                        break;

                    case (char)CommanDirection.East:
                        degree = (int)Degree.E;
                        break;

                    case (char)CommanDirection.South:
                        degree = (int)Degree.S;
                        break;

                    case (char)CommanDirection.West:
                        degree = (int)Degree.W;
                        break;

                    default:
                        throw new Exception("Direction Contains only E,W,N and S");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw new Exception(ex.Message);
            }

            return degree;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public static char GetNextDirectionFromLeft(char direction)
        {
            char key= char.ToUpper(direction);
            char nextDegree = ' ';
            try
            {
                if (key == (char)CommanDirection.East || key == (char)CommanDirection.West || key == (char)CommanDirection.South)
                {
                    nextDegree = ToName(ToDegree(direction) - 90);
                }
                else if (key == (char)CommanDirection.North)
                {
                    nextDegree = 'W';
                }
                else
                {
                    throw new Exception("Direction Contains only E,W,N and S");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw new Exception(ex.Message);
            }

            return nextDegree;
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public static char GetNextDirectionFromRight(char direction)
        {
            char key = char.ToUpper(direction);
            char nextDegree = ' ';
            try
            {
                if (key == (char)CommanDirection.East || key == (char)CommanDirection.North || key == (char)CommanDirection.South)
                {
                    nextDegree = ToName(ToDegree(direction) + 90);
                }
                else if (key == (char)CommanDirection.West)
                {
                    nextDegree = 'N';
                }
                else
                {
                    throw new Exception("Direction Contains only E,W,N and S");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw new Exception(ex.Message);
            }

            return nextDegree;

        }        
    }
}
