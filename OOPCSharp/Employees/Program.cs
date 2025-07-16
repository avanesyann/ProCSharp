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
fran.GiveBonus(200);
fran.DisplayStats();
Console.WriteLine();

// For this reason, using the virtual and override keywords comes handy.
// ...