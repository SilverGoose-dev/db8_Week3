double radius = 0;
int circleCount = 0;


Console.WriteLine("===============================");
Console.WriteLine(" Welcome to the Circle Tester!");
Console.WriteLine("===============================");
do
{
	bool isValid = false;
	while (!isValid)
    {
		Console.Write("Please insert a radius of a circle:  ");
		string radiusStr = Console.ReadLine();
		radius = 0;
		isValid = double.TryParse(radiusStr, out radius);
		if (!isValid)
        {
            Console.WriteLine("That is not a number!");
			isValid = false;
        }
        else
        {
			isValid = true;
		}
	}
	

	Circle circle = new Circle(radius); //This is where the circle is actually created 
	Console.WriteLine($"\nThe circumference is: {circle.CalculateCircumference()}");
	Console.WriteLine($"The area is: {circle.CalculateArea()}{circleCount++}");
} while (KeepGoing());
Console.WriteLine($"Goodbye! You created {circleCount} circles!");



static bool KeepGoing()
{
	while (true)
	{
		// Print out message asking if user wants to continue
		Console.WriteLine("\nWould you like to go again? (y/n)");
		// Ask the user for their input
		string response = Console.ReadLine();
		response = response.ToLower();
		// Check if they typed "y". If so, return true.
		// Otherwise return false.   YES   yes
		if (response == "y" || response == "yes")
		{
			return true;
		}
		else if (response == "n" || response == "no")
		{
			return false;
		}
		else
		{
			Console.WriteLine("Please enter y or n");
		}
	}
}


class Circle
{
    public double radius; //what the object has in it
    
    public Circle(double _radius) //Constructor
    {
        radius = _radius; 
    }


    public double CalculateCircumference() //Attributes and capabilities
    {
        double circumference = Math.PI * radius;
        return Math.Round(circumference, 2);
        

    }
    public double CalculateArea()         //Attributes and capabilities
	{
        double area = (Math.PI * radius * radius);
        return Math.Round(area, 2);
    }

}

