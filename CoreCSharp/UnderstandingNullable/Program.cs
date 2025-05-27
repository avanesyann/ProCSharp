namespace UnderstandingNullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? nullableInt = 10;
            double? nullableDouble = 3.14;
            bool? nullableBool = null;
            char? nullableChar = 'a';
            int?[] arrayOfNullableInts = new int?[10];

            DatabaseReader dr = new DatabaseReader();

            int? i = dr.GetIntFromDatabase();

            if (i.HasValue)
                Console.WriteLine("Value of 'i' is: {0}", i.Value);
            else
                Console.WriteLine("Value of 'i' is undefined.");

            bool? b = dr.GetBoolFromDatabase();

            if (b != null)
                Console.WriteLine("Value of 'b' is: {0}", b.Value);
            else
                Console.WriteLine("Value of 'b' is undefined.");


            string? nullableString = null;
            TestClass? myNullableClass = null;
#nullable disable
            TestClass anotherNullableClass = null;
        }

    }
    internal class DatabaseReader
    {
        public int? numericValue = null;
        public bool? boolValue = true;

        public int? GetIntFromDatabase() => numericValue;
        public bool? GetBoolFromDatabase() => boolValue;
    }
    internal class TestClass
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
