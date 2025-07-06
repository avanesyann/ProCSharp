using FunWithRecords;

Car porsche = new Car()
{
    Make = "Porsche",
    Model = "911",
    Color = "Black"
};

porsche.DisplayStats();
Console.WriteLine();

Car lexus = new Car("Lexus", "IS", "Silver");

lexus.DisplayStats();
Console.WriteLine();

Console.WriteLine("*** Records ***");
CarRecord mercedes = new CarRecord
{
    Make = "Mercedes-Benz",
    Model = "S-Class",
    Color = "Black"
};
mercedes.DisplayStats();
Console.WriteLine();

CarRecord bmw = new CarRecord("BMW", "M4", "Dark Gray");
bmw.DisplayStats();
Console.WriteLine();
