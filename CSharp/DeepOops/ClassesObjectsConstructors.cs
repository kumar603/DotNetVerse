using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.DeepOops
{
    /*****************************************************************************************************
      Writer       : Kiran Kumar J
      Description  :  To build the foundation of Object-Oriented Programming in C# by learning how to 
                        create Classes, instantiate Objects, and understand how Constructors work.
      Created Date : 21 - July - 2025
      Created By   : Kiran Kumar
      Changed Date : 21 - July - 2025
      Changed By   : Kiran Kumar
      JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/DLP-8
   *****************************************************************************************************/
    /*
     * Class       : In c# class is a blueprint for creating objects It contains 
     *               Fields And properties  : to hold data 
     *               Methods : To define behaviour
     * Object      : Real instance of a class Multiple objects can be created for same class 
     *                  Each class has its own data
     * Fields      : Directly stores data inside class Useually its private   
     * Property    : Used to get set properties exposed public via methods
     * Constructor : Initialize objects when they are created , Types Default , Parameterised
     */
    internal class ClassesObjectsConstructors
    {
     internal void CreateClassWithFieldsExample()
        {
            //Create instance
            Carwithfields carwithfields = new Carwithfields();
            carwithfields.Brand = "Toyota";
            carwithfields.Model = "Innova";
            carwithfields.Color = "Black";

            carwithfields.start();
            carwithfields.stop();
        }

     internal void CreateClassWithPropertiesExample()
        {
            //Create instance
            Carwithproperties carwithproperties = new Carwithproperties();
            carwithproperties.Brand = "Ford";
            carwithproperties.Model = "Fiesta";
            carwithproperties.Color = "Blue";

            carwithproperties.start();
            carwithproperties.stop();
        }
        internal void CreateClassWithFieldsAndConstructorExample()
        {
            //Create instance with constructore paramerts
            CarwithFieldsAndConstructor carwithFieldsAndConstructor = new CarwithFieldsAndConstructor("Benz","Model X","Red");
           
            carwithFieldsAndConstructor.start();
            carwithFieldsAndConstructor.stop();
        }
    }
    //Creating custom class
    public class Carwithfields
    {
        //create fields
        public string Brand;
        public string Model;
        public string Color;

        //Create methods that binds data and behave
        public void start()
        {
            Console.WriteLine($"{Brand} {Model} Started");
        }
        public void stop()
        {
            Console.WriteLine($"{Brand} {Model} Stopped");
        }
    }

    //Class with private fields and public properties
    public class Carwithproperties
    {
        //create private fields
        private string brand;
        private string model;
        private string color;

        //Create public properties
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        //Create methods that binds data and behave
        public void start()
        {
            Console.WriteLine($"{Brand} {Model} Started");
        }
        public void stop()
        {
            Console.WriteLine($"{Brand} {Model} Stopped");
        }
    }

    //Class with  public fields  and constructor
    public class CarwithFieldsAndConstructor
    {
        //create public fields
        public string Brand;
        public string Model;
        public string Color;
 
        //Public constructor it will assign values to variables when ever create instance
        public CarwithFieldsAndConstructor(string brand,string model,string color)
        {
            Brand = brand;
            Model = model;
            Color = color;

        }

        //Create methods that binds data and behave
        public void start()
        {
            Console.WriteLine($"{Brand} {Model} Started");
        }
        public void stop()
        {
            Console.WriteLine($"{Brand} {Model} Stopped");
        }
    }
}
