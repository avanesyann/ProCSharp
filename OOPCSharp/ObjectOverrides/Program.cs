namespace ObjectOverrides
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();

            // Use inherited members of System.Object.
            Console.WriteLine("ToString: {0}", p1.ToString());
            Console.WriteLine("Hash Code: {0}", p1.GetHashCode());
            Console.WriteLine("Type: {0}", p1.GetType());

            Person p2 = p1;
            object o = p2;

            // Are the references pointing to the same object in memory?
            if (o.Equals(p1) && p2.Equals(o))
            {
                Console.WriteLine("Same instance!");
            }

            Console.WriteLine(p1.ToString());

            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine();

            // Testing Modified Person Class
            Console.WriteLine("*** Testing Modified Person Class ***");
            Console.WriteLine();
            Person person1 = new Person("Homer", "Simpson", 50, "111-11-1111");
            Person person2 = new Person("Homer", "Simpson", 50, "111-11-1111");

            Console.WriteLine("p1.ToString() = {0}", person1.ToString());
            Console.WriteLine("p2.ToString() = {0}", person2.ToString());

            Console.WriteLine("p1 = p2?: {0}", person1.Equals(person2));

            Console.WriteLine("Same hash codes?: {0}", person1.GetHashCode() == person2.GetHashCode());
            Console.WriteLine();

            person2.Age = 45;
            Console.WriteLine("p1.ToString() = {0}", person1.ToString());
            Console.WriteLine("p2.ToString() = {0}", person2.ToString());

            Console.WriteLine("p1 = p2?: {0}", person1.Equals(person2));

            Console.WriteLine("Same hash codes?: {0}", person1.GetHashCode() == person2.GetHashCode());
            Console.WriteLine();
        }
    }
}
