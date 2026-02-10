using System;
using System.Collections.Generic;
using System.Linq;

namespace University_Course_Registration_System
{
     // =========================
    // Program (Menu-Driven)
    // =========================
    class Program
    {
        static void Main()
        {
            UniversitySystem system = new UniversitySystem();
            bool exit = false;

            Console.WriteLine("Welcome to University Course Registration System");

            while (!exit)
            {
                Console.WriteLine("\n1. Add Course");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Register Student for Course");
                Console.WriteLine("4. Drop Student from Course");
                Console.WriteLine("5. Display All Courses");
                Console.WriteLine("6. Display Student Schedule");
                Console.WriteLine("7. Display System Summary");
                Console.WriteLine("8. Exit");

                Console.Write("Enter choice (1-8): ");
                int choice = Int32.Parse(Console.ReadLine());

                try
                {
                    // TODO:
                    // Implement menu handling logic using switch-case
                    // Prompt user inputs
                    // Call appropriate UniversitySystem methods
                    switch (choice)
                    {
                        case 1:
                            {
                                Console.Write("Enter Course Code: ");
                                string cCode = Console.ReadLine();

                                Console.Write("Enter Course Name: ");
                                string cName = Console.ReadLine();

                                Console.Write("Enter Credits (1-4): ");
                                int credits = int.Parse(Console.ReadLine());

                                Console.Write("Enter Max Capacity (default 50): ");
                                string capInput = Console.ReadLine();
                                int capacity = string.IsNullOrWhiteSpace(capInput) ? 50 : int.Parse(capInput);

                                Console.Write("Enter Prerequisites (comma-separated or Enter for none): ");
                                string prereqInput = Console.ReadLine();
                                List<string> prereqs = string.IsNullOrWhiteSpace(prereqInput)
                                    ? new List<string>()
                                    : prereqInput.Split(',').Select(p => p.Trim()).ToList();

                                system.AddCourse(cCode, cName, credits, capacity, prereqs);
                                Console.WriteLine($"\nCourse {cCode} added successfully.\n");
                                break;
                            }

                        case 2:
                            {
                                Console.Write("Enter Student ID: ");
                                string sId = Console.ReadLine();

                                Console.Write("Enter Name: ");
                                string sName = Console.ReadLine();

                                Console.Write("Enter Major: ");
                                string major = Console.ReadLine();

                                Console.Write("Enter Max Credits (default 18): ");
                                string maxCredInput = Console.ReadLine();
                                int maxCredits = string.IsNullOrWhiteSpace(maxCredInput) ? 18 : int.Parse(maxCredInput);

                                Console.Write("Enter Completed Courses (comma-separated or Enter for none): ");
                                string completedInput = Console.ReadLine();
                                List<string> completedCourses = string.IsNullOrWhiteSpace(completedInput)
                                    ? new List<string>()
                                    : completedInput.Split(',').Select(c => c.Trim()).ToList();

                                system.AddStudent(sId, sName, major, maxCredits, completedCourses);
                                Console.WriteLine($"\nStudent {sId} added successfully.\n");
                                break;
                            }

                        case 3:
                            {
                                Console.Write("Enter Student ID: ");
                                string regStudentId = Console.ReadLine();

                                Console.Write("Enter Course Code: ");
                                string regCourseCode = Console.ReadLine();

                                if (system.RegisterStudentForCourse(regStudentId, regCourseCode))
                                    Console.WriteLine("\nRegistration successful.\n");
                                else
                                    Console.WriteLine("\nRegistration failed.\n");
                                break;
                            }

                        case 4:
                            {
                                Console.Write("Enter Student ID: ");
                                string dropStudentId = Console.ReadLine();

                                Console.Write("Enter Course Code: ");
                                string dropCourseCode = Console.ReadLine();

                                if (system.DropStudentFromCourse(dropStudentId, dropCourseCode))
                                    Console.WriteLine("\nCourse dropped successfully.\n");
                                else
                                    Console.WriteLine("\nDrop failed.\n");
                                break;
                            }

                        case 5:
                            {
                                system.DisplayAllCourses();
                                break;
                            }

                        case 6:
                            {
                                Console.Write("Enter Student ID: ");
                                string scheduleId = Console.ReadLine();
                                system.DisplayStudentSchedule(scheduleId);
                                break;
                            }

                        case 7:
                            {
                                system.DisplaySystemSummary();
                                break;
                            }

                        case 8:
                            {
                                exit = true;
                                Console.WriteLine("\nExiting system. Goodbye!\n");
                                break;
                            }

                        default:
                            {
                                Console.WriteLine("\nInvalid choice!\n");
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}

