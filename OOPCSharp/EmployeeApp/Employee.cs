namespace EmployeeApp
{
    class Employee
    {
        // Members of a class that represent an object's state should not be marked as public.

        private string _empName;
        private int _empId;
        private float _currPay;
        private int _empAge;

        public Employee() { }
        public Employee(string name, int id, float pay) : this(name, 0, id, pay) { }
        public Employee(string name, int age, int id, float pay)
        {
            _empName = name;
            _empAge = age;
            _empId = id;
            _currPay = pay;
        }

        public string Name
        {
            get { return _empName; }
            set
            {
                if (value.Length > 15)      // "value" is a contextual keyword, not a true C# keyword
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else
                {
                    _empName = value;
                }
            }
        }
        public int Id
        {
            get => _empId;
            set => _empId = value;
        }
        public float Pay
        {
            get { return _currPay; }
            set { _currPay = value; }
        }
        public int Age
        {
            get { return _empAge; }
            set { _empAge = value; }
        }

        public void GiveBonus(float amount) => _currPay += amount;
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", _empName);
            Console.WriteLine("ID: {0}", _empId);
            Console.WriteLine("Pay: {0}", _currPay);
        }
    }
}
