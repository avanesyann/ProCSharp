namespace EmployeeApp
{
    class Employee
    {
        // Members of a class that represent an object's state should not be marked as public.

        private string _empName;                // backing field
        private int _empId;                     // backing field
        private float _currPay;                 // ...
        private int _empAge;                    // ..
        private string _empSSN;
        private EmployeePayTypeEnum _payType;
        private DateTime _hireDate;

        public Employee() { }
        public Employee(string name, int id, float pay, string empSsn) : this(name, 0, id, pay, empSsn, EmployeePayTypeEnum.Salaried) { }
        public Employee(string name, int age, int id, float pay, string empSsn, EmployeePayTypeEnum payType)
        {
            Name = name;
            Age = age;
            Id = id;
            Pay = pay;
            SocialSecurityNumber = empSsn;
            PayType = payType;
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
        public string SocialSecurityNumber
        {
            get { return _empSSN; }
            private set { _empSSN = value; }
        }
        public EmployeePayTypeEnum PayType
        {
            get => _payType;
            set => _payType = value;
        }
        public DateTime HireDate
        {
            get => _hireDate;
            set => _hireDate = value;
        }

        public void GiveBonus(float amount)
        {
            Pay = this switch
            {
                { Age: >= 18, PayType: EmployeePayTypeEnum.Commission,  HireDate: { Year: > 2020 } } => Pay += .10F * amount,
                { Age: >= 18, PayType: EmployeePayTypeEnum.Hourly,      HireDate: { Year: > 2020 } } => Pay += 40F * amount / 2080F,
                { Age: >= 18, PayType: EmployeePayTypeEnum.Salaried,    HireDate: { Year: > 2020 } } => Pay += amount,
                _ => Pay += 0
            };
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", _empName);
            Console.WriteLine("ID: {0}", _empId);
            Console.WriteLine("Pay: {0}", _currPay);
        }
    }
}
