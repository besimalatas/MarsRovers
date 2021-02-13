using MarsRovers.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers.Model
{
    /// <summary>
    /// Position class
    /// </summary>
    public class Position
    {
        /// <summary>
        /// X point in the coordinates
        /// </summary>
        public int XPoint { get; set; }

        /// <summary>
        /// Y point in the coordinates
        /// </summary>
        public int YPoint { get; set; }

        /// <summary>
        /// Direction in the coordinates
        /// </summary>
        public Directions Direction { get; set; }

    }
}
