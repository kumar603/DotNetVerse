using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.SOLIDPrinciples.DependencyInversionPrinciple_DIP
{
    /*****************************************************************************************************
 Writer       : Kiran Kumar J
 Description  : Get to know about Dependency Inversion Principle(DIP) how it is useful for  advanced object
                oriented programming
 Created Date : 04 - August - 2025
 Created By   : Kiran Kumar
 Changed Date : 04 - August - 2025
 Changed By   : Kiran Kumar
 JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/DLP-20
*****************************************************************************************************/
    /*
     * Dependency Inversion Principle : Designing classes that depend on abstractions, not on concrete implementations
     *                                   — making the system extensible, testable, and maintainable
     *                                   
     *                                   This ensures loose coupling between high-level logic 
     *                                   (like business rules) and low-level details (like data access or messaging systems)
     *                                  
     * RreRequisites      : Interfaces or abstract classes to get this decoupling.
     *                                  
     * Features           :  extensible, testable, and maintainable
                             

     Project Structure Snapshot:
        DIPNotificationExample/
        │
        ├── Program.cs
        ├── INotificationService.cs
        ├── EmailNotification.cs
        ├── SmsNotification.cs
        └── NotificationSender.cs

    Conclusion About LSP Principle : 
    DIP promotes extensibility and unit testing.
    We moved from concrete classes to dependency injection via abstractions.
    High-level modules (NotificationSender) are now decoupled from low-level classes (EmailNotification, SmsNotification).

     */
    internal class DependencyInversionPrinciple
    {
        // Message Notification System
        //Before DIP Violation

        public class NotificationSender
        {
            private EmailService _emailService;

            public NotificationSender()
            {
                _emailService = new EmailService(); // ❌ Tight coupling
            }

            public void Notify(string message)
            {
                _emailService.SendEmail(message);
            }
        }

        public class EmailService
        {
            public void SendEmail(string message)
            {
                Console.WriteLine($"Email sent: {message}");
            }
        }
        //Issue: NotificationSender directly depends on EmailService, making it hard to replace with SMS or push notifications.


        //After Applying DIP
        // Abstraction
        public interface INotificationService
        {
            void Send(string message);
        }

        // Concrete implementation 1
        public class EmailNotification : INotificationService
        {
            public void Send(string message)
            {
                Console.WriteLine($"[EMAIL] Message: {message}");
            }
        }

        // Concrete implementation 2
        public class SmsNotification : INotificationService
        {
            public void Send(string message)
            {
                Console.WriteLine($"[SMS] Message: {message}");
            }
        }

        // High-level module depends on abstraction
        public class NotificationSenderDIP
        {
            private readonly INotificationService _notificationService;

            public NotificationSenderDIP(INotificationService notificationService)
            {
                _notificationService = notificationService; // ✅ DIP Applied
            }

            public void NotifyDIP(string message)
            {
                _notificationService.Send(message);
            }
        }


    }
}
