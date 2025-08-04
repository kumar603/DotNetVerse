using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DotNetVerse.CSharp.SOLIDPrinciples.SingleResponsibilityPrinciple_SRP
{
    /*****************************************************************************************************
    Writer       : Kiran Kumar J
    Description  : Get to know about Single Responsibility Principle  how it is useful for  advanced object
                   oriented programming
    Created Date : 04 - August - 2025
    Created By   : Kiran Kumar
    Changed Date : 04 - August - 2025
    Changed By   : Kiran Kumar
    JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/DLP-16
   *****************************************************************************************************/
    /*
     * Single Responsibility Principle : A class should have only one reason to change. 
     *                                  This means each class should handle only one part of the functionility.
     * Features           : Promotes separation of concerns
                            Easier unit testing and debugging
                            Reduces code duplication
                            Increases code reusability

    Project Structure Snapshot:
    SRPExample/
    │
    ├── UserService.cs      --> Only handles user registration
    ├── Logger.cs           --> Only handles logging
    ├── Program.cs          --> Main program

    Conclusion About SRP Principle : 
    SRP helps keep each class focused on one task.
    If a class has multiple reasons to change, split it into multiple classes.
    Improves clarity, testability, and maintainability

     */
    internal class SingleResponsibilityPrinciple
    {
        //Violation Example:
        //A class that handles both user data management and logging violates SRP.
        //Here, UserService is doing both registration and logging.
        public class UserService
        {
            public void RegisterUser(string name)
            {
                Console.WriteLine($"User {name} registered successfully.");
                Log($"User {name} registered at {DateTime.Now}");
            }

            private void Log(string message)
            {
                File.WriteAllText("log.txt", message);
            }
        }

        //Good Example: SRP Applied
        public class UserServiceSRP
        {
            private readonly Logger _logger;
            public UserServiceSRP(Logger logger)
            {
                _logger = logger;
            }
            public void Log(string name) {
                Console.WriteLine($"User {name} registered successfully.");
                _logger.Log($"User {name} registered at {DateTime.Now}");
            }
        }
        public class Logger
        {
            public void Log(string message)
            {
                File.WriteAllText("log.txt", message);
            }
        }
    }
}
