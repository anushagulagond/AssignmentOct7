using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{
    public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Grade { get; set; }

            public void GetStudentData()
            {
                Console.WriteLine("Enter student Name");
                Name = Console.ReadLine();
                Console.WriteLine("Enter student Age");
                Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter student grade");
                Grade = Console.ReadLine();
            }
            public void DisplayInfo()
            {
                Console.WriteLine("Student Name: " + Name);
                Console.WriteLine("Student Age: " + Age);
                Console.WriteLine("Student Grade: " + Grade);
            }
    
        }
    public class StudentMainClass
    {

        public static void Main(string[] args)
        {
            Student student1=new Student();
            student1.GetStudentData();
            student1.DisplayInfo();
        }
    }
}
