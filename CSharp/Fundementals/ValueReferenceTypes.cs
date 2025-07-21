using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.Fundementals
{
    internal class ValueReferenceTypes
    {
        /*****************************************************************************************************
            Writer       : Kiran Kumar J
            Description  : Value types and reference types are two fundamental categories of data types in C#.
            Created Date : 21 - July - 2025
            Created By   : Kiran Kumar
            Changed Date : 21 - July - 2025
            Changed By   : Kiran Kumar
         *****************************************************************************************************/


        // Value types are stored in the stack and hold the actual data, while reference types are stored in the heap and hold a reference to the data.
        // Value types include simple types (int, float, char, etc.), structs, and enums.

        // Reference types include classes, arrays, delegates, and strings.
        // Reference types  stored in the heap and accessed via references (pointers) in the stack.

        // The key difference is that value types hold the actual data, while reference types hold a reference to the data.
        internal void ValueTypeExample()
        {
            int a = 2013;
            int b = a; // b is a copy of a
            b = 2024; // changing b does not affect a 
            Console.WriteLine($"a: {a}, b: {b}"); // Output: a: 5, b: 15

        }
        internal void ReferenceTypeExample()
        {
            Emplpoyee e1 = new Emplpoyee { Name = "Kiran" };
            Emplpoyee e2 = e1; // e2 references the same object as e1
            e2.Name = "Mike"; // changing e2 affects e1
            Console.WriteLine($"e1: {e1.Name}, e2: {e2.Name}"); // Output: e1: Mike, e2: Mike
        }
    }
    class Emplpoyee
    {
        public string Name { get; set; }
    }
}
