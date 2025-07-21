using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.Fundementals
{
    /*****************************************************************************************************
            Writer       : Kiran Kumar J
            Description  : Learn how to use arrays, lists, and dictionaries to store,
                            manage, and perform CRUD (Create, Read, Update, Delete) 
                            operations on collections of data in C#
            Created Date : 21 - July - 2025
            Created By   : Kiran Kumar
            Changed Date : 21 - July - 2025
            Changed By   : Kiran Kumar
      *****************************************************************************************************/
    //Arrays : Fixed Size of collection of same data types
    //List<T> : Dynamic collection that grows as in need for the requirement also its same data type
    //Dictionary  <TKey,TValue> :  Stores data in Key value pairs , key must be unique
    internal class ArraysListsDictionaryCRUD
    {
        internal void ArraysExample()
        {
            //Create
            int[] ages = { 21, 31, 41, 51 };

            //Read Array
            Console.WriteLine(ages[1]);

            //Update
            ages[1] = 35;

            //Delete
            //Delete not possible due to arrays are fixed in sizes

            //Display
            foreach(var age in ages)
            {
                Console.WriteLine(age);
            }
        }

        internal void ListsExample()
        {
            List<string> cities = new List<string>();

            //Create
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Denmark");

            //Read Array
            Console.WriteLine(cities[1]);

            //Update
            cities[1] = "Spain";

            //Delete
            cities.Remove("London");

            //Display
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            //Result : New York , Spain , Denmark
        }

        internal void DictionaryExample()
        {
            Dictionary<int,string> employees = new Dictionary<int, string>();

            //Create
            employees.Add(101,"Kiran");
            employees.Add(102,"Mark");
            employees.Add(103,"Dan");

            //Read Array
            Console.WriteLine(employees[101]);

            //Update
            employees[101] = "Kiran J";

            //Delete
            employees.Remove(102);

            //Display
            foreach (var emp in employees)
            {
                Console.WriteLine(emp.Value);
            }
            //Result : Kiran J , Dan
        }
    }
}
