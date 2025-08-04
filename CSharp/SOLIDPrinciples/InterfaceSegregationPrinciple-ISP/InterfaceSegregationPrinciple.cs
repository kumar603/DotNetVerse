using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.SOLIDPrinciples.InterfaceSegregationPrinciple_ISP
{
    /*****************************************************************************************************
   Writer       : Kiran Kumar J
   Description  : Get to know about Interface Segregation Principle(ISP) how it is useful for  advanced object
                  oriented programming
   Created Date : 04 - August - 2025
   Created By   : Kiran Kumar
   Changed Date : 04 - August - 2025
   Changed By   : Kiran Kumar
   JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/DLP-19
  *****************************************************************************************************/
    /*
     * Interface Segregation Principle : Clients should not be forced to depend on interfaces they do not use
     *                                  
     * RreRequisites      : Interfaces and Classes , object-oriented design principles
     *                                  
     * Features           :  Avoids having large interfaces with unrelated methods
     *                       Prevents classes from implementing unnecessary methods
                             

     Project Structure Snapshot:
       ISPDocumentExample/
        │
        ├── Interfaces/
        │   ├── IPrinter.cs
        │   ├── IScanner.cs
        │   └── IFax.cs
        │
        ├── Devices/
        │   ├── OldPrinter.cs
        │   ├── ScannerOnlyDevice.cs
        │   └── ModernMultifunctionPrinter.cs
        │
        ├── Program.cs
        └── ISPDocumentExample.csproj

    Conclusion About LSP Principle : 
    ISP encourages smaller, role-based interfaces.
    Each device only implements capabilities it actually supports.
    Prevents runtime errors (like NotImplementedException) and bloated code.

     */
    internal class InterfaceSegregationPrinciple
    {
        //Code Example (Document Devices Use Case)

        //Violation of ISP – Fat Interface
        //Problem:
        //OldPrinter is forced to implement Scan() and Fax(), even though it can't support them. This is an ISP violation.
        public interface IMachine
        {
            void Print();
            void Scan();
            void Fax();
        }
        public class OldPrinter : IMachine
        {
            public void Print()
            {
                Console.WriteLine("Printing...");
            }

            public void Scan()
            {
                throw new NotImplementedException();
            }

            public void Fax()
            {
                throw new NotImplementedException();
            }
        }

        //ISP-Compliant Design
        //Interfaces
        // IPrinter.cs
        public interface IPrinterISP
        {
            void Print();
        }

        // IScanner.cs
        public interface IScannerLSP
        {
            void Scan();
        }

        // IFax.cs
        public interface IFax
        {
            void Fax();
        }

        //Devices(Implementations)
        // OldPrinter.cs
        public class OldPrinterISP : IPrinterISP
        {
            public void Print()
            {
                Console.WriteLine("Old printer printing...");
            }
        }

        // ScannerOnlyDevice.cs
        public class ScannerOnlyDevice : IScannerLSP
        {
            public void Scan()
            {
                Console.WriteLine("Scanner-only device scanning...");
            }
        }
        // ModernMultifunctionPrinter.cs
        public class ModernMultifunctionPrinter : IPrinterISP, IScannerLSP, IFax
        {
            public void Print()
            {
                Console.WriteLine("Modern printer printing...");
            }

            public void Scan()
            {
                Console.WriteLine("Modern printer scanning...");
            }

            public void Fax()
            {
                Console.WriteLine("Modern printer faxing...");
            }
        }
    }
}
