
Triangle first = new Triangle(4, 3);
//first.length = 4;
//first.height = 3;
double area = first.GetArea();
Console.WriteLine(area);
Console.WriteLine(first.GetHypotenuse());
Console.WriteLine(first.GetPerimeter());


class Triangle
{
    // We have a package, like a capsule
    // The verb we user is "encapsulate"
    // We've packaged together length and height
    // into a triangle concept.
    // We have "encapsulated" length and heign into our triangle. 

    public double length;
    public double height;
    
    // Initializing the data
    //Create a constructor

    public Triangle(double _length, double _height) // This is the setup for the class methods
    {
        length = _length;
        height = _height;
    }

    public double GetArea()
    {
        return length * height / 2;
    }

    public double GetHypotenuse()
    {
        return Math.Sqrt(length * length + height * height);
    }

    public double GetPerimeter()
    {
        return length + height + GetHypotenuse();
    }
    
}