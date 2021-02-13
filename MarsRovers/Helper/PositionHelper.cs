using MarsRovers.Enum;
using MarsRovers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers.Helper
{
    /// <summary>
    /// Position Helper Class
    /// </summary>
    public static class PositionHelper
    {
        /// <summary>
        /// Find rover first position from input string
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static Position FindRoverFirstPositionFromString(string text)
        {
            string[] chars = text.Split(" ".ToCharArray());

            Position position = new Position();
            position.XPoint = Convert.ToInt32(chars[0]);
            position.YPoint = Convert.ToInt32(chars[1]);

            Directions direction;
            System.Enum.TryParse(chars[2], out direction);
            position.Direction = direction;

            return position;
        }

        /// <summary>
        /// Move rover method
        /// </summary>
        /// <param name="position">Current position</param>
        /// <param name="input">Move input char</param>
        /// <returns></returns>
        public static Position MoveRoverPosition(Position position, char input)
        {
            Commands command;
            bool isCommandInput = System.Enum.TryParse(input.ToString(), out command);

            if (isCommandInput)
            {
                switch (command)
                {
                    case Commands.L:
                        position.Direction = TurnLeft(position);
                        break;
                    case Commands.R:
                        position.Direction = TurnRight(position);
                        break;
                    case Commands.M:
                        position = Move(position);
                        break;
                }
            }
            else
            {
                //input character dont belong any commands 
            }
            return position;
        }

        /// <summary>
        /// Turn left
        /// </summary>
        /// <param name="position">Rover current position</param>
        /// <returns></returns>
        private static Directions TurnLeft(Position position)
        {
            switch (position.Direction)
            {
                case Directions.E:
                    return Directions.N;
                case Directions.N:
                    return Directions.W;
                case Directions.W:
                    return Directions.S;
                case Directions.S:
                    return Directions.E;
                default:
                    return position.Direction;
            }
        }

        /// <summary>
        /// Turn Right
        /// </summary>
        /// <param name="position">Rover current position</param>
        /// <returns></returns>
        private static Directions TurnRight(Position position)
        {
            switch (position.Direction)
            {
                case Directions.E:
                    return Directions.S;
                case Directions.N:
                    return Directions.E;
                case Directions.W:
                    return Directions.N;
                case Directions.S:
                    return Directions.W;
                default:
                    return position.Direction;
            }
        }

        /// <summary>
        /// Moves the rover according to the command
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        private static Position Move(Position position)
        {
            switch (position.Direction)
            {
                case Directions.E:
                    position.XPoint += 1;
                    break;
                case Directions.N:
                    position.YPoint += 1;
                    break;
                case Directions.W:
                    position.XPoint -= 1;
                    break;
                case Directions.S:
                    position.YPoint -= 1;
                    break;
            }

            return position;
        }
    }
}
