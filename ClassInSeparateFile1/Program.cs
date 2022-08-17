using ClassInSeparateFile1;
Console.WriteLine(Rectangle.Count);

Rectangle rect = new Rectangle("First", 10.1, 20.2);
Console.WriteLine(rect);
Console.WriteLine(Rectangle.Count);


Console.WriteLine();


Rectangle rect2 = new Rectangle("Second", 2.5, 3.6);
Console.WriteLine(rect2);
Console.WriteLine(Rectangle.Count);

Console.WriteLine();

Rectangle rect3 = new Rectangle("Third", 1.1, 2.2);
Console.WriteLine(rect3);


Console.WriteLine(Rectangle.Count);