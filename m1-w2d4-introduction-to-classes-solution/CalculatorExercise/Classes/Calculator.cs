using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Calculator
    {
        

        /// <summary>
        /// This constructor initializes the result to the int value provided as an argument.
        /// </summary>
        /// <param name="startingResult">the value that the result should be initialized to</param>
        public Calculator(int startingResult)
        {
            this.result = startingResult;
        }


        private int result;
        public int Result
        {
            get { return this.result; }
        }
        


        

        /// <summary>
        /// This method adds the provided value to the result
        /// </summary>
        /// <param name="addend">The value to be added to the current result</param>
        /// <returns>The result after adding addend</returns>
        public int Add(int addend)
        {
            this.result += addend;
            return this.result;
        }




        /// <summary>
        /// Subtracts provided value from the result
        /// </summary>
        /// <param name="subtrahend">subtrahend the value to be subtracted from current result</param>
        /// <returns>result after subtracting subtrahend</returns>
        public int Subtract(int subtrahend)
        {
            this.result -= subtrahend;
            return this.result;
        }


        /// <summary>
        /// Multiplies the current result by multiplier
        /// </summary>
        /// <param name="multiplier">the value to multiply the result by</param>
        /// <returns>result after multiplying by multiplier</returns>
        public int Multiply(int multiplier)
        {
            this.result *= multiplier;
            return this.result;
        }


        /// <summary>
        /// Raises the current result by the power of exponent. Negative exponents not supported.
        /// If negative is provided treat it as though it were positive (i.e. uses the Absolute value)
        /// </summary>
        /// <param name="exponent">The power to raise by</param>
        /// <returns>Current result raised by the power of exponent</returns>
        public int Power(int exponent)
        {
            this.result = (int)Math.Pow(this.result, exponent);
            return this.result;
        }


        /// <summary>
        /// Resets the result value to 0
        /// </summary>
        public void Reset()
        {
            this.result = 0;
        }

    }
}
