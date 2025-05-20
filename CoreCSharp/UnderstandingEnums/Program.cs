namespace UnderstandingEnums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EmpType.Manager);
            Console.WriteLine((int)EmpType.Contractor);
            Console.WriteLine();

            EmpType emp = EmpType.VicePresident;
            AskForBonus(emp);
            AskForBonus(EmpType.Contractor);
            Console.WriteLine(Enum.GetUnderlyingType(emp.GetType()));
            Console.WriteLine(Enum.GetUnderlyingType(typeof(EmpType)));
        }


        static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options?");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You've got to be kidding...");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already got enough cash.");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("Very Good, Sir!");
                    break;
            }
        }
        enum EmpType : byte
        {
            Manager = 101,
            Grunt, 
            Contractor, 
            VicePresident
        }
    }
}
