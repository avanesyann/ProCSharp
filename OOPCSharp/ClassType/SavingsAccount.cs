using System.Collections.Concurrent;

namespace ClassType
{
    class SavingsAccount
    {
        public static double currInterestRate;
        public double currBalance;

        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }
        static SavingsAccount()                             // The static constructor executes before any instance-level constructors.
        {
            Console.WriteLine("In static constructor!");
            currInterestRate = 0.4;
        }

        public static void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }
        public static double GetInterestRate() => currInterestRate;
    }
}
