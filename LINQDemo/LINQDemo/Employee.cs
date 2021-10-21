using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LINQDemo
{
    class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string Address { get; set; }
        public string Dept { get; set; }
        public double Salary { get; set; }



        public override string ToString()
        {
            return string.Format($"Empno = {EmpNo} Employee Name = {EmpName} Address = {Address} Departement = {Dept} Salary = {Salary}");
        }
    }
}
