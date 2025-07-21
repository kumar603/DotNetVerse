using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.DeepOops
{
    /*****************************************************************************************************
      Writer       : Kiran Kumar J
      Description  :  Understand how Inheritance promotes code reuse and how Abstract Classes help define
                     a  common base for derived classes, encouraging flexibility and maintainability
      Created Date : 21 - July - 2025
      Created By   : Kiran Kumar
      Changed Date : 21 - July - 2025
      Changed By   : Kiran Kumar
      JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/DLP-9
   *****************************************************************************************************/
    /*
     * Inheritance : Inheritance allows a child class (derived class) to reuse the properties and methods of a parent class (base class).
                        It helps achieve code reusability, extensibility, and promotes clean, maintainable code.
      Reusability : By inheriting from a base class, derived classes can reuse existing code, reducing redundancy.
      Extensibility : New functionality can be added to derived classes without modifying the base class, making it easier to extend the codebase.
      Maintainability : Changes made to the base class automatically propagate to derived classes, ensuring consistency and reducing maintenance effort.
      Types of Inheritance : Single , Multiple, Multilevel, Hierarchical, and Hybrid.
      Abtract Class : Cannot be instantiated,Must be Inherited , Can contain abstract methods (without implementation) and concrete methods (with implementation).
                        Enforces Implementation  
     
     */
    internal class InheritanceAbstractClass
    {
        internal void InheritanceExample()
        {
            Car mycar = new Car();
            mycar.Start(); // Inherited method from Vehicle class - Base Parent Class
            mycar.Drive(); // Method from Car class - Derived Child Class
            mycar.Stop();  // Inherited method from Vehicle class - Base Parent Class

        }
        internal void AbstractClassExample()
        {
            Circle mycircle = new Circle();
            mycircle.Radius = 5;
            Console.WriteLine("Circle Area " + mycircle.CalculateArea());


            Rectangle myrectangle = new Rectangle();
            myrectangle.Height = 5;
            myrectangle.Width = 8;
            Console.WriteLine("Rectangle Area " + myrectangle.CalculateArea());
            

        }

    }
    //Base Class (Parent Class)
    public class Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Vehicle started.");
        }
        public void Stop()
        {
            Console.WriteLine("Vehicle stopped.");
        }
    }

    //Derived Class (Child Class)
    public class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is being driven.");
        }
    }


    //Abstract Class Example
    public abstract class Shape
    {
        public string Color { get; set; }
        public abstract double CalculateArea(); // Abstract method (no implementation)
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double CalculateArea() // Implementation of abstract method
        {
            return Math.PI * Radius * Radius;
        }
    }
    public  class  Rectangle:Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double CalculateArea() // Implementation of abstract method
        {
            return Width * Height;
        }
    }

}
