using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // University System Class
    // =========================
    public class UniversitySystem
    {
        public Dictionary<string, Course> AvailableCourses { get; private set; }
        public Dictionary<string, Student> Students { get; private set; }

        public UniversitySystem()
        {
            AvailableCourses = new Dictionary<string, Course>();
            Students = new Dictionary<string, Student>();
        }

        public void AddCourse(string code, string name, int credits, int maxCapacity = 50, List<string> prerequisites = null)
        {
            // TODO:
            // 1. Throw ArgumentException if course code exists
            // 2. Create Course object
            // 3. Add to AvailableCourses
            if (AvailableCourses.ContainsKey(code))
            {
                throw new ArgumentException();
            }
            Course courseObj = new Course(code,name,credits,maxCapacity,prerequisites);
            AvailableCourses.Add(code, courseObj);

        }

        public void AddStudent(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            // TODO:
            // 1. Throw ArgumentException if student ID exists
            // 2. Create Student object
            // 3. Add to Students dictionary
            if (Students.ContainsKey(id))
            {
                throw new ArgumentException();
            }
            Student studentObj = new Student(id, name, major, maxCredits, completedCourses);
            Students.Add(id, studentObj);
        }

        public bool RegisterStudentForCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student and course existence
            // 2. Call student.AddCourse(course)
            // 3. Display meaningful messages
            if(AvailableCourses.Any(s => s.Key == courseCode) && Students.Any(s => s.Key == studentId))
            {
                var student = Students[studentId];
                var course = AvailableCourses[courseCode];
                student.AddCourse(course);
                
                return true;
            }
            else
            {
                Console.WriteLine("Prerequisites not met");
                return false;
            }
        }

        public bool DropStudentFromCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student existence
            // 2. Call student.DropCourse(courseCode)
            if(AvailableCourses.Any(s => s.Key == courseCode) && Students.Any(s => s.Key == studentId))
            {
                var student = Students[studentId];
                student.DropCourse(courseCode);

                return true;
            }
            else
            {
                return false;
            }
        }

        public void DisplayAllCourses()
        {
            // TODO:
            // Display course code, name, credits, enrollment info
            Console.WriteLine("\nCourse Code  |  Course Name  |  Course Credits  |  Enrollment Info");
            foreach (var item in AvailableCourses.Values)
            {
                Console.WriteLine($"{item.CourseCode}  |  {item.CourseName}  |   {item.Credits}  |   {item.GetEnrollmentInfo}");
            }
            
        }

        public void DisplayStudentSchedule(string studentId)
        {
            // TODO:
            // Validate student existence
            // Call student.DisplaySchedule()
            if(Students.Any(s => s.Key == studentId))
            {
                var student = Students[studentId];
                student.DisplaySchedule();
            }
            else
            {
                Console.WriteLine("\nStudent Not Found.\n");
            }
            
        }

        public void DisplaySystemSummary()
        {
            // TODO:
            // Display total students, total courses, average enrollment
            Console.WriteLine("\nTotal Students: "+Students.Count);
            Console.WriteLine("\nTotal Courses: "+AvailableCourses.Count);
        }
    }
}
