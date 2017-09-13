using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Elevator
    {
        private int currentLevel;
        private int numberOfLevels;
        private bool doorIsOpen;



        /// <summary>
        /// Current elevator level
        /// </summary>
        public int CurrentLevel
        {
            get { return currentLevel; }
        }

        /// <summary>
        /// Number of levels available for elevator.
        /// </summary>
        public int NumberOfLevels
        {
            get { return numberOfLevels; }
        }

        /// <summary>
        /// Is Elevator Door Open?
        /// </summary>
        public bool DoorIsOpen
        {
            get { return doorIsOpen; }
        }

       

        /// <summary>
        /// Creates a new elevator
        /// </summary>
        /// <param name="totalNumberOfFloors">Number of floors in the elevator</param>
        public Elevator(int totalNumberOfFloors)
        {
            this.numberOfLevels = totalNumberOfFloors;
            this.currentLevel = 1;
        }

        /// <summary>
        /// Opens the elevator door
        /// </summary>
        public void OpenDoor()
        {
            doorIsOpen = true;
        }

        /// <summary>
        /// Closes the elevator door
        /// </summary>
        public void CloseDoor()
        {
            doorIsOpen = false;
        }

        /// <summary>
        /// Moves the elevator up, as long as the door is closed and the desired floor is not past the last floor
        /// </summary>
        /// <param name="desiredFloor">Desired floor to go to</param>        
        public void GoUp(int desiredFloor)
        {
            if (!DoorIsOpen && desiredFloor > CurrentLevel && desiredFloor <= NumberOfLevels)
            {
                currentLevel = desiredFloor;
                
            }            
        }

        /// <summary>
        /// Moves the elevator down, as long as the door is closed and desired floor is lower than current but not past 1
        /// </summary>
        /// <param name="desiredFloor">Floor to go to</param>
        public void GoDown(int desiredFloor)
        {
            if (!DoorIsOpen && desiredFloor < CurrentLevel && desiredFloor > 0)
            {
                currentLevel = desiredFloor;
            }
        }
    }

}
