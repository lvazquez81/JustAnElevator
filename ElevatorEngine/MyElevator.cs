using System;

namespace ElevatorEngine
{
    public class MyElevator : IElevator
    {
        public int NumberOfFloors { get; private set; }
        public bool IsOnline { get; private set; }
        public int CurrentFloor { get; private set; }
        public bool DoorsOpened { get; private set; }
        public bool IsMoving { get; private set; }

        public MyElevator(int numberOfFloors)
        {
            this.IsOnline = false;

            if (numberOfFloors <= 1)
            {
                throw new ArgumentException("An elevator needs at least two floors.");
            }

            this.CurrentFloor = 1;
            this.NumberOfFloors = numberOfFloors;
        }

        public void Start()
        {
            this.Start(initialFloor: 1);
        }

        public void Start(int initialFloor)
        {
            if (initialFloor < 1 || initialFloor > this.NumberOfFloors)
            {
                throw new ArgumentException("Initial floor not valid for number of floors specified.");
            }

            this.CurrentFloor = initialFloor;
            this.IsOnline = true;
        }

        public void RequestLift(int floor)
        {
            if (this.CurrentFloor == floor)
            {
                this.DoorsOpened = true;
            }

            if (this.CurrentFloor > floor)
            {
                this.GoDown();
            }

            if (this.CurrentFloor < floor)
            {
                this.GoUp();
            }
        }

        private void GoUp()
        {
            this.IsMoving = true;  
        }

        private void GoDown()
        {
            this.IsMoving = true;
        }


    }
}
