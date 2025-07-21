using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.Fundementals
{
    /*****************************************************************************************************
            Writer       : Kiran Kumar J
            Description  : Controls the flow of execution using if else | Switch 
                             | Loops(For, While, Do While for Each).
            Created Date : 21 - July - 2025
            Created By   : Kiran Kumar
            Changed Date : 21 - July - 2025
            Changed By   : Kiran Kumar
      *****************************************************************************************************/
   
    // If Else - controls the flow based on boolean conditions.
    // Switch - selects a block of code to execute based on the value of an expression.
    // For Loop - iterates a block of code a specific number of times.
    // While Loop - executes a block of code as long as a specified condition is true.
    // Do While Loop - similar to a while loop, but guarantees at least one execution of the block.
    // For Each Loop - iterates over a collection or array, executing a block of code for each element.

    internal class ControlStructures
    {
        internal void IfElseExample()
        {
            int age = 21;
            if (age >= 18)
            {
                Console.WriteLine("Eligible to vote");
            }
            else
            {
                Console.WriteLine("Not eligible to vote");
            }
        }
        internal void SwitchExample()
        {
            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine("Other day");
                    break;
            }
        }
        internal void ForLoopExample()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Iteration {i}");
            }
        }
        internal void WhileLoopExample()
        {
            int a = 0;
            while (a < 5)
            {
                Console.WriteLine($"Iteration {a}");
                a++;
            }
             
        }
        internal void DoWhileLoopExample()
        {
            int a = 0;
            do  
            {
                Console.WriteLine($"Iteration {a}");
                a++;
            } while (a < 5) ;

        }
        internal void ForEachLoopExample()
        {
            string[] names = { "Kiran", "Mark", "Dan" };
            foreach (string name in names)
            {
                Console.WriteLine($"Names: {name}");
            }
        }
    }
}
