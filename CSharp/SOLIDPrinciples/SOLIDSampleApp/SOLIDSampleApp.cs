using DotNetVerse.CSharp.SOLIDPrinciples.SOLIDSampleApp.Interfaces;
using DotNetVerse.CSharp.SOLIDPrinciples.SOLIDSampleApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.SOLIDPrinciples.SOLIDSampleApp
{
    /*****************************************************************************************************
Writer       : Kiran Kumar J
Description  : Get to know about all SOLID principles learned and apply in a test project
Created Date : 04 - August - 2025
Created By   : Kiran Kumar
Changed Date : 04 - August - 2025
Changed By   : Kiran Kumar
JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/DLP-21
*****************************************************************************************************/
    /*
     * SOLID Principles : Design and create a project that explains all the SOLID principles
     *                                  
     * RreRequisites      : Interfaces or abstract classes to get this decoupling.
     *                                  
     * Features           :  extensible, testable, and maintainable
                             
 SRP > TaskService, ConsoleTaskLogger, InMemoryTaskRepository > Each class has one responsibility

OCP > TaskService uses interfaces > We can add new logging/repo types without changing logic

LSP > ConsoleTaskLogger : ITaskLogger, InMemoryTaskRepository : ITaskRepository > We can swap implementations without breaking functionality

ISP > Separate interfaces for ILogger, IRepository, IService > Clients only implement what they use

DIP > High-level TaskService depends on abstractions > No hard dependency on concrete classes

    SolidTaskManager/
        ├── Models/
        │   └── TaskItem.cs
        ├── Interfaces/
        │   ├── ITaskRepository.cs
        │   ├── ITaskLogger.cs
        │   └── ITaskService.cs
        ├── Services/
        │   ├── TaskService.cs
        │   ├── InMemoryTaskRepository.cs
        │   └── ConsoleTaskLogger.cs
        ├── Program.cs

    Conclusion About LSP Principle : 
    Created a small app that reflects all SOLID principles
    Learned to separate concerns and use interfaces for flexibility
    Made your code extensible, testable, and maintainable

     */
    internal class SOLIDSampleApp
    {
       public void SOLIDSampleAppExample()
        {
            ITaskRepository repo = new InMemoryTaskRepository();
            ITaskLogger logger = new ConsoleTaskLogger();
            ITaskService service = new TaskService(repo, logger);

            service.CreateTask("Write Report", "Write monthly sales report");
            service.CreateTask("Fix Bug", "Resolve login issue");
            service.ShowTasks();

            service.UpdateStatus(2, "In Progress");
            service.ShowTasks();
        }
    }
}
