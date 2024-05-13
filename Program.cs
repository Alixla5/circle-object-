using System;

class Circle
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double CalculateDiameter()
    {
        return radius * 2;
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
        bool validInput = false;

        do
        {
            Console.Write("Enter the radius of the circle: ");
            string input = Console.ReadLine();
            validInput = double.TryParse(input, out radius);

            if (!validInput || radius <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive number.");
            }

        } while (!validInput || radius <= 0);

        Circle circle = new Circle(radius);

        Console.WriteLine($"Diameter: {circle.CalculateDiameter()}");
        Console.WriteLine($"Circumference: {circle.CalculateCircumference()}");
        Console.WriteLine($"Area: {circle.CalculateArea()}");

        Console.Write("Do you want the circle to grow? (yes/no): ");
        string response = Console.ReadLine();

        if (response.ToLower() == "yes")
        {
            circle.Grow();
            Console.WriteLine("Circle has grown!");
            Console.WriteLine($"New radius: {circle.GetRadius()}");
        }
        else
        {
            Console.WriteLine($"Goodbye! The radius of the circle is {circle.GetRadius()}");
        }
    }
}
