using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetVerse.CSharp.Fundementals;
namespace DotNetVerse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ValueReferenceTypes();
            //ControlStructures()'
            ArraysListsDictionaryCRUD();
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
    }
}
