using System;
using System.Linq;



using System.Collections.Generic;



namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array
            //int[] numbers = { 44, 55, 66, 77, 88, 99 };
            ////declarative
            //int[] evendata = (from n in numbers
            // where n % 2 == 0
            // select n).ToArray();



            ////method
            //int[] evendatausingMethod = numbers.Where(n => n % 2 == 0).ToArray();
            //for (int i = 0; i < evendata.Length; i++)
            //{
            // Console.WriteLine(evendata[i]);
            //}
            //Console.WriteLine("\n Using Method \n");
            //for (int i = 0; i <evendatausingMethod.Length; i++)
            //{
            // Console.WriteLine(evendatausingMethod[i]);
            //}




            #endregion



            #region List




            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { EmpNo = 101, EmpName = "bhavana", Address = "mumbai", Dept = "hr", Salary = 15000 });
            empList.Add(new Employee() { EmpNo = 102, EmpName = "amit", Address = "mumbai", Dept = "sales", Salary = 25000 });
            empList.Add(new Employee() { EmpNo = 103, EmpName = "vishal", Address = "pune", Dept = "sales", Salary = 20000 });
            empList.Add(new Employee() { EmpNo = 104, EmpName = "priya", Address = "mumbai", Dept = "hr", Salary = 30000 });
            empList.Add(new Employee() { EmpNo = 105, EmpName = "asha", Address = "mumbai", Dept = "sales", Salary = 30000 });
            empList.Add(new Employee() { EmpNo = 106, EmpName = "pankaj", Address = "pune", Dept = "hr", Salary = 35000 });
            empList.Add(new Employee() { EmpNo = 107, EmpName = "anil", Address = "mumbai", Dept = "sales", Salary = 18000 });
            empList.Add(new Employee() { EmpNo = 108, EmpName = "preeti", Address = "pune", Dept = "hr", Salary = 25000 });



            #endregion


            //1 all emp

            Console.WriteLine("Query1");
            foreach (Employee item in empList)
            {
                Console.WriteLine(item);
            }

            IEnumerable<Employee> query1 = from e in empList select e;


            //2 emp in sales dept
            IEnumerable<Employee> query2 = from e in empList
                                           where e.Dept == "sales"
                                           select e;
            Console.WriteLine("Query2");
            foreach (Employee item in query2)
            {

                Console.WriteLine(item);
            }



            //3 list all emps who are earning more then 25000
            IEnumerable<Employee> query3 = from e in empList
                                           where e.Salary > 25000
                                           select e;
            Console.WriteLine("Query3");
            foreach (Employee item in query3)
            {



                Console.WriteLine(item);
            }


            //query3 = empList.Where(e => e.Salary > 25000);



            //4 list all emps who are staying in mumbai and working for hr dept
            IEnumerable<Employee> query4 = from e in empList
                                           where e.Address == "mumbai" && e.Dept == "hr"
                                           select e;
            Console.WriteLine("Query4");
            foreach (Employee item in query4)
            {



                Console.WriteLine(item);
            }


            //query4 = empList.Where(e => e.Address == "mumbai" && e.Dept == "hr");


            //5 list all emps whose name begins with p

            //defered query
            IEnumerable<Employee> query5 = from e in empList
                                           where e.EmpName.StartsWith('p')
                                           select e;

            

            empList.Add(new Employee() { EmpNo = 201, EmpName = "peter", Address = "pune", Dept = "hr", Salary = 25000 });

            Console.WriteLine("-------------Linq query output---------------");
            foreach (Employee item in query5)
            {

                Console.WriteLine(item);
            }


            empList.Add(new Employee() { EmpNo = 301, EmpName = "peter", Address = "pune", Dept = "hr", Salary = 25000 });

            Console.WriteLine("-------------Linq query output------------");
            //deferd execution
            foreach (Employee item in query5)
            {

                Console.WriteLine(item);
            }


            /*Console.WriteLine("Query5");
            foreach (Employee item in query5)
            {

                Console.WriteLine(item);
            }*/

            //query5 = empList.Where(e => e.EmpName.StartsWith("p"));

            /*Console.WriteLine("--------immediate execution-----");

            //6 list emp whose empno is 102

            //Employee emp = (from e in empList where e.EmpNo == 102 select e).Single();

            Employee emp = (from e in empList where e.Address == "mumbai" select e).FirstOrDefault();

            emp = empList.Where(e => e.EmpNo == 102).FirstOrDefault();

            emp = empList.FirstOrDefault(e => e.EmpNo == 102);

            Console.WriteLine("Employee : " + emp);

                           //First : return first element of sequence or throw a exception
                           //FirstOrDefault : -//- or return default value
                           //Single : -//- return single value
                           //SingleOrDefault : -//- return default value */


            //specific Column selection

            //list empname , dept, salary
            //list empname and salary
            //list empno and salary
            IEnumerable<Employee> query7 = from e in empList select e;
            //known type
            //Emplyee emp = new Employee();


            //annonymous type: new {} (no class name)
            //var : --implicitly typed local variable
            //var emp1 = new { emp.EmpName, emp.Dept, emp.Salary };

            //anonymous type and var - implicitly typed local variable
            var query8 = from e in empList select new { e.EmpName, e.Salary, e.Dept };

            //query8 = empList.Select(e => new { e.EmpName, e.Dept, e.Salary});

            //method syntax
            // query8 = empList.Select(e => new { e.EmpName,Department= e.Dept, });

             foreach (var item in query8)
             {
                 Console.WriteLine(item.EmpName + " " + item.Dept + " " + item.Salary);
             }


            //list all emp name and salary who are earning between 20000 t0 30000

            var query9 = from e in empList where e.Salary >= 20000 && e.Salary <= 30000 select new { e.EmpName, e.Salary };

            query9 = empList.Where(e => e.Salary >= 20000 && e.Salary <= 30000).Select(e => new { e.EmpName, e.Salary });


            foreach (var item in query9)
            {
                Console.WriteLine(item.EmpName + " " + item.Salary);
            }


        }
    }
}
