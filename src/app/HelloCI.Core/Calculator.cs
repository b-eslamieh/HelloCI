using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCI.Core
{
    /// <summary>
    /// Implements a redundant calculator.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Adds two numbers.
        /// </summary>
        /// <param name="left">Left number</param>
        /// <param name="right">Right number</param>
        /// <returns></returns>
        public double Add(double left, double right)
        {
            return left + right;
        }

        /// <summary>
        /// Subtracts two numbers.
        /// </summary>
        /// <param name="left">Left number</param>
        /// <param name="right">Right number</param>
        /// <returns></returns>
        public double Subtract(double left, double right)
        {
            return left - right;
        }

        /// <summary>
        /// Multiplies two numbers.
        /// </summary>
        /// <param name="left">Left number</param>
        /// <param name="right">Right number</param>
        /// <returns></returns>
        public double Multiply(double left, double right)
        {
            return left * right;
        }
    }
}
