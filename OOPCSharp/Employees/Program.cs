using Employees;

Console.WriteLine("***** The Employee Class Hierarchy *****\n");
SalesPerson fred = new SalesPerson
{
    Age = 31,
    Name = "Fred",
    SalesNumber = 50
};

Manager chucky = new Manager("Chucky", 50, 92, 1000000, "333-23-2322", 9000);