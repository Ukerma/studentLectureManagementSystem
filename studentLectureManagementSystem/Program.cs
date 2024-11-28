using System;
using System.Collections.Generic;

namespace StudentLectureManagementSystem
{
    // Base class
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        public abstract void DisplayInfo();
    }

    // Interface
    public interface IPerson
    {
        string GetFullName();
    }

    // Student class
    public class Student : Person, IPerson
    {
        public string StudentID { get; set; }
        public List<Course> EnrolledCourses { get; set; } = new List<Course>();

        public override void DisplayInfo()
        {
            Console.WriteLine($"» Student Name: {FirstName}, \n» Student Surname: {LastName}, \n» Student ID: {StudentID}");
            Console.WriteLine("» Enrolled Courses:");
            foreach (var course in EnrolledCourses)
            {
                Console.WriteLine($"  · {course.CourseName}");
            }
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }

    // Instructor class
    public class Instructor : Person, IPerson
    {
        public string Department { get; set; }
        public List<Course> TaughtCourses { get; set; } = new List<Course>();

        public override void DisplayInfo()
        {
            Console.WriteLine($"» Instructor: {FirstName} {LastName}, \n» Department: {Department}");
            Console.WriteLine("» Courses Taught:");
            foreach (var course in TaughtCourses)
            {
                Console.WriteLine($"  · {course.CourseName}");
            }
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }

    // Course class
    public class Course
    {
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public Instructor Instructor { get; set; }
        public List<Student> EnrolledStudents { get; set; } = new List<Student>();

        public void DisplayCourseInfo()
        {
            Console.WriteLine($"» Course: {CourseName}, \n» Credits: {Credits}, \n» Instructor: {Instructor.GetFullName()}");
            Console.WriteLine("» Enrolled Students:");
            foreach (var student in EnrolledStudents)
            {
                Console.WriteLine($"  · {student.GetFullName()}");
            }
        }
    }

    class Program
    {
        // Global data storage
        static List<Student> students = new List<Student>();
        static List<Instructor> instructors = new List<Instructor>();
        static List<Course> courses = new List<Course>();

        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.Clear();
                Console.WriteLine("════════════════ Student and Lecture Management System ════════════════");
                Console.WriteLine("» 1. Add New Student");
                Console.WriteLine("» 2. Add New Instructor");
                Console.WriteLine("» 3. Add New Course");
                Console.WriteLine("» 4. Assign Course to Student");
                Console.WriteLine("» 5. List Students Enrolled in a Course");
                Console.WriteLine("» 6. Exit");
                Console.Write("» Make your choice (1-6): ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        AddInstructor();
                        break;
                    case 3:
                        AddCourse();
                        break;
                    case 4:
                        AssignCourseToStudent();
                        break;
                    case 5:
                        ListStudentsInCourse();
                        break;
                    case 6:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                if (choice != 6)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }

            } while (choice != 6);
        }

        static void AddStudent()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("════════════════ Add New Student ════════════════");
                Console.WriteLine("» 0. Back to Main Menu");
                Console.Write("» First Name: ");
                string firstName = Console.ReadLine();
                if (firstName == "0") return;

                Console.Write("» Last Name: ");
                string lastName = Console.ReadLine();
                if (lastName == "0") return;

                Console.Write("» Student ID: ");
                string studentID = Console.ReadLine();
                if (studentID == "0") return;

                students.Add(new Student { FirstName = firstName, LastName = lastName, StudentID = studentID });
                Console.WriteLine("Student added successfully!");
                break;
            }
        }

        static void AddInstructor()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("════════════════ Add New Instructor ════════════════");
                Console.WriteLine("» 0. Back to Main Menu");
                Console.Write("» First Name: ");
                string firstName = Console.ReadLine();
                if (firstName == "0") return;

                Console.Write("» Last Name: ");
                string lastName = Console.ReadLine();
                if (lastName == "0") return;

                Console.Write("» Department: ");
                string department = Console.ReadLine();
                if (department == "0") return;

                instructors.Add(new Instructor { FirstName = firstName, LastName = lastName, Department = department });
                Console.WriteLine("Instructor added successfully!");
                break;
            }
        }

        static void AddCourse()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("════════════════ Add New Course ════════════════");
                Console.WriteLine("» 0. Back to Main Menu");
                Console.Write("» Course Name: ");
                string courseName = Console.ReadLine();
                if (courseName == "0") return;

                Console.Write("» Credits: ");
                string creditsInput = Console.ReadLine();
                if (creditsInput == "0") return;
                int credits = int.Parse(creditsInput);

                Console.WriteLine("» Select Instructor:");
                for (int i = 0; i < instructors.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {instructors[i].GetFullName()} - {instructors[i].Department}");
                }
                Console.WriteLine("» 0. Back to Main Menu");
                string instructorInput = Console.ReadLine();
                if (instructorInput == "0") return;

                int instructorIndex = int.Parse(instructorInput) - 1;

                if (instructorIndex >= 0 && instructorIndex < instructors.Count)
                {
                    courses.Add(new Course
                    {
                        CourseName = courseName,
                        Credits = credits,
                        Instructor = instructors[instructorIndex]
                    });
                    Console.WriteLine("Course added successfully!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid instructor selection. Please try again.");
                }
            }
        }

        static void AssignCourseToStudent()
        {
            if (courses.Count == 0)
            {
                Console.WriteLine("Please add courses to continue.");
                return;
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("════════════════ Assign Course to Student ════════════════");
                Console.WriteLine("» 0. Back to Main Menu");
                Console.WriteLine("» Select Student:");
                for (int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {students[i].GetFullName()}");
                }
                string studentInput = Console.ReadLine();
                if (studentInput == "0") return;

                int studentIndex = int.Parse(studentInput) - 1;

                Console.WriteLine("» Select Course:");
                for (int i = 0; i < courses.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {courses[i].CourseName}");
                }
                Console.WriteLine("» 0. Back to Main Menu");
                string courseInput = Console.ReadLine();
                if (courseInput == "0") return;

                int courseIndex = int.Parse(courseInput) - 1;

                if (studentIndex >= 0 && studentIndex < students.Count && courseIndex >= 0 && courseIndex < courses.Count)
                {
                    students[studentIndex].EnrolledCourses.Add(courses[courseIndex]);
                    courses[courseIndex].EnrolledStudents.Add(students[studentIndex]);
                    Console.WriteLine("Student successfully assigned to course!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                }
            }
        }

        static void ListStudentsInCourse()
        {
            if (courses.Count == 0)
            {
                Console.WriteLine("This list is empty.");
                return;
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("════════════════ List Students Enrolled in a Course ════════════════");
                Console.WriteLine("» 0. Back to Main Menu");
                Console.WriteLine("» Select Course:");
                for (int i = 0; i < courses.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {courses[i].CourseName}");
                }
                string courseInput = Console.ReadLine();
                if (courseInput == "0") return;

                int courseIndex = int.Parse(courseInput) - 1;

                if (courseIndex >= 0 && courseIndex < courses.Count)
                {
                    courses[courseIndex].DisplayCourseInfo();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid course selection. Please try again.");
                }
            }
        }
    }
}
