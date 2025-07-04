﻿namespace EmployeeApp
{
    partial class Employee
    {
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
