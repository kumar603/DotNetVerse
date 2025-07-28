using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DotNetVerse.CSharp.DeepOops.Polymorphism;

namespace DotNetVerse.CSharp.DeepOops
{
    /*****************************************************************************************************
      Writer       : Kiran Kumar J
      Description  :  Get to know about Polymorphism using in oops with  method overload and overriding
      Created Date : 28 - July - 2025
      Created By   : Kiran Kumar
      Changed Date : 28 - July - 2025
      Changed By   : Kiran Kumar
      JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/DLP-11
   *****************************************************************************************************/
    /*
     * Polymorphism :  Polymorphism means "many forms".
     * Rules        :  Compile-Time (Static) Polymorphism – Achieved using method overloading.
     *                 Run-Time (Dynamic) Polymorphism – Achieved using method overriding with virtual, override, and base..
     * Features    :   Allows objects of different types to be treated as objects of a common base type, enhancing code flexibility and reusability
    
     */
    internal class Polymorphism
    {
        //Developing Compile Time(Statis) polymorphism - Method Overloading
        public class Calculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public double Add(double a, double b)
            {
                return a + b;
            }
        }

        //Developing Rum Time(Dynamic) polymorphism - Method Overloading
        public class Vehicle
        {
            public virtual void Start()
            {
                Console.WriteLine("Vehicle Started");
            }
        }

        public class Car : Vehicle
        {
            public override void Start()
            {
                Console.WriteLine("Car Started");
            }
        }

        public class Bike : Vehicle
        {
            public override void Start()
            {
                Console.WriteLine("Bike Started");
            }
        }

        internal void CompiletimeMethodOverloadingPolymorhismExample()
        {
            Calculator calculator = new Calculator();
            calculator.Add(1, 2); //Invoking int type methodoverload function
            calculator.Add(5.5, 6.5); //Invoking double type methodoverload function

        }
        internal void RuntimeMethodOverRidingPolymorhismExample()
        {
            Vehicle car = new Car(); // Creating instance for Vehicle methodoverriding from Car
            Vehicle bike = new Bike(); // Creating instance for Vehicle methodoverriding from bike

            car.Start();  
            bike.Start();  

        }
    }
}
