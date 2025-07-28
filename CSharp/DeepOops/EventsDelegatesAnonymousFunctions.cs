using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.DeepOops
{
    /*****************************************************************************************************
   Writer       : Kiran Kumar J
   Description  : Get to know about Events,Delegates and Anonymous functions used in advanced object
                  oriented programming
   Created Date : 28 - July - 2025
   Created By   : Kiran Kumar
   Changed Date : 28 - July - 2025
   Changed By   : Kiran Kumar
   JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/DLP-13
*****************************************************************************************************/
    /*
     * Delegate           : A type-safe function pointer. Holds references to methods with a specific signature.
     * Anonymous Function : A method without a name (inline) – created using delegate 
     * Event              : A messaging mechanism that uses delegates to allow subscribers to be notified when something happens.
     * Features           : Call methods dynamically
     *                      Write one-time-use functions
     *                      Implement publisher/subscriber
    
     */
    internal class EventsDelegatesAnonymousFunctions
    {
        
       //Delegates
        public delegate void GreetDelegate(string name);
        public class Greeter
        {
            public void SayHello(string name)
            {
                Console.WriteLine($"Welcome, {name}!");
            }
        }
        //Anonymous Function
        GreetDelegate greet = delegate (string name)
        {
            Console.WriteLine("Welcome, " + name);
        };
        GreetDelegate greettype = name => Console.WriteLine($"Hi, {name}");

        //Events 
        public class Alarm
        {
            public event Action OnAlarmTriggered;

            public void Trigger()
            {
                Console.WriteLine("Alarm triggered!");
                OnAlarmTriggered?.Invoke(); // Notify subscribers
            }
        }
        internal void DelegatesExample()
        {
            Greeter greeter = new Greeter();
            GreetDelegate del = new GreetDelegate(greeter.SayHello);
            del("Kiran");  // Output: Welcome, Kiran!
        }

        internal void AnonymousExample()
        {
            greet("Kiran");
            greettype("Kiran");
        }

        internal void EventsExample()
        {
            Alarm alarm = new Alarm();
            alarm.OnAlarmTriggered += () => Console.WriteLine("Handler: event executed !");
            alarm.Trigger();
            // Output:
            // Alarm triggered!
        }
    }
  
    
    
}
