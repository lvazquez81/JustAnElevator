using ElevatorEngine;
using NUnit.Framework;
using System.Threading.Tasks;

namespace ElevatorEngineTests
{
    [TestFixture]
    public class MovingLiftTests
    {
        [Test]
        public void AfterRequestLift_ElevatorMoves_ToRequestFloor()
        {
            IElevator myElevator = new MyElevator(numberOfFloors: 3);
            myElevator.Start(initialFloor: 3);

            myElevator.RequestLift(floor: 1);

            Assert.IsTrue(myElevator.IsMoving);
        }
    }
}
