using ElevatorEngine;
using NUnit.Framework;

namespace ElevatorEngineTests
{
    [TestFixture]
    public class UserOnFirstFloorTests
    {
        [Test]
        public void WhenLiftRequest_onFirstFloor_withLiftOnFirstFloor_opensDoor()
        {
            IElevator myElevator = new MyElevator(numberOfFloors: 3);

            myElevator.Start(initialFloor: 1);
            myElevator.RequestLift(floor: 1);

            Assert.IsTrue(myElevator.DoorsOpened);
        }

        [Test]
        public void WhenLiftRequest_onFirstFloor_withLiftNotFirstFloor_keepsDoorClosed()
        {
            IElevator myElevator = new MyElevator(numberOfFloors: 3);

            myElevator.Start(initialFloor: 2);
            myElevator.RequestLift(floor: 1);

            Assert.IsFalse(myElevator.DoorsOpened);
        }


    }
}
