using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DotNetVerse.CSharp.DesignPatterns.CreationalFactoryAbstractFactoryPattern
{
    /*****************************************************************************************************
    Writer       : Kiran Kumar J
    Description  : Get to know about Creational Factory Abstract Factory Pattern and how it is useful for 
                   advanced Programming
    Created Date : 6 - October - 2025
    Created By   : Kiran Kumar
    Changed Date : 6 - October - 2025
    Changed By   : Kiran Kumar
    JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/DLP-23
   *****************************************************************************************************/
    /*
     * Abstract Factory Design Pattern : Create objects without specifying the exact class in the calling code.
                                       Provide an interface for creating families of related objects without 
                                       specifying their concrete classes.
     *                                  
     *                                  
     * Features           :  Encapsulate object creation logic.
     *                       Reduce tight coupling between the client and concrete classes.
     *                       Simplify adding new object types without modifying existing code (Open/Closed Principle).
     *                       When object creation is complex or needs to vary dynamically.
     *                       When you want to keep the client code independent from object creation logic.
                             
                FactoryPatternExample/
            ├── IVehicle.cs
            ├── Car.cs
            ├── Bike.cs
            ├── VehicleFactory.cs
            ├── AbstractFactory/
            │   ├── IButton.cs
            │   ├── WindowsButton.cs
            │   ├── MacButton.cs
            │   ├── IGUIFactory.cs
            │   ├── WindowsFactory.cs
            │   └── MacFactory.cs
            └── Program.cs

     
    Conclusion About Abstract Factory Design Pattern :  
    The Abstract Factory pattern is a powerful, but complex, design tool for creating families of related objects without
    specifying concrete classes, promoting flexibility and loose coupling by encapsulating product creation within factories. 
    It is best used when an application requires a range of related products and needs to swap product families easily, 
    such as for cross-platform applications, but can lead to overcomplication or difficulty in adding new product types if not applied carefully
     */

    // Common Interface
    public interface IVehicle
    {
        void Drive();
    }
    //Concrete Implementations
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car...");
        }
    }

    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding a bike...");
        }
    }

    //Factory Class
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string type)
        {
            switch (type.ToLower())
            {
                case "car":
                    return new Car();
                case "bike":
                    return new Bike();
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }
    }
    internal class CreationalFactoryAbstractFactoryPattern_CFP
    {
        public void CreationalFactoryPatternTest()
        {
            IVehicle vehicle1 = VehicleFactory.GetVehicle("car");
            vehicle1.Drive();

            IVehicle vehicleII = VehicleFactory.GetVehicle("bike");
            vehicleII.Drive();
        }
    }
}
