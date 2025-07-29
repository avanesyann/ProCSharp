namespace ObjectOverrides
{
    // Remember! Person extends object.
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string fName, string lName, int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
        }
        public Person() { }

        // public override string ToString() => $"[First Name: {FirstName}; Last Name: {LastName}; Age: {Age}]";

        // However, remember that a proper ToString() override
        // should also account for any data defined up the chain of inheritance.

        public override string ToString()
        {
            return base.ToString() + $"[First Name: {FirstName}; Last Name: {LastName}; Age: {Age}]";
        }
    }
}
