using System;
using _2___Conditionals_Methods_Loops;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MethodsAndClasses
{
    [TestClass]
    public class MethodTests
    {
        // Modulus %

        [TestMethod]
        public void CalculatorTest()
        {
            // Create four methods:
            // One for each function below
            // Addition +
            // Subtraction -
            // Multiplication *
            // Division /
            // Call each method in your main test method, using new numbers each time
            // Console.WriteLine(subtractTwoNumbers(5,1))
            // BONUS: Create a method that finds the remainder of two numbers
            // BONUS: Create overloads that accept int, float, double, decimal for parameters

            Console.WriteLine(AddTwoNumbersAndReturnSum(1.5d, 1.5d));

        }
        // access-modifier return-type name/signature (params)
        private int AddTwoNumbersAndReturnSum(int num1, int num2)
        {
            return num1 + num2;
        }
        private double AddTwoNumbersAndReturnSum(double num1, double num2)
        {
            return num1 + num2;
        }
        private decimal AddTwoNumbersAndReturnSum(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
    }
}
