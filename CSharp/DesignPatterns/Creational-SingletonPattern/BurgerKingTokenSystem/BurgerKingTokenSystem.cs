using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.DesignPatterns.Creational_SingletonPattern.BurgerKingTokenSystem
{
    internal class BurgerKingTokenSystem
    {
        /*
         Singleton is a pattern where a class allows only one instance and provides global access to it using a private constructor and a static instance. It ensures shared consistent state, like Burger King token display screens reading from one TokenManager

        | Singleton Key        | Burger King Meaning                  |
        | -------------------- | ------------------------------------ |
        | Private constructor  | No separate token manager per screen |
        | Static instance      | One real token controller            |
        | Static global access | All screens call same instance       |
        | Single instance only | Prevents confusion                   |
        | Shared state         | Same token everywhere                |



        | Key                                         | Meaning                                   | Memory Hook                         |
        | ------------------------------------------- | ----------------------------------------- | ----------------------------------- |
        | **1. Private constructor**                  | Stops other classes from creating objects | No one else can create TokenManager |
        | **2. Static instance field**                | Holds the *only* object                   | One permanent shared instance       |
        | **3. Static global access property/method** | Everyone gets the same instance           | `TokenManager.Instance`             |
        | **4. Only one instance allowed**            | Enforced uniqueness                       | Only one TokenManager in restaurant |
        | **5. Shared state**                         | All consumers see same data               | All screens show same token         |



        Whenever someone says Singleton, your brain should automatically say:
        “Private constructor + static instance + global access + one shared state.”
        Just 4 words you must recall:
        👉 Private
        👉 Static Instance
        👉 Global Access
        👉 Single Object



        | Category       | Purpose                          | Example Patterns                                                                |
        | -------------- | -------------------------------- | ------------------------------------------------------------------------------- |
        | **Creational** | Object creation mechanisms       | **Singleton**, Factory, Abstract Factory, Builder, Prototype                    |
        | **Structural** | How classes/objects are combined | Adapter, Decorator, Facade, Composite, Proxy, Bridge                            |
        | **Behavioral** | Communication between objects    | Strategy, Observer, Command, Mediator, State, Chain of Responsibility, Iterator |


        | Category       | Burger King Example                  | Pattern Meaning         |
        | -------------- | ------------------------------------ | ----------------------- |
        | **Creational** | How burgers are created in kitchen   | Object creation control |
        | Structural     | How restaurant sections are arranged | Combining objects       |
        | Behavioral     | How staff interact & handle orders   | Object communication    |




         */

    }
    // ---------------- Singleton TokenManager ----------------
    public sealed class TokenManager
    {
        private readonly static TokenManager _instance = new TokenManager();


        private int _currentToken = 100;  // starting token number

        // Private constructor to prevent external Instantiation
        private TokenManager() { }

        // Global access to the instance
        public static TokenManager Instance
        {
            get { return _instance; }
        }

        public int CurrentToken
        {
            get { return _currentToken; }
        }

        public void NextToken()
        {
            _currentToken++;
        }

    }


    // ---------------- Display Screens ----------------
    public class DisplayScreen
    {
        private string _screenName;

        public DisplayScreen(string name)
        {
            _screenName = name;
        }

        public void Show()
        {
            Console.WriteLine(_screenName + ": Now Serving Token " + TokenManager.Instance.CurrentToken);
        }
    }
}
