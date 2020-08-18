using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Conditionals_Methods_Loops
{
    enum Genders { Male = 1, Female = 2, NonBinary = 3 }
    class Program
    {
        static void Main(string[] args)
        {
            bool nickIsTired = true;
            if (nickIsTired)
            {
                //Console.WriteLine("Go to bed!");
            }
            else
            {
                //Console.WriteLine("Keep goin bud");
            }

            int legalAge = 18;
            Console.WriteLine("What is your age?");
            string nicksAgeFromReadLine = Console.ReadLine();
            int nicksAge = Convert.ToInt32(nicksAgeFromReadLine);

            Console.WriteLine("What is your gender? 1 for male, 2 for female, 3 for nonbinary");
            string nicksGenderFromReadLine = Console.ReadLine();
            int nicksGenderValue = Convert.ToInt32(nicksGenderFromReadLine);

            switch (nicksGenderValue)
            {
                // if(nicksGenderValue == 1)
                case 1:
                    Console.WriteLine("You're gender is " + Genders.Male.ToString());
                    break;
                case 2:
                    Console.WriteLine("You're gender is " + Genders.Female.ToString());
                    break;
                case 3:
                    Console.WriteLine("You're gender is " + Genders.NonBinary.ToString());
                    break;
                default:
                    break;
            }

            if (nicksGenderValue == 1)
            {
                Console.WriteLine("You're gender is " + Genders.Male.ToString());

            }
            else if(nicksGenderValue == 2)
            {
                Console.WriteLine("You're gender is " + Genders.Female.ToString());

            }
            else if(nicksGenderValue == 3)
            {
                Console.WriteLine("You're gender is " + Genders.NonBinary.ToString());

            }


            if (nicksAge > legalAge)
            {
                Console.WriteLine("Nick's above the legal age!");
            }
            else if(nicksAge == legalAge)
            {
                Console.WriteLine("He's the legal age");
            }
            else
            {
                Console.WriteLine("He's not at least the legal age");
            }
            Console.ReadKey();

        }
    }
}
