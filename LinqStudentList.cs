using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{
    public class StudentData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }

        public StudentData(int Id,string Name,int Grade)
        {
            this.Id = Id;
            this.Name = Name;
            this.Grade = Grade;
        }
    }
    internal class LinqStudentList
    {
        public static void Main(string[] args)
        {
            List<StudentData> students = new List<StudentData>();
            students.Add(new StudentData ( 1, "Arun", 95 ));
            students.Add(new StudentData(2, "Anusha", 99));
            students.Add(new StudentData(3, "Nick", 75));
            students.Add(new StudentData(4, "Harry", 50));
            students.Add(new StudentData(5, "Jhon", 88));
            Console.WriteLine("Students data");
            foreach(var student in students)
            {
                Console.WriteLine(student.Id+ "  "+student.Name+" "+ student.Grade);
            }
            Console.WriteLine();
            Console.WriteLine("Students who scored above 80 using LINQ");
            var Toppers = from student in students
                          where student.Grade > 80
                          select student;
            foreach (var student in Toppers)
            {
                Console.WriteLine(student.Id + "  " + student.Name + " " + student.Grade);
            }
        }  
    }
}
