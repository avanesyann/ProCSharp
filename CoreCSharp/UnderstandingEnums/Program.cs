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
            Console.WriteLine();

            EmpType emp2 = EmpType.Contractor;
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Gray;

            EvaluateEnum(emp2);
            EvaluateEnum(day);
            EvaluateEnum(cc);

            Console.WriteLine();
            Console.WriteLine();

            ContactPreference emailAndPhone = ContactPreference.Email | ContactPreference.Phone;

            Console.WriteLine("None? {0}", (emailAndPhone | ContactPreference.None) == emailAndPhone);
            Console.WriteLine("Email? {0}", (emailAndPhone | ContactPreference.Email) == emailAndPhone);
            Console.WriteLine("Phone? {0}", (emailAndPhone | ContactPreference.Phone) == emailAndPhone);
            Console.WriteLine("Text? {0}", (emailAndPhone | ContactPreference.Ponyexpress) == emailAndPhone);

            Console.WriteLine();
            Console.WriteLine();

            var prefs = NotificationOptions.Email | NotificationOptions.Push;

            Console.WriteLine(prefs);
            Console.WriteLine(prefs & NotificationOptions.Email);
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
        static void EvaluateEnum(Enum e)
        {
            Console.WriteLine("=> Information about {0}", e.GetType().Name);

            Console.WriteLine("Underlying storage type: {0}", Enum.GetUnderlyingType(e.GetType()));

            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members.", enumData.Length);

            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}", enumData.GetValue(i));
            }
        }

        enum EmpType : byte
        {
            Manager = 101,
            Grunt, 
            Contractor, 
            VicePresident
        }

        [Flags]
        enum ContactPreference
        {
            None = 1, 
            Email = 2,
            Phone = 4,
            Ponyexpress = 6
        }

        [Flags]
        enum NotificationOptions
        {
            None = 0,
            Email = 1,
            SMS = 2,
            Push = 4,
            InApp = 8,
        }
    }
}
