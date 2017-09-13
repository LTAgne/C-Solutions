using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
        private int totalMarks;

        /// <summary>
        /// Total number of marks received
        /// </summary>
        public int TotalMarks
        {
            get { return totalMarks; }    
            set { totalMarks = value; }        
        }

        private int possibleMarks;

        /// <summary>
        /// Possible number of marks to get right on the homework assignment.
        /// </summary>
        public int PossibleMarks
        {
            get { return possibleMarks; }            
        }

        private string submitterName;

        /// <summary>
        /// Name of the person who submitted the homework assignment
        /// </summary>
        public string SubmitterName
        {
            get { return submitterName; }
            set { submitterName = value; }
        }

        /// <summary>
        /// Letter grade for the assignment. (90-100 A, 80-89 B, 70-79 C, 60-69 D, otherwise F)
        /// </summary>
        public string LetterGrade
        {
            get
            {
                double percentage = (double)totalMarks / possibleMarks;
                if (percentage >= 0.9)
                {
                    return "A";
                }
                else if (percentage >= 0.8)
                {
                    return "B";
                }
                else if (percentage >= 0.7)
                {
                    return "C";
                }
                else if (percentage >= 0.6)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }
            }
            
        }

        /// <summary>
        /// Homework assignment requires possible marks
        /// </summary>
        /// <param name="possibleMarks"></param>
        public HomeworkAssignment(int possibleMarks)
        {
            this.possibleMarks = possibleMarks;
        }


    }
}
