using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMeetPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>()
            {
                new Employee{EmployeeID=1001, FirstName="Malcolm", LastName="Daruwalla", Title="Manager", DOB=new DateTime(1984,11,16), DOJ=new DateTime(2011,6,8), City="Mumbai"},

                new Employee{EmployeeID=1002, FirstName="Asdin", LastName="Dhalla", Title="AsstManager", DOB=new DateTime(1984,8,20), DOJ=new DateTime(2012,7,7), City="Delhi"},

                new Employee{EmployeeID=1003, FirstName="Madhavi", LastName="Oza", Title="Consultant", DOB=new DateTime(1987,11,14), DOJ=new DateTime(2015,12,4), City="Pune"},

                new Employee{EmployeeID=1004, FirstName="Saba", LastName="Shaikh", Title="SE", DOB=new DateTime(1990,6,3), DOJ=new DateTime(2016,2,2), City="Pune"},

                new Employee{EmployeeID=1005, FirstName="Nazia", LastName="Shaikh", Title="SE", DOB=new DateTime(1991,3,8), DOJ=new DateTime(2016,2,2), City="Mumbai"},

                new Employee{EmployeeID=1006, FirstName="Amit", LastName="Pathak", Title="Consultant", DOB=new DateTime(1989,11,7), DOJ=new DateTime(2014,8,8), City="Chennai"},

                new Employee{EmployeeID=1007, FirstName="Vijay", LastName="Natrajan", Title="Consultant", DOB=new DateTime(1989,12,2), DOJ=new DateTime(2015,1,6), City="Mumbai"},

                new Employee{EmployeeID=1008, FirstName="Rahul", LastName="Dubey", Title="Associate", DOB=new DateTime(1993,11,11), DOJ=new DateTime(2014,11,6), City="Chennai"},

                new Employee{EmployeeID=1009, FirstName="Suresh", LastName="Mistry", Title="Associate", DOB=new DateTime(1992,8,12), DOJ=new DateTime(2014,12,3), City="Chennai"},

                new Employee{EmployeeID=1010, FirstName="Sumit", LastName="Shah", Title="Manager", DOB=new DateTime(1991,4,12), DOJ=new DateTime(2016,1,2), City="Pune"}
            };

            Console.WriteLine("All employee details : ");
            foreach (Employee emp in empList)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.City + " " + emp.DOJ.ToShortDateString());
            }

            var list1 = empList.Where(e => e.City != "Mumbai").ToList();
            Console.WriteLine("\nAll employee details whose location is not Mumbai: ");
            foreach (Employee emp in list1)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.City + " " + emp.DOJ.ToShortDateString());
            }

            var list2 = empList.Where(e => e.Title == "AsstManager").ToList();
            Console.WriteLine("\nAll employee details whose title is AsstManager: ");
            foreach (Employee emp in list2)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.City + " " + emp.DOJ.ToShortDateString());
            }

            var list3 = empList.Where(e => e.LastName.StartsWith("S")).ToList();
            Console.WriteLine("\nAll employee details whose last name starts with \"S\": ");
            foreach (Employee emp in list3)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.City + " " + emp.DOJ.ToShortDateString());
            }

            DateTime checkDate = DateTime.Parse("1/1/2015");
            var list4 = empList.Where(e => e.DOJ<checkDate).ToList();
            Console.WriteLine("\nAll employee details who joined before 01/01/2015: ");
            foreach (Employee emp in list4)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.City + " " + emp.DOJ.ToShortDateString());
            }



            DateTime dobCheck = new DateTime(1990, 1, 1);
            var resultF = empList.Where(e => e.DOB > dobCheck);
            Console.WriteLine("\nEmployees whose DOB is after 1/1/1990:");
            foreach (Employee emp in resultF)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.City + " " + emp.DOJ.ToShortDateString());
            }

            
            var resultG = empList.Where(e => e.Title == "Consultant" || e.Title == "Associate");
            Console.WriteLine("\nConsultant and Associate:");
            foreach (Employee emp in resultG)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.City + " " + emp.DOJ.ToShortDateString());
            }


            int totalEmployees = empList.Count();
            Console.WriteLine("\nTotal employees: " + totalEmployees);


            int chennaiCount = empList.Count(e => e.City == "Chennai");
            Console.WriteLine("\nEmployees in Chennai: " + chennaiCount);


            int maxID = empList.Max(e => e.EmployeeID);
            Console.WriteLine("\nHighest Employee ID: " + maxID);


            int notAssociate = empList.Count(e => e.Title != "Associate");
            Console.WriteLine("\nEmployees not Associate: " + notAssociate);

            var cityTitleGroup = empList.GroupBy(e => new { e.City, e.Title });
            Console.WriteLine("\nEmployees count based on City and Title:");
            foreach (var group in cityTitleGroup)
            {
                Console.WriteLine(group.Key.City + " " + group.Key.Title + " : " + group.Count());
            }


            var youngest = empList.OrderByDescending(e => e.DOB).First();
            Console.WriteLine("\nYoungest Employee:");
            Console.WriteLine(youngest.FirstName + " " + youngest.DOB);
        }
    }
}
