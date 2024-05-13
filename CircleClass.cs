using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace CircleObjects
{
    class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateDiameter()
        {
            return 2 * radius;
        }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public void Grow()
        {
            radius *= 2;
        }

        public double GetRadius()
        {
            return radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            bool isValidInput;

            // Get user input for radius
            do
            {
                Console.Write("Enter the radius of the circle: ");
                string input = Console.ReadLine();

                isValidInput = double.TryParse(input, out radius);

                if (!isValidInput || radius <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid positive number.");
                }

            } while (!isValidInput || radius <= 0);

            // Create Circle object
            Circle circle = new Circle(radius);

            // Display calculations
            Console.WriteLine($"Diameter: {circle.CalculateDiameter()}");
            Console.WriteLine($"Circumference: {circle.CalculateCircumference()}");
            Console.WriteLine($"Area: {circle.CalculateArea()}");

            // Ask if the circle should grow
            Console.Write("Do you want the circle to grow (yes/no)? ");
            string response = Console.ReadLine();

            if (response.ToLower() == "yes")
            {
                circle.Grow();
                Console.WriteLine($"Circle has grown. New radius: {circle.GetRadius()}");
            }
            else
            {
                Console.WriteLine($"Goodbye! Radius of the circle: {circle.GetRadius()}");
            }
        }
    }
}
