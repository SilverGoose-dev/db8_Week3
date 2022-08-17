
Triangle first = new Triangle(4, 3);
//first.length = 4;
//first.height = 3;

Console.WriteLine(first.GetArea());
Console.WriteLine(first.GetHypotenuse());
Console.WriteLine(first.GetPerimeter());

//first.height = 10;  This cannot be done as the varaibles in the class are private 

class Triangle
{
    // We have a package, like a capsule
    // The verb we user is "encapsulate"
    // We've packaged together length and height
    // into a triangle concept.
    // We have "encapsulated" length and heign into our triangle. 

    private double length;
    private double height;
    private double area;

    // Initializing the data
    //Create a constructor

    public Triangle(double _length, double _height) // This is the setup for the class methods. You can calculate formulas in the contructor
    {
        length = _length;
        height = _height;
        area = length * height / 2;
    }

    public double GetArea()
    {
        return area;
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