using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.Fundementals
{
    /*****************************************************************************************************
           Writer       : Kiran Kumar J
           Description  : Learn how to manage data with string,  stringbuilder and DateTime
           Created Date : 21 - July - 2025
           Created By   : Kiran Kumar
           Changed Date : 21 - July - 2025
           Changed By   : Kiran Kumar
     *****************************************************************************************************/
    //String : Its Immutable
    //String Builder : Mutable 
    //String Builder : Provides funtions to store the date times  
    internal class DataManagement
    {
        internal void StringExample()
        {
            string name = "Kiran Kumar";
            Console.WriteLine(name);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Substring(1,5));
            Console.WriteLine(name.Replace("Kiran", "Mr Kiran"));

        }
        internal void StringBuilderExample()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Kiran ");
            sb.Append("For Getting Job ");
            sb.Append("Do Practice and pray God ");

            Console.WriteLine(sb.ToString());

        }

        internal void DateTimeExample()
        {
            DateTime joindate = new DateTime(2007,05,07);
            DateTime today = DateTime.Today;

            TimeSpan age = today - joindate;

            Console.WriteLine($"Days Since First Job: {age.Days}");

            Console.WriteLine(DateTime.Now.ToString("dd MMM yyyy hh:mm tt"));
        }
    }
}
