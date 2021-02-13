using System;
using MarsRovers.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace UnitTest
{
    [TestClass]
    public class TestRover
    {
        [TestMethod]
        public void GetFirstPosition()
        {
            Rover rover = new Rover("1 2 N");

            //expexted position
            Position position = new Position
            {
                XPoint = 1,
                YPoint = 2,
                Direction = MarsRovers.Enum.Directions.N
            };

            Assert.AreEqual(JsonConvert.SerializeObject(position), JsonConvert.SerializeObject(rover.GetFirstPosition()));
        }


        [TestMethod]
        public void GetLastPosition()
        {
            Rover rover = new Rover("1 2 N");
            rover.ChangePosition("LMLMLMLMM");

            //expexted position
            Position position = new Position
            {
                XPoint = 1,
                YPoint = 3,
                Direction = MarsRovers.Enum.Directions.N
            };

            Assert.AreEqual(JsonConvert.SerializeObject(position), JsonConvert.SerializeObject(rover.GetCurrentPosition()));
        }

        [TestMethod]
        public void GetLastPositionFalsePositive()
        {
            Rover rover = new Rover("1 2 N");
            rover.ChangePosition("LMLMLMLMMM");

            //expexted position
            //Position position = new Position
            //{
            //    XPoint = 2,
            //    YPoint = 3,
            //    Direction = Hepsiburada_Case.Enum.Directions.N
            //};

            //non expexted position
            Position position = new Position
            {
                XPoint = 1,
                YPoint = 3,
                Direction = MarsRovers.Enum.Directions.N
            };

            Assert.AreNotEqual(JsonConvert.SerializeObject(position), JsonConvert.SerializeObject(rover.GetCurrentPosition()));
        }
    }
}
