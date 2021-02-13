using MarsRovers.Helper;
using MarsRovers.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace UnitTest
{
    [TestClass]
    public class TestPositionHelper
    {
        [TestMethod]
        public void GetFirstPosition()
        {
            //expexted position
            Position position = new Position
            {
                XPoint = 1,
                YPoint = 2,
                Direction = MarsRovers.Enum.Directions.N
            };

            Assert.AreEqual(JsonConvert.SerializeObject(position), JsonConvert.SerializeObject(PositionHelper.FindRoverFirstPositionFromString("1 2 N")));
        }

        [TestMethod]
        public void GetFirstPositionFalsePositive()
        {
            //expexted position
            //Position position = new Position
            //{
            //    XPoint = 1,
            //    YPoint = 2,
            //    Direction = Hepsiburada_Case.Enum.Directions.N
            //};

            //non expexted position
            Position position = new Position
            {
                XPoint = 1,
                YPoint = 3,
                Direction = MarsRovers.Enum.Directions.N
            };

            Assert.AreNotEqual(JsonConvert.SerializeObject(position), JsonConvert.SerializeObject(PositionHelper.FindRoverFirstPositionFromString("1 2 N")));
        }

        [TestMethod]
        public void MovePosition()
        {
            Position firstPosition = new Position
            {
                XPoint = 1,
                YPoint = 2,
                Direction = MarsRovers.Enum.Directions.N
            };

            //expexted position
            Position position = new Position
            {
                XPoint = 1,
                YPoint = 3,
                Direction = MarsRovers.Enum.Directions.N
            };

            Assert.AreEqual(JsonConvert.SerializeObject(position), JsonConvert.SerializeObject(PositionHelper.MoveRoverPosition(firstPosition, 'M')));
        }

    }
}
