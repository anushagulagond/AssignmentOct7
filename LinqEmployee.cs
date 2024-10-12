using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{
    public class EmployeeData
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public double Sal { get; set; }

        public EmployeeData(int empId, string name, double sal)
        {
            this.EmpId = empId;
            this.Name = name;
            this.Sal = sal;
        }
    }
    internal class LinqEmployee
    {
        public static void Main(string[] args)
        {
            List<EmployeeData> employees = new List<EmployeeData>();
            employees.Add(new EmployeeData(1, "Arun", 70000));
            employees.Add(new EmployeeData(2, "Anusha", 80000));
            employees.Add(new EmployeeData(3, "Jhon", 56000));
            employees.Add(new EmployeeData(4, "Nick", 60000));

            Console.WriteLine("List of employees");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Name);
            }
            Console.WriteLine();
            Console.WriteLine("List of employees according to the salary in Desecending order");
            var SalaryDesc = from employee in employees
                             orderby employee.Sal descending
                             select employee;
            foreach (var employee in SalaryDesc)
            {
                Console.WriteLine(employee.EmpId + "  " + employee.Name+"  "+ employee.Sal);
            }
        }
    }
}
