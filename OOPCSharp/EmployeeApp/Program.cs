namespace EmployeeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Marvin", 456, 30_000);
            emp.GiveBonus(1000);
            emp.DisplayStats();

            Console.WriteLine();

            emp.Name = "Jarvis";
            emp.Pay = 150_000;
            emp.DisplayStats();

            Console.WriteLine();

            Employee joe = new Employee("Joe", 457, 100_000);
            joe.DisplayStats();
        }
    }
}
