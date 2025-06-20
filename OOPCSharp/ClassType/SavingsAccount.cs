using System.Collections.Concurrent;

namespace ClassType
{
    class SavingsAccount
    {
        public double currBalance;
        private static double _currInterestRate;

        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }
        static SavingsAccount()                             // The static constructor executes before any instance-level constructors.
        {
            Console.WriteLine("In static constructor!");
            _currInterestRate = 0.4;
        }
        public static double InterestRate
        {
            get { return _currInterestRate; }
            set { _currInterestRate = value; }
        }

        /* public static void SetInterestRate(double newRate)
        {
            _currInterestRate = newRate;
        }
        public static double GetInterestRate() => _currInterestRate; */
    }
}
