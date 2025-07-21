using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.Fundementals
{
    /*****************************************************************************************************
       Writer       : Kiran Kumar J
       Description  : Consolidate your learning from previous chapters by creating a simple CRUD (Create, Read,
                        Update,Delete) console application using List<T>. This is a practical exercise to 
                        demonstrate   working with collections, user input, loops, and conditions.
       Created Date : 21 - July - 2025
       Created By   : Kiran Kumar
       Changed Date : 21 - July - 2025
       Changed By   : Kiran Kumar
 *****************************************************************************************************/
    internal class RetroFundamentalsApp
    {
     
        //Collection > Lists
        static List<string> students = new List<string>();

        internal  void RetroFundamentalsAppExample()
        {
            //While Loop > Control Structures
            while (true)
            {
                Console.WriteLine("\n1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");

                Console.Write("\nSelect an option (1-5): ");
                string choice = Console.ReadLine();

                //Switch > Control Structures
                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        ViewStudents();
                        break;
                    case "3":
                        UpdateStudent();
                        break;
                    case "4":
                        DeleteStudent();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        static void AddStudent()
        {
            Console.Write("Enter student name to add: ");
            string name = Console.ReadLine();
            students.Add(name);
            Console.WriteLine("Student added.");
        }

        static void ViewStudents()
        {
            Console.WriteLine("\nList of Students:");
            // Control Structures > Foreach Loop
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        static void UpdateStudent()
        {
            Console.Write("Enter existing student name to update: ");
            string oldName = Console.ReadLine();

            // Control Structures > If Else  Statement

            if (students.Contains(oldName))
            {
                Console.Write("Enter new name: ");
                string newName = Console.ReadLine();
                int index = students.IndexOf(oldName);
                students[index] = newName;
                Console.WriteLine("Student updated.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        static void DeleteStudent()
        {
            Console.Write("Enter student name to delete: ");
            string name = Console.ReadLine();
            if (students.Remove(name))
            {
                Console.WriteLine("Student removed.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
    

}
}
