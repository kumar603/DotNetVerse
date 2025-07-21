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
            //ArraysListsDictionaryCRUD();
            //DataManagement();
            //ExceptionManagement();
            //FilesManagement();
            RetroFundamentalsAppExample();
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
    }
}
