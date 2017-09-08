using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given a list of Integers representing seat numbers, group them into ranges 1-10, 11-20, and 21-30.
         (Any seat number less than 1, or greater than 30 is invalid, and can be ignored.) Preserve the order
         in which the seat number entered their associated group. Return a list of the grouped Integers 1-10,
         11-20, and 21-30. (Hint: Think multiple queues)
         boardingGate( [1, 13, 43, 22, 8, 11, 30, 2, 4, 14, 21] ) -> [1, 8, 2, 4, 13, 11, 14, 22, 30, 21]
         boardingGate( [29, 19, 9, 21, 11, 1, 0, 25, 15, 5, 31] ) -> [9, 1, 5, 19, 11, 15, 29, 21, 25]
         boardingGate( [0, -1, 44, 31, 17, 7, 27, 16, 26, 6] ) -> [7, 6, 17, 16, 31, 27, 26]
         */
        public List<int> BoardingGate(List<int> seatNumberList)
        {
            Queue<int> smallQueue = new Queue<int>();
            Queue<int> mediumQueue = new Queue<int>();
            Queue<int> largeQueue = new Queue<int>();

            foreach (int number in seatNumberList)
            {
                if (number >= 1 && number <= 10)
                {
                    smallQueue.Enqueue(number);
                }
                else if (number >= 11 && number <= 20)
                {
                    mediumQueue.Enqueue(number);
                }
                else if (number >= 21 && number <= 30)
                {
                    largeQueue.Enqueue(number);
                }
            }

            List<int> output = new List<int>();
            output.AddRange(smallQueue.ToList());
            output.AddRange(mediumQueue.ToList());
            output.AddRange(largeQueue.ToList());

            return output;
        }

    }
}
