
using System.Threading.Tasks;
namespace ElevatorEngine
{
    public interface IElevator
    {
        void Start();
        void Start(int initialFloor);

        bool IsOnline { get; }
        bool IsMoving { get; }
        int CurrentFloor { get; }
        int NumberOfFloors { get; }
        void RequestLift(int floor);
        bool DoorsOpened { get; }
    }
}
