using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Circle
    {
        private double radius;
        private double circumference;
        private double area;

        public static int numCircle = 0;

        public Circle(double radius)
        {
            this.radius = radius;
            numCircle++;
        }

        //methods

        public double GetCircumference()
        {
            circumference = (radius * 2 * Math.PI);
            return circumference;
        }
        public string GetFormattedCircumference()
        {
            return FormatNumber(circumference);
            
        }
        public double GetArea()
        {
            area = (Math.PI * radius * radius);
            return area;
        }
        public string GetFormattedArea()
        {
            return FormatNumber(area);
        }
        private string FormatNumber (double x)
        {
            string value = string.Format("{0:0.00}", x);
            return value;
        }
        public override string ToString()
        {
            return $"Circumference is: {GetFormattedCircumference()}. \nArea is {GetFormattedArea()}.";
        }
    }
}
