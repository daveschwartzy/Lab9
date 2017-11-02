using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class CircleApp
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Welcome to the Circle Tester! Here we take your a radius and output the circumference and area.\n");
                double radius = Validator.GetRadius("Please enter in a radius of a circle: ");
                Circle circle1 = new Circle(radius);

                circle1.GetCircumference();
                circle1.GetArea();
                circle1.GetFormattedCircumference();
                circle1.GetFormattedArea();

                Console.WriteLine(circle1);

                repeat = Validator.DoAgain("Would you like to test another circle? (Y/N)");
            }
            Console.WriteLine($"Goodbye! You tested {Circle.numCircle} circle(s) in the duration of this program.");
            Console.ReadKey();
        }
    }
}
