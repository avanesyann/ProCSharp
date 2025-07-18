namespace Employees
{
    // Employee nests BenefitPackage.
    partial class Employee
    {
        // BenefitPackage nests BenefitPackageLevel.
        public class BenefitPackage
        {
            public enum BenefitPackageLevel
            {
                Standard, Gold, Platinum
            }
            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }

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

        public virtual void GiveBonus(float amount)
        {
            Pay = this switch
            {
                { Age: >= 18, PayType: EmployeePayTypeEnum.Commission, HireDate: { Year: > 2020 } } => Pay += .10F * amount,
                { Age: >= 18, PayType: EmployeePayTypeEnum.Hourly, HireDate: { Year: > 2020 } } => Pay += 40F * amount / 2080F,
                { Age: >= 18, PayType: EmployeePayTypeEnum.Salaried, HireDate: { Year: > 2020 } } => Pay += amount,
                _ => Pay += 0
            };
        }
        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", EmpName);
            Console.WriteLine("ID: {0}", EmpId);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);

        }

        // Expose certain benefit behaviors of object.
        public double GetBenefitCost() => EmpBenefits.ComputePayDeduction();

        // Expose object thorugh a custom property
        public BenefitPackage Benefits
        {
            get { return Benefits; }
            set { Benefits = value; }
        }
    }
}
