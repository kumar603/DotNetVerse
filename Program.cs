﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetVerse.CSharp.Fundementals;
using DotNetVerse.CSharp.DeepOops;
namespace DotNetVerse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ValueReferenceTypes();
            //ControlStructures()'
            //ArraysListsDictionaryCRUD();
            //DataManagement();
            //ExceptionManagement();
            //FilesManagement();
            //RetroFundamentalsAppExample();

            //Part 2 - Deep Dive into OOPS in C#
            //ClassesObjectsConstructors();
            // InheritanceAbstractClass();
            //Interfaces()
            //Polymorphism(); 
            //Encapsulation();
            //EventsDelegatesAnonymousFunctions();
            TypesSafetyGenericsCollections();
        }
        public static void ValueReferenceTypes()
        {
            ValueReferenceTypes valueReferenceTypes = new ValueReferenceTypes();
            valueReferenceTypes.ValueTypeExample();
            valueReferenceTypes.ReferenceTypeExample();
            Console.ReadKey();
        }
        public static void ControlStructures()
        {
            ControlStructures controlStructures = new ControlStructures();
            controlStructures.IfElseExample();
            controlStructures.SwitchExample();
            controlStructures.ForLoopExample();
            controlStructures.WhileLoopExample();
            controlStructures.DoWhileLoopExample();
            controlStructures.ForEachLoopExample();
            Console.ReadKey();
        }
        public static void ArraysListsDictionaryCRUD()
        {
            ArraysListsDictionaryCRUD arraysListsDictionaryCRUD = new ArraysListsDictionaryCRUD();
            arraysListsDictionaryCRUD.ArraysExample();
            arraysListsDictionaryCRUD.ListsExample();
            arraysListsDictionaryCRUD.DictionaryExample();
            Console.ReadKey();
        }
        public static void DataManagement()
        {
            DataManagement dataManagement = new DataManagement();
            dataManagement.StringExample();
            dataManagement.StringBuilderExample();
            dataManagement.DateTimeExample();
            Console.ReadKey();
        }

        public static void ExceptionManagement()
        {
            ExceptionManagement exceptionManagement = new ExceptionManagement();
            exceptionManagement.ExceptionManagementWithSingleTryCatchExample();
            exceptionManagement.ExceptionManagementWithSingleTryMultiCatchExample();

            Console.ReadKey();
        }
        public static void FilesManagement()
        {
            FilesManagement filesManagement = new FilesManagement();
            filesManagement.FilesManagementWithFileExample();
            filesManagement.FilesManagementWithStreamReadAndWriter();

            Console.ReadKey();
        }
        public static void RetroFundamentalsAppExample()
        {
            RetroFundamentalsApp retroFundamentalsApp = new RetroFundamentalsApp();
            retroFundamentalsApp.RetroFundamentalsAppExample();

        }

        //Deep Dive into OOPS in C#
        public static void ClassesObjectsConstructors()
        {
            ClassesObjectsConstructors classesObjectsConstructors = new ClassesObjectsConstructors();
            classesObjectsConstructors.CreateClassWithFieldsExample();
            classesObjectsConstructors.CreateClassWithPropertiesExample();
            classesObjectsConstructors.CreateClassWithFieldsAndConstructorExample();
            Console.ReadKey();
        }
        public static void InheritanceAbstractClass()
        {
            InheritanceAbstractClass inheritanceAbstractClass = new InheritanceAbstractClass();
            inheritanceAbstractClass.InheritanceExample();
            inheritanceAbstractClass.AbstractClassExample();
            Console.ReadKey();
        }
        public static void Interfaces()
        { 
             Interfaces interfaces = new Interfaces();
            interfaces.InterfacesExample();
            interfaces.InterfacesExample();
            Console.ReadKey(); 
        }
        public static void Polymorphism()
        {
            Polymorphism  polymorphism = new Polymorphism();
            polymorphism.CompiletimeMethodOverloadingPolymorhismExample();
            polymorphism.RuntimeMethodOverRidingPolymorhismExample();
            Console.ReadKey();
        }
        public static void Encapsulation()
        {
            Encapsulation  encapsulation = new Encapsulation();
            encapsulation.EncapsulationExample();
            Console.ReadKey();
        }
        public static void EventsDelegatesAnonymousFunctions()
        {
            EventsDelegatesAnonymousFunctions eventsDelegatesAnonymousFunctions = new EventsDelegatesAnonymousFunctions();
            eventsDelegatesAnonymousFunctions.DelegatesExample();
            eventsDelegatesAnonymousFunctions.AnonymousExample();
            eventsDelegatesAnonymousFunctions.EventsExample();
            Console.ReadKey();
        }
        public static void TypesSafetyGenericsCollections()
        {
            TypesSafetyGenericsCollections  typesSafetyGenericsCollections = new TypesSafetyGenericsCollections();
            typesSafetyGenericsCollections.GenericsList();
            typesSafetyGenericsCollections.GenericDictionary();
            typesSafetyGenericsCollections.CustomGenericMethod();
            typesSafetyGenericsCollections.CustomGenericClass();
            Console.ReadKey();
        }
        public static void RetroDeepDiveOops()
        {
            RetroDeepDiveOops retroDeepDiveOops = new RetroDeepDiveOops();
            retroDeepDiveOops.RetroDeepDiveOopsExample();
            Console.ReadKey();
        }
    }
}
