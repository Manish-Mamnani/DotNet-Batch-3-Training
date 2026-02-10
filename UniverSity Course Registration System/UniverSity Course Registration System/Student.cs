using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // Student Class
    // =========================
    public class Student
    {
        public string StudentId { get; private set; }
        public string Name { get; private set; }
        public string Major { get; private set; }
        public int MaxCredits { get; private set; }

        public List<string> CompletedCourses { get; private set; }
        public List<Course> RegisteredCourses { get; private set; }

        public Student(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            StudentId = id;
            Name = name;
            Major = major;
            MaxCredits = maxCredits;
            CompletedCourses = completedCourses ?? new List<string>();
            RegisteredCourses = new List<Course>();
        }

        public int GetTotalCredits()
        {
            // TODO: Return sum of credits of all RegisteredCourses
            int sum = 0;
            foreach(var item in RegisteredCourses)
            {
                sum += item.Credits;
            }
            return sum;
        }

        public bool CanAddCourse(Course course)
        {
            // TODO:
            // 1. Course should not already be registered
            // 2. Total credits + course credits <= MaxCredits
            // 3. Course prerequisites must be satisfied
            var check = RegisteredCourses.Any(s => s.CourseCode == course.CourseCode);

            bool check2 = true;

            foreach(string item in course.Prerequisites)
            {
                if (!CompletedCourses.Contains(item))
                {
                    check2 = false;
                    break;
                }
            }


            if(this.GetTotalCredits() + course.Credits > MaxCredits)
            {
                return false;
            }
            if (check)
            {
                return false;
            }
            if (!check2)
            {
                return false;
            }
            return true;

        }

        public bool AddCourse(Course course)
        {
            // TODO:
            // 1. Call CanAddCourse
            // 2. Check course capacity
            // 3. Add course to RegisteredCourses
            // 4. Call course.EnrollStudent()
            if(this.CanAddCourse(course) && !course.IsFull())
            {
                RegisteredCourses.Add(course);
                course.EnrollStudent();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DropCourse(string courseCode)
        {
            // TODO:
            // 1. Find course by code
            // 2. Remove from RegisteredCourses
            // 3. Call course.DropStudent()
            var course = RegisteredCourses.Find(s => s.CourseCode == courseCode);
            if(course != null)
            {
                RegisteredCourses.Remove(course);
                course.DropStudent();
                return true;
            }
            return false;
        }

        public void DisplaySchedule()
        {
            // TODO:
            // Display course code, name, and credits
            // If no courses registered, display appropriate message
            Console.WriteLine("\nCourse Code  |  Course Name  |  Course Credits");
            
            foreach(var item in RegisteredCourses)
            {
                Console.WriteLine($"{item.CourseCode}  |  {item.CourseName}  |   {item.Credits}");
            }
            Console.WriteLine();
        }
    }
}
