using ElevatorEngine;
using NUnit.Framework;
using System;

namespace ElevatorEngineTests
{
    [TestFixture]
    public class StartElevatorTests
    {
        [Test]
        public void CheckElevator_IsOnline_AfterStart()
        {
            IElevator myElevator = new MyElevator(numberOfFloors: 3);
            myElevator.Start(initialFloor: 1);

            Assert.IsTrue(myElevator.IsOnline);
        }

        [Test]
        public void CheckElevator_IsOffline_BeforeStart()
        {
            IElevator myElevator = new MyElevator(numberOfFloors: 3);

            Assert.IsFalse(myElevator.IsOnline);
        }

        [Test]
        public void InitializeElevator_withZeroFloors_throwsError()
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => new MyElevator(numberOfFloors: 0));

            StringAssert.AreEqualIgnoringCase("An elevator needs at least two floors.", ex.Message);
        }

        [Test]
        public void InitializeElevator_withOneFloor_throwsError()
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => new MyElevator(numberOfFloors: 1));

            StringAssert.AreEqualIgnoringCase("An elevator needs at least two floors.", ex.Message);
        }

        [Test]
        public void InitializeElevator_withTwoFloors()
        {
            IElevator myElevator = new MyElevator(numberOfFloors: 2);
            
            Assert.AreEqual(2, myElevator.NumberOfFloors);
        }

    }
}
