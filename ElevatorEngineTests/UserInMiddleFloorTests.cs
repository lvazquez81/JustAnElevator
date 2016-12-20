using ElevatorEngine;
using NUnit.Framework;

namespace ElevatorEngineTests
{
    [TestFixture]
    public class UserOnMiddleFloorTests
    {
        [Test]
        public void WhenLiftRequest_onMiddleFloor_withLiftOnMiddleFloor_opensDoor()
        {
            IElevator myElevator = new MyElevator(numberOfFloors: 3);

            myElevator.Start(initialFloor: 2);
            myElevator.RequestLift(floor: 2);

            Assert.IsTrue(myElevator.DoorsOpened);
        }

        [Test]
        public void WhenLiftRequest_onMiddleFloor_withLiftNotMiddleFloor_keepsDoorClosed()
        {
            IElevator myElevator = new MyElevator(numberOfFloors: 3);

            myElevator.Start(initialFloor: 1);
            myElevator.RequestLift(floor: 2);

            Assert.IsFalse(myElevator.DoorsOpened);
        }
    }
}
