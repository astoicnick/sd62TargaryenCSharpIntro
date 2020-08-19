using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndClasses.Classes
{
    class Greeter
    {
        public Greeter(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public void Greet()
        {
            SayHelloUsingName();
        }
        private void SayHelloUsingName()
        {
            Console.WriteLine("Hello there, " + Name);
        }
    }
}
