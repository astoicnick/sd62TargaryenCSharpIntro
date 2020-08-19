using System;
using MethodsAndClasses.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MethodsAndClasses
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void Classes_Intro()
        {
            // Create a class that does one basic thing
            // Adds numbers, Console.WriteLines something
            // Create an instance of the class (in your test class)
            // Run the method you created from the new instance

            Greeter greeter = new Greeter("Nick Perry");
            greeter.Greet();
        }
    }
}
