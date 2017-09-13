using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Airplane
    {
        private string planeNumber;
        private int totalFirstClassSeats;
        private int bookedFirstClassSeats = 0;
        private int totalCoachSeats;
        private int bookedCoachSeats = 0;


        /// <summary>
        /// 6-Character Plane Number
        /// </summary>
        public string PlaneNumber
        {
            get { return planeNumber; }            
        }

        /// <summary>
        /// Number of already booked first class seats
        /// </summary>
        public int BookedFirstClassSeats
        {
            get { return bookedFirstClassSeats; }            
        }

        /// <summary>
        /// Available number of first class seats
        /// </summary>
        public int AvailableFirstClassSeats
        {
            get { return totalFirstClassSeats - bookedFirstClassSeats; }
        }

        /// <summary>
        /// Total number of first class seats
        /// </summary>
        public int TotalFirstClassSeats
        {
            get { return totalFirstClassSeats; }        
        }

        /// <summary>
        /// Number of already booked coach seats
        /// </summary>
        public int BookedCoachSeats
        {
            get { return bookedCoachSeats; }
        }

        /// <summary>
        /// Available number of coach seats
        /// </summary>
        public int AvailableCoachSeats
        {
            get { return totalCoachSeats - bookedCoachSeats; }
        }

        /// <summary>
        /// Total number of coach seats
        /// </summary>
        public int TotalCoachSeats
        {
            get { return totalCoachSeats; }
        }

        /// <summary>
        /// Creates a new airplane
        /// </summary>
        /// <param name="planeNumber">Plane number</param>
        /// <param name="totalFirstClassSeats">Total number of first class seats that can be booked</param>
        /// <param name="totalCoachSeats">Total number of coach seats that can be booked</param>
        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            this.planeNumber = planeNumber;
            this.totalFirstClassSeats = totalFirstClassSeats;
            this.totalCoachSeats = totalCoachSeats;            
        }

        /// <summary>
        /// Reserves a first class or coach seat
        /// </summary>
        /// <param name="firstClass">True if the reservation is for first class, false for coach</param>
        /// <param name="totalNumberOfSeats">Total number of seats to reserve</param>
        /// <returns>True if reservation was successful, false otherwise</returns>
        public bool ReserveSeats(bool firstClass, int totalNumberOfSeats)
        {
            if (firstClass)
            {
                if (totalNumberOfSeats > AvailableFirstClassSeats)
                {
                    return false;
                }

                bookedFirstClassSeats += totalNumberOfSeats;
            }
            else
            {
                if (totalNumberOfSeats > AvailableCoachSeats)
                {
                    return false;
                }

                bookedCoachSeats += totalNumberOfSeats;
            }

            return true;
        }
    }
}
