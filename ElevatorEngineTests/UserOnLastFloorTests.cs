using ElevatorEngine;
using NUnit.Framework;

namespace ElevatorEngineTests
{
    [TestFixture]
    public class UserOnLastFloorTests
    {
        [Test]
        public void WhenLiftRequest_onLastFloor_withLiftOnLastFloor_opensDoor()
        {
            IElevator myElevator = new MyElevator(numberOfFloors: 3);

            myElevator.Start(initialFloor: 3);
            myElevator.RequestLift(floor: 3);

            Assert.IsTrue(myElevator.DoorsOpened);
        }

        [Test]
        public void WhenLiftRequest_onLastFloor_withLiftNotOnLastFloor_keepsDoorsClosed()
        {
            IElevator myElevator = new MyElevator(numberOfFloors: 3);

            myElevator.Start(initialFloor: 1);
            myElevator.RequestLift(floor: 3);

            Assert.IsFalse(myElevator.DoorsOpened);
        }
    }
}
