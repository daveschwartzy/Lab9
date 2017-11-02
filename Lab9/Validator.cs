using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Validator
    {
        public static double GetRadius(string prompt)
        {
            double radius = 0;
            bool success = false;
            while (!success)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                success = double.TryParse(input, out radius);
                if (radius <= 0.0)
                {
                    Console.Write("\nInvalid input. Please try again. ");
                    success = false;
                }
            }
            return radius;
        }
        public static bool DoAgain(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.Write("Invalid input. ");
                return DoAgain(prompt);
            }
        }
    }
}
