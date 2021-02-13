using MarsRovers.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers.Model
{
    /// <summary>
    /// Rover class
    /// </summary>
    public class Rover
    {
        private readonly Position _firstPosition;
        private Position _currentPosition;

        public Rover(string firstPosition)
        {
            this._firstPosition = PositionHelper.FindRoverFirstPositionFromString(firstPosition);
            _currentPosition = this._firstPosition;
        }

        /// <summary>
        /// Change rover position
        /// </summary>
        /// <param name="inputs"></param>
        public void ChangePosition(string inputs)
        {
            foreach (char input in inputs.ToCharArray())
            {
                _currentPosition = PositionHelper.MoveRoverPosition(_currentPosition, input);
            }
        }

        /// <summary>
        /// Get current rover position
        /// </summary>
        /// <returns></returns>
        public Position GetCurrentPosition()
        {
            return _currentPosition;
        }

        /// <summary>
        /// Get current rover position as  string
        /// </summary>
        /// <returns></returns>
        public string GetCurrentPositionAsString()
        {
            return _currentPosition.XPoint + " " +
                   _currentPosition.YPoint + " " +
                   _currentPosition.Direction.ToString();
        }

        /// <summary>
        /// Get rover's first position
        /// </summary>
        /// <returns></returns>
        public Position GetFirstPosition()
        {
            return _firstPosition;
        }
    }
}
