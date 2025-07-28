using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.DeepOops
{
    /*****************************************************************************************************
   Writer       : Kiran Kumar J
   Description  : Get to know about Generics Collections how useful as type safe in  advanced object
                  oriented programming
   Created Date : 28 - July - 2025
   Created By   : Kiran Kumar
   Changed Date : 28 - July - 2025
   Changed By   : Kiran Kumar
   JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/DLP-14
*****************************************************************************************************/
    /*
     * Generics           : Allows defining a class, method, or interface with a placeholder for the data type.
     * Type Safety        : Generics eliminate runtime errors by enforcing compile-time type checking.
     * Generic Collections: Strongly typed collections in System.Collections.Generic namespace.
     * Features           : Avoids  type casting, which improves performance.
    
     */

    //Generic List 
    internal class TypesSafetyGenericsCollections
    {
        internal void GenericsList() {
            List<string> names = new List<string>();
            //Type-safe: you cannot add integers to List<string>.
            names.Add("Kiran");
            names.Add("Mark");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        //Generic Dictionary<TKey, TValue>
        //Type-safe key-value mapping.
        internal void GenericDictionary()
        {
            Dictionary<int, string> empMap = new Dictionary<int, string>();
            empMap.Add(101, "Kiran");
            empMap.Add(102, "David");

            foreach (var pair in empMap)
            {
                Console.WriteLine($"ID: {pair.Key}, Name: {pair.Value}");
            }
        }

        //Custom Generic Method
        public class Printer
        {
            public void Print<T>(T data)
            {
                Console.WriteLine($"Printing: {data}");
            }
        }
        internal void CustomGenericMethod()
        {
            Printer printer = new Printer();
            printer.Print<int>(100);
            printer.Print<string>("Hello Generics");
        }


        //Custom Generic Class
        public class Container<T>
        {
            public T Value { get; set; }

            public void Show()
            {
                Console.WriteLine($"Value: {Value}");
            }
        }
        internal void CustomGenericClass()
        {
            Container<int> intContainer = new Container<int> { Value = 10 };
            intContainer.Show();  // Value: 10

            Container<string> strContainer = new Container<string> { Value = "C# Learning" };
            strContainer.Show();  // Value: C# Learning
        }

    }
}
