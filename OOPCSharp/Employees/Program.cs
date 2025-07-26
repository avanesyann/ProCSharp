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
static void CastingExamples()
{
    // A Manager "is-a" System.Object, so we can
    // store a Manager reference in an object variable just fine.
    object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);

    // A Manager "is-an" Employee too.
    Employee moonUnit = new Manager("MoonUnit Zapa", 2, 3001, 20000, "101-11-1010", 1);

    // A PtSalesPerson "is-a" SalesPerson.
    SalesPerson jill = new SalesPerson("Jill", 32, 3002, 10000, "111-12-1119", 90);


    object john = new Manager("John", 34, 3003, 50000, "111-13-1113", 4);
    // Error!
    // GivePromotion(john);

    // (ClassIWantToCastTo)ReferenceIHave
    GivePromotion((Manager)john);
}
static void GivePromotion(Employee emp)
{
    Console.WriteLine("{0} was promoted!", emp.Name);
}