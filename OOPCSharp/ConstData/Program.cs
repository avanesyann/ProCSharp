namespace ConstData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyMathClass.PI = 3.14;    // can't change constant fields
            Console.WriteLine("Constant String Interpolation:");
            const string foo = "Foo";
            const string bar = "Bar";
            const string foobar = $"{foo}{bar}";
            Console.WriteLine(foobar);

            Console.WriteLine(MyMathClass.SROPI);
        }
    }
}
