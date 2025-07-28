using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.DeepOops
{
    /*****************************************************************************************************
  Writer       : Kiran Kumar J
  Description  :  Build a small real-world C# Console Application that applies Encapsulation, 
                    Inheritance, Abstraction, Polymorphism, Interfaces, Events/Delegates, 
                     Anonymous Methods, and Generics with Collections.
  Created Date : 28 - July - 2025
  Created By   : Kiran Kumar
  Changed Date : 28 - July - 2025
  Changed By   : Kiran Kumar
  JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/DLP-15
*****************************************************************************************************/
    /*
     * Encapsulation      :  Secured access to student/course data.
     * Inheritance        : OnlineCourse and OfflineCourse inherit from abstract Course.
     * Polymorphism       : PrintInfo() method overridden in each subclass.
     * Generics           : EnrollmentSystem<TStudent, TCourse>.
     * Events & Delegates : Used Action<Student> for enrollment notification.
     * Anonymous Functions: Used in event registration.
     */

    internal class RetroDeepDiveOops
    {
        // -------------------------
        // Main Program - Task 8: Mini Project
        // -------------------------
        internal void RetroDeepDiveOopsExample()
        {
            var enrollmentSystem = new EnrollmentSystem<Student, Course>();

            // Add courses
            var c1 = new OnlineCourse("C101", "C# Basics", "Pluralsight");
            var c2 = new OfflineCourse("C102", "OOP in Detail", "C# Programming");

            // Event handler (Task 6: Delegates & Events)
            c1.OnStudentEnrolled = student => Console.WriteLine($"Student {student.Name} enrolled in {c1.Title}");
            c2.OnStudentEnrolled = student => Console.WriteLine($"Student {student.Name} enrolled in {c2.Title}");

            enrollmentSystem.AddCourse(c1);
            enrollmentSystem.AddCourse(c2);

            enrollmentSystem.ShowAllCourses();

            // Add student
            var s1 = new Student(1, "Kiran Kumar");
            enrollmentSystem.AddStudent(s1);

            // Enroll
            s1.Enroll(c1);
            s1.Enroll(c2);

            Console.WriteLine("\nCourses Enrolled by Student:");
            foreach (var course in s1.GetEnrolledCourses())
                course.PrintInfo();
        }
    }

// StudentCourseEnrollment.cs
// -------------------------
// Task 1: Encapsulation
// -------------------------
// Class Student encapsulates student data securely
public class Student
{
    public int Id { get; private set; }
    public string Name { get; set; }
    private List<Course> enrolledCourses = new List<Course>();

    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public void Enroll(Course course)
    {
        enrolledCourses.Add(course);
        course.OnStudentEnrolled?.Invoke(this); // Task 6: Delegates/Events
    }

    public IEnumerable<Course> GetEnrolledCourses() => enrolledCourses;
}

// -------------------------
// Task 2: Inheritance
// -------------------------
public abstract class Course
{
    public string CourseCode { get; set; }
    public string Title { get; set; }

    // Task 6: Delegates/Events
    public Action<Student> OnStudentEnrolled;

    public Course(string code, string title)
    {
        CourseCode = code;
        Title = title;
    }

    public abstract void PrintInfo(); // Task 4: Polymorphism - abstract method
}

public class OnlineCourse : Course
{
    public string Platform { get; set; }

    public OnlineCourse(string code, string title, string platform) : base(code, title)
    {
        Platform = platform;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"[Online] {Title} ({CourseCode}) - Platform: {Platform}");
    }
}

public class OfflineCourse : Course
{
    public string Room { get; set; }

    public OfflineCourse(string code, string title, string room) : base(code, title)
    {
        Room = room;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"[Offline] {Title} ({CourseCode}) - Room: {Room}");
    }
}

// -------------------------
// Task 5: Generics & Collections
// -------------------------
public class EnrollmentSystem<TStudent, TCourse>
    where TStudent : Student
    where TCourse : Course
{
    private List<TStudent> students = new List<TStudent>();
    private List<TCourse> courses = new List<TCourse>();

    public void AddStudent(TStudent student) => students.Add(student);
    public void AddCourse(TCourse course) => courses.Add(course);

    public void ShowAllCourses()
    {
        Console.WriteLine("\nAvailable Courses:");
        foreach (var course in courses)
            course.PrintInfo(); // Task 4: Polymorphism
    }
}
}