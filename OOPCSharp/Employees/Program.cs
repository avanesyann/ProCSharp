using Employees;

Console.WriteLine("***** The Employee Class Hierarchy *****\n");
SalesPerson fred = new SalesPerson
{
    Age = 31,
    Name = "Fred",
    SalesNumber = 50
};

Manager chucky = new Manager("Chucky", 50, 92, 1000000, "333-23-2322", 9000);

double cost = chucky.GetBenefitCost();
Console.WriteLine($"Benefit Cost: {cost}");

Employee.BenefitPackage.BenefitPackageLevel myBenefitLevel = Employee.BenefitPackage.BenefitPackageLevel.Platinum;


// The publicly inherited GiveBonus() method operates identically for all subclasses.
// Ideally, the bonus of a salesperson should consider the number of sales.
chucky.GiveBonus(300);
chucky.DisplayStats();
Console.WriteLine();

SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
fran.GiveBonus(100);
fran.DisplayStats();
Console.WriteLine();

// For this reason, using the virtual and override keywords comes handy.
// ...


// Cannot create an instance of an abstract class.
// Employee employee = new Employee();


CastingExamples();

object frank = new Manager("Frank Zapp", 9, 3003, 40000, "111-11-1111", 5);
Hexagon hex;

try
{
    hex = (Hexagon)frank;
}
catch (InvalidCastException ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine();

// use "as" to test compatibility
object[] things = new object[4];
things[0] = new Hexagon();
things[1] = false;
things[2] = new Manager("John Doe", 9, 0001, 40000, "111-11-1111", 5);
things[3] = "Last thing";

foreach (object item in things)
{
    Hexagon h = item as Hexagon;
    if (h == null)
    {
        Console.WriteLine("Item is not a hexagon");
    }
    else
    {
        h.Draw();
    }
}


static void CastingExamples()
{
    // A Manager "is-a" System.Object, so we can
    // store a Manager reference in an object variable just fine.
    object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);

    // A Manager "is-an" Employee too.
    Employee moonUnit = new Manager("MoonUnit Zapa", 2, 3001, 20000, "101-11-1010", 1);

    // A PtSalesPerson "is-a" SalesPerson.
    SalesPerson jill = new SalesPerson("Jill", 32, 3002, 10000, "111-12-1119", 90);

    Hexagon hexagon = new Hexagon();


    object john = new Manager("John", 34, 3003, 50000, "111-13-1113", 4);
    // Error!
    // GivePromotion(john);

    // (ClassIWantToCastTo)ReferenceIHave
    GivePromotion((Manager)john);
    GivePromotion(jill);
}
/*static void GivePromotion(Employee emp)
{
    if (emp is not Manager and not SalesPerson)
    {
        Console.WriteLine("Unable to promote {0}. Wrong employee type", emp.Name);
    }
    else
    {
        Console.WriteLine("{0} was promoted!", emp.Name);
    }

    if (emp is SalesPerson)
    {
        Console.WriteLine("{0} made {1} sale(s)!", emp.Name, ((SalesPerson)emp).SalesNumber);
        Console.WriteLine();
    }
    else if (emp is Manager m)
    {
        Console.WriteLine("{0} had {1} stock options...", m.Name, m.StockOptions);
        Console.WriteLine();
    }
    // this final statement will catch any Employee instance that is not Manager, SalesPerson, PtSalesPerson
    else if (emp is var _)
    {
        Console.WriteLine("Unable to promote {0}. Wrong employee type", emp.Name);
        Console.WriteLine();
    }
}*/

// Pattern matching switch statement
static void GivePromotion(Employee emp)
{
    Console.WriteLine("{0} was promoted!", emp.Name);
    switch (emp)
    {
        case SalesPerson s when s.SalesNumber > 5:
            Console.WriteLine("{0} made {1} sale(s)!", emp.Name, s.SalesNumber);
            break;
        case Manager m:
            Console.WriteLine("{0} had {1} stock options...", emp.Name, m.StockOptions);
            break;
        case Employee _:
            Console.WriteLine("Unable to promote {0}. Wrong employee type", emp.Name);
            break;
    }
    Console.WriteLine();
}