
// firstpen is an object that has inside it four variables.

Pen firstpen = new Pen();
firstpen.InkColor = "Blue";
firstpen.Length = 4.5;
firstpen.PointType = "Gel";
firstpen.PointSize = "Small";
firstpen.InkAmount = 5;

Console.WriteLine(firstpen.InkColor);
Console.WriteLine(firstpen.Length);
Console.WriteLine(firstpen.PointType);
Console.WriteLine(firstpen.PointSize);
Console.WriteLine(firstpen.InkAmount);

Console.WriteLine("Let's draw with first pen");
firstpen.Draw();
Console.WriteLine($"The ink is now {firstpen.InkAmount}");
Console.WriteLine();

Pen secondpen = new Pen();
secondpen.InkColor = "Red";
secondpen.Length = 4.5;
secondpen.PointType = "Ball Point";
secondpen.PointSize = "Medium";
secondpen.InkAmount = 2;

Console.WriteLine(secondpen.InkColor);
Console.WriteLine(secondpen.Length);
Console.WriteLine(secondpen.PointType);
Console.WriteLine(secondpen.PointSize);
Console.WriteLine(secondpen.InkAmount);

Console.WriteLine("Let's do two drawings with second pen");
secondpen.Draw();
secondpen.Draw();

Console.WriteLine($"Second pen now has ink level {secondpen.InkAmount}");
Console.WriteLine($"First pen still has ink level {firstpen.InkAmount}");
Console.WriteLine();
Console.WriteLine("Now we have a refill method");
secondpen.Refill();
Console.WriteLine($"Second pen now has ink level {secondpen.InkAmount}");

Console.WriteLine();
Console.WriteLine("Let's refill firstpen with green ink");
firstpen.Refill("green");
Console.WriteLine($"First pen has ink {firstpen.InkColor} and has {firstpen.InkAmount} ink");




Console.WriteLine();
Pen thirdpen = new Pen();
Console.WriteLine(thirdpen.InkAmount);

Console.WriteLine();
Pen fourthpen = new Pen("green");
Console.WriteLine();
Console.WriteLine($"{fourthpen.InkAmount}");
Console.WriteLine($"{fourthpen.InkColor}");
class Pen
{
    // Member variables
    public string InkColor;
    public double Length;
    public string PointType;
    public string PointSize;
    public int InkAmount;

    public Pen()  // constructor
    {
        InkAmount = 10;
        InkColor = "black";
    }

    public Pen(string _InkColor) //This is best practice as we want the info to be passed in immediately
    {
        InkColor = _InkColor;
        InkAmount = 10;
    }

    //Member methods
    public void Draw()
    {
        if (InkAmount > 0)
        {
            InkAmount--;
        }
    }

    public void Refill()
    {
        InkAmount = 10;
    }

    //Let's add another refill function that lets us specify ink color

    public void Refill(string newcolor)
    {
        InkColor = newcolor;
        InkAmount = 10;
    }

}