namespace EmployeeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Marvin", 45, 123, 1000, "111-11-1111", EmployeePayTypeEnum.Salaried);
            Console.WriteLine(emp.Pay);
            emp.GiveBonus(100);
            Console.WriteLine(emp.Pay);

            Console.WriteLine();

            emp.Name = "Jarvis";
            emp.Pay = 150_000;
            emp.DisplayStats();

            Console.WriteLine();

            Employee joe = new Employee("Joe", 36, 124, 40, "123-88-9988", EmployeePayTypeEnum.Hourly);
            Console.WriteLine(joe.Pay);
            emp.GiveBonus(100);
            Console.WriteLine(joe.Pay);
        }
    }
}
