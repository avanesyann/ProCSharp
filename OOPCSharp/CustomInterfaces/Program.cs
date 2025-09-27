using CustomInterfaces;

Console.WriteLine("***** A First Look at Interfaces *****\n");
CloneableExample();

// Illegal to allocate interface types.
// IPointy p = new IPointy();

Hexagon hex = new Hexagon();
Console.WriteLine("Points: {0}", hex.Points);

// Catch a possible InvalidCastException
Circle c = new Circle("Lisa");
IPointy itfPt = null;

try
{
    itfPt = (IPointy)c;
    Console.WriteLine(itfPt.Points);
}
catch (InvalidCastException e)
{
    Console.WriteLine(e.Message);
}

Hexagon hex2 = new Hexagon("Peter");
IPointy itfPt2 = hex2 as IPointy;

if (itfPt2 != null)
{
    Console.WriteLine("Points: {0}", itfPt.Points);
}
else
{
    Console.WriteLine("OOPS! Not pointy...");
}

Hexagon hex3 = new Hexagon("Sona");
if (hex3 is IPointy itfPt3)
{
    Console.WriteLine("Points: {0}", itfPt3.Points);
}
else
{
    Console.WriteLine("OOPS! Not pointy...");
}



var sq = new Square("Boxy") { NumberOfSides = 4, SideLength = 4 };
sq.Draw();
// the Square instance must be explicitly cast to the IRegularPointy inetrface

Console.WriteLine($"{sq.PetName} has {sq.NumberOfSides} of length {sq.SideLength} and a perimeter of {((IRegularPointy)sq).Perimeter}");

// one option to get around this problem is to always code to the inetrface of a type
IRegularPointy sq2 = new Square("Roxy") { NumberOfSides = 4, SideLength = 4 };

Console.WriteLine($"Example property: {IRegularPointy.ExampleProperty}");
IRegularPointy.ExampleProperty = "Updated";
Console.WriteLine($"Example property: {IRegularPointy.ExampleProperty}");


static void CloneableExample()
{
    // All of these classes support the ICloneable interface.
    string myStr = "Hello";
    OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());

    // Therefore, they can all be passed into a method taking ICloneable.
    CloneMe(myStr);
    CloneMe(unixOS);

    static void CloneMe(ICloneable c)
    {
        // Clone whatever we get and print out the name.
        object theClone = c.Clone();
        Console.WriteLine("Your clone is a: {0}", theClone.GetType().Name);
    }
}
static IPointy FindFirstPointyShape(Shape[] shapes)
{
    foreach (var shape in shapes)
    {
        if (shape is IPointy ip)
        {
            return ip;
        }
    }
    return null;
}