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

            int sum = AddTwoNumbers(1, 2);
            int difference = SubtractTwoNumbers(5, 3);
            int product = MultiplyTwoNumbers(2, 5);
            int quotient = DivideTwoNumbers(10, 2);

            Console.WriteLine(sum);
            Console.WriteLine(difference);
            Console.WriteLine(DivideTwoNumbers(6, 3));
            Console.WriteLine(MultiplyTwoNumbers(5, 2));
        }
        // access-modifier return-type name/signature (params)
        private int AddTwoNumbers(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
        private int SubtractTwoNumbers(int num1, int num2)
        {
            return num1 - num2;
        }
        private int MultiplyTwoNumbers(int num1, int num2)
        {
            return num1 * num2;
        }
        private int DivideTwoNumbers(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
