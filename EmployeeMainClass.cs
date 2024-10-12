using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public double Sal { get; set; }

        public Employee(int empId, string name, double sal)
        {
            EmpId = empId;
            Name = name;
            Sal = sal;
        }
        /// <summary>
        /// Method to calculate total salary according to Overtime work 1000 per hour
        /// </summary>
        /// <param name="empId">int type EmpId</param>
        /// <param name="Sal">double type employee sal</param>
        /// <param name="Hours">float type No. of Hours</param>
        /// <returns></returns>
        public double TotalSal(int empId,double Sal,float Hours)
        {
            return Sal +(1000* Hours);
        }
    }
    internal class EmployeeMainClass
    {
        public static void Main(string[] args)
        {
            Employee employee1 = new Employee(1,"Arun",70000);
            double TotalSalary=employee1.TotalSal(1, 70000, 5);
            Console.WriteLine(TotalSalary);
        }
    }
}
