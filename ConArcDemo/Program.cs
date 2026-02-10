using ConArcDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConArcDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentDAO sObj = new StudentDAO();

            Console.WriteLine("List of all the students:");
            List<Student> stu = sObj.ShowAllStudent();
            foreach (Student s in stu)
            {
                Console.WriteLine(s.Name);
            }

            Console.WriteLine();
            Console.WriteLine("All the students named 'Rohit Kumar' :");
            List<Student> studList = sObj.ShowStudentbyName("Rohit Kumar");
            foreach (Student s in studList)
            {
                Console.WriteLine(s.Name);
            }

        }
    }
}