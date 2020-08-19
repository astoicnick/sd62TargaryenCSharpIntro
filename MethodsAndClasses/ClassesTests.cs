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
            // type name = value
            Greeter greeter = new Greeter("Nick Perry");
            greeter.GreetPerson();
        }
    }
}
