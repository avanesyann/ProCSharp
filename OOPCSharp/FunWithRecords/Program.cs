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
//CarRecord mercedes = new CarRecord
//{
//    Make = "Mercedes-Benz",
//    Model = "S-Class",
//    Color = "Black"
//};
//mercedes.DisplayStats();
//Console.WriteLine();

CarRecord bmw = new CarRecord("BMW", "M4", "Dark Gray");
bmw.Deconstruct(out string make, out string model, out string color);
Console.WriteLine("Make: {0}, Model: {1}, Color: {2}", bmw.Make, bmw.Model, bmw.Color);
Console.WriteLine("Deconstructed - Make: {0}, Model: {1}, Color: {2}", make, model, color);
Console.WriteLine();

// Tuples syntax
var (make2, model2, color2) = bmw;
//(string make2, string model2, string color2) = bmw;
Console.WriteLine("Deconstructed - Make: {0}, Model: {1}, Color: {2}", make2, model2, color2);