using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace DotNetVerse.CSharp.DesignPatterns.CreationalSingletonPattern
{
    /*****************************************************************************************************
 Writer       : Kiran Kumar J
 Description  : Get to know about Creational Singleton Design Pattern and how it is useful for  advanced 
                Programming
 Created Date : 11 - August - 2025
 Created By   : Kiran Kumar
 Changed Date : 11 - August - 2025
 Changed By   : Kiran Kumar
 JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/DLP-22
*****************************************************************************************************/
    /*
     * Singleton Design Pattern :  The Singleton Pattern ensures that Only one instance of a class exists.
                                   The instance is central accessible throughout the application.
     *                             Centralized access to a single object (e.g., app settings, logging).      
     *                                   This ensures loose coupling between high-level logic 
     *                                   (like business rules) and low-level details (like data access or messaging systems)
     *                                  
     *                                  
     * Features           :  Useful for shared resources like configuration, logging, or database connection management.
     *                       Controlled access to the sole instance , educed memory overhead for resource-heavy objects
                             
         SingletonLogger/
        ├── Logger.cs           --> Singleton Logger implementation
        └── Program.cs          --> Entry point to demonstrate Singleton usage

        Private Constructor → Prevents creating instances with new.
        Static Field → Stores the only instance of the class.
        Static Property → Provides global access to the instance.

     
    Conclusion About Singleton design pattern :  
     The Singleton design pattern ensures that a class has only one instance and provides a global point of access to that instance. 
     This pattern is particularly useful in scenarios requiring a single, shared resource or entity throughout an application, 
      Like as database connection pools, configuration managers, or logging services
     */
    internal class CreationalSingletonPattern_CSP
    {
        public sealed class Logger
        {
            // Private static variable to hold the single instance
            private static readonly Logger _instance = new Logger();

            // Private constructor prevents external instantiation
            private Logger()
            {
                Console.WriteLine("Logger instance created.");
            }

            // Public static property to access the single instance
            public static Logger Instance
            {
                get
                {
                    return _instance;
                }
            }

            // Logging method
            public void Log(string message)
            {
                Console.WriteLine($"[LOG] {message}");
            }

        }
        public  void CreationalSingletonPatternTest()
        {
            Logger logger1 = Logger.Instance;
            Logger logger2 = Logger.Instance;

            logger1.Log("Starting application...");
            logger2.Log("Application running...");

            // Verify both variables reference the same instance
            Console.WriteLine(object.ReferenceEquals(logger1, logger2)
                ? "Both are the same instance."
                : "Different instances found!");
        }
    }
}
