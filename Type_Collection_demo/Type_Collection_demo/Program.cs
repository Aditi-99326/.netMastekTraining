using System;



namespace Type_collection_demo
{



    struct Employee
    {
        public int EmpNo;
        public string EmpName;
        public double Salary;
        
        public double AnnualSalary()
        {
            return Salary * 12;
        }
        public Employee(int eno, string name, double amount)
        {
            this.EmpNo = eno;
            this.EmpName = name;
            this.Salary = amount;
        }

        public override string ToString()
        {
            return string.Format($"Empno : {EmpNo} Employee Name : {EmpName} Salary : {Salary}");
        }
    }

    enum Month
    {
        jan=1, feb, mar, apr, may, jun, jul, aug, sept, oct, nov,dec
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(101, "aditi", 10000);
            Console.WriteLine("Annual Salary" + employee.AnnualSalary());
            Console.WriteLine(employee);

            //---------enum

            Console.WriteLine(DayOfWeek.Wednesday + " : " + (int) DayOfWeek.Wednesday);

            Console.WriteLine(Month.oct + " : " + (int)Month.oct);
        }
    }
}
