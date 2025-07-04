namespace ConstData
{
    class MyMathClass
    {
        public const double PI = 3.14159;
        public readonly double ROPI;
        public static readonly double SROPI;

        public MyMathClass()
        {
            ROPI = 3.14;
        }
        static MyMathClass()
        {
            SROPI = 3.14;
        }
    }
}
