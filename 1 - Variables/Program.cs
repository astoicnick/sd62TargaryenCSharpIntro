using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___Variables
{
    enum DaysOfTheWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
    class Program
    {

        static void Main(string[] args)
        {
            // Declared, not assigned a value
            bool isDeclared;
        // Assign it a value, based on type
        isDeclared = true;

            //-- Characters (char)
            // To define a single character, make sure to use single quotes ('')
            char character = 'a';
            char symbol = '?';
            char number = '7';
            char space = ' ';
            char underscore = '_';
            char specialCharacter = '\n';


            //-- Whole Numbers
            // Here we just have a lot of whole numbers
            // You don't have to go into much detail, it's just nice to show the students there are options
            byte byteExample = 255;
            sbyte sByteMax = -128;
            short shortExample = 32767;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;
            // type name = Value;
            int a = 15;
            int b = -10;

            byte age = 25;

            //-- Decimals
            float floatExample = 1.045231f;
            double doubleExample = 1.789053278907036d;
            decimal decimalExample = 1.2578907289045789789789789787897m;

            float myFloat = 4.503f;
            double myDouble = 4.503d;
            decimal myDecimal = 1.2598m;

            // Notice we can type as much as we want for our types with decimals
            //Console.WriteLine(1.2578907289045789789789789787897f);
            //Console.WriteLine(1.2578907289045789789789789787897d);
            //Console.WriteLine(1.2578907289045789789789789787897m);

            // Structs

            Int16 anotherShortExample;
            anotherShortExample = 50;
            //Console.WriteLine(anotherShortExample);


            //DateTime today = DateTime.Today;

            //int myBirthyear = 2000;
            //int myBirthmonth = 8;
            //int myBirthdate = 29;

            DateTime myBirthday = new DateTime();

            Console.WriteLine("What is your name?");

            // Strings - collections of characters

            string myName = "Nick";
            char letterN = myName[0];

            // Collections
            // Arrays
            string[] stringArray = { "Cozi", "Jenna", "Seth" };
            int[] intArray = new int[4];
            intArray[0] = 1;
            intArray[1] = 20;
            intArray[2] = 30;
            intArray[3] = 40;
            int[] intArray2 = { 1, 21, 34, 59 };

            // Lists
            List<string> townsInNewYork = new List<string> { "Huntington", "Melville", "Syracuse", "Buffalo"  };
            string specificTownInNewYork = townsInNewYork[3];
            foreach (var town in townsInNewYork)
            {
                Console.WriteLine(town);
            }

            Console.WriteLine("////");

            // Dictionaries
            Dictionary<string, int> townsWithTemperatures = new Dictionary<string, int>();
            townsWithTemperatures.Add("Indy", 90);
            townsWithTemperatures.Add("New Yoik", 80);
            townsWithTemperatures.Add("Chicago", 75);
            foreach (var key in townsWithTemperatures.Keys)
            {
                Console.WriteLine(key + ",  " + townsWithTemperatures[key]);
            }
            Console.ReadKey();
        }

    }
}
