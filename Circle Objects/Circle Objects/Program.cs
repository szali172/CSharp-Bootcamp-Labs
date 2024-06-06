using Circle_Objects;

Console.WriteLine("Welcome to the Circle Tester");

while (true)
{  
    Console.Write("Enter a radius: ");

    try
    {
        double radius = double.Parse(Console.ReadLine());
        Circle circle = new Circle(radius);
        Console.WriteLine($"Diameter: {circle.CalculateDiameter()}");
        Console.WriteLine($"Circumference: {circle.CalculateCircumference()}");
        Console.WriteLine($"Area: {circle.CalculateArea()}");

        while (true)
        {
            Console.WriteLine("Should the circle grow? (y/n)");

            try
            {
                string input = Console.ReadLine();

                if(input == "y")
                {
                    circle.Grow();
                    Console.WriteLine($"Diameter: {circle.CalculateDiameter()}");
                    Console.WriteLine($"Circumference: {circle.CalculateCircumference()}");
                    Console.WriteLine($"Area: {circle.CalculateArea()}");
                }
                else
                {
                    Console.WriteLine("Goodbye. The circle's final radius is " + circle.GetRadius());
                    return;
                }

            } catch
            {
                Console.WriteLine("Please enter either \"y\" or \"n\"");
            }

        }
        

    } catch
    {
        Console.WriteLine("Please pass a valid number for the radius");
    }
    
}
