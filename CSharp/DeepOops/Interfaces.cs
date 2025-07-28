using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.DeepOops
{

    /*****************************************************************************************************
      Writer       : Kiran Kumar J
      Description  :  Get to know about Interfaces and how these can be used in classes  
      Created Date : 28 - July - 2025
      Created By   : Kiran Kumar
      Changed Date : 28 - July - 2025
      Changed By   : Kiran Kumar
      JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/DLP-10
   *****************************************************************************************************/
    /*
     * Interfaces : An interface is like a contract that defines what a class must do, but not how it does it. 
     * Rules of Interfaces : It contains method signatures only (no implementation).
     *                        It cannot contain fields or constructors.
     *                        It cannot be instantiated directly.
     *                        It can only be inherited by other classes.
     *                        A class must implement all members of an interface.                 
     * Features of Interfaces : Interfaces promote code reusability, extensibility, and maintainability.
                              It helps achieve code reusability, extensibility, and promotes clean, maintainable code.
                              Interfaces allows to implment multiple inheritance.
    
     */
    //Interface declaration to develop single responsibility principle and code reusability
    interface IVehicle
    {
        void Start();
        void Stop();
    }
    //Interface to develop multiple inheritance
    public interface IPrinter
    {
        void Print();
    }
    public interface IScanner
    {
        void Scan();
    }
    public interface IFax
    {
        void Fax();
    }
    internal class Interfaces
    {
        public class Car : IVehicle
        {
            public void Start()
            {
                Console.WriteLine("Car started");
            }
            public void Stop()
            {
                Console.WriteLine("Car stopped");
            }
        }
        public class Bike : IVehicle
        {
            public void Start()
            {
                Console.WriteLine("Bike started");
            }
            public void Stop()
            {
                Console.WriteLine("Bike stopped");
            }
        }

        // Example of multiple inheritance using interfaces
        public class MultiFunctionPrinter : IPrinter, IScanner, IFax
        {
            public void Print()
            {
                Console.WriteLine("Printing document...");
            }
            public void Scan()
            {
                Console.WriteLine("Scanning document...");
            }
            public void Fax()
            {
                Console.WriteLine("Sending fax...");
            }
        }
    }
}
