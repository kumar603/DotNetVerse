using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.DesignPatterns.Creational_FactoryAbstractFactoryPattern.BurgerKingFactoryPattern
{
    internal class BurgerKingFactoryPattern
    {
        /*
         Excellent answers, Kiran 👏🔥
You understood the core idea perfectly.

Let me rewrite what you said in a clean final form (to lock memory):

### **Your answers (corrected to perfect interview language)**

1️⃣ **Who creates burgers?**
➡ **Kitchen** (not customer)

2️⃣ **Who decides which burger type to prepare?**
➡ **Factory (Kitchen deciding logic)**

3️⃣ **When a new burger is added, do we change customer code?**
➡ **No — customer only sends type; only factory changes internally**

### 🧠 Memory Lock

> **Customer never cooks**
> **Kitchen decides & creates**
> **Menu can grow without changing ordering process**

That’s Factory Pattern in real life.

---

# 🍔 Connecting to Factory Pattern Definition in Software Terms

| Burger King Real Life            | Software Meaning                                 |
| -------------------------------- | ------------------------------------------------ |
| Customer orders type             | Client requests type                             |
| Kitchen decides who will prepare | Factory decides which object to create           |
| Burger prepared and returned     | Product object returned                          |
| Menu changes but ordering same   | OCP: Open for extension, closed for modification |

---

# 🎯 Final Understanding in One Simple Sentence

### **Factory Pattern is used when object creation logic is centralized and hidden from the client.**

Client only asks “what”, Factory decides “how”.

---

# 🔥 Before writing code, let’s visualize it (very simple diagram)

### 🧾 **Factory Diagram (Burger King Style)**

```
Customer (UI) 
      |
      v
  Order Type ("Chicken")
      |
      v
  BurgerFactory   <---- Decides which object to create
      |
      v
  ChickenBurger / VegBurger / FishBurger
      |
      v
   Final product to Customer
```

So now your brain sees the picture.

---

# 🧠 Interview 10-Second Version (Practice Answer)

> *Factory Pattern is a Creational Pattern where the client requests an object by type, and a factory class decides which concrete object to create. The client never uses `new` directly, supporting Open-Closed Principle.*

---

# 🎉 Now Ready for Code

Since story + purpose + mapping is clear, next step is **.NET Framework 4.8 Console Example**.

I will now give you:

### 🟩 Factory Pattern Complete .NET 4.8 console application (Burger King example)

### 🟧 Use it and run locally

### 🟦 Compare non-factory vs factory version

---

## Just confirm:

👉 **Ready for .NET 4.8 code example?**

Say:

### **Yes code**

and I will paste the runnable project code.

Waiting for your confirmation 💪😊

        | Real Burger King            | Software Meaning               |
        | --------------------------- | ------------------------------ |
        | Customer orders             | Client asks                    |
        | Kitchen decides             | Factory decides                |
        | Chef makes correct burger   | Concrete product class created |
        | Customer gets final product | Client receives ready object   |



        Permanent Memory Trigger
Customer never cooks – kitchen does.
UI never creates objects – Factory does.

        We use interface because we want flexibility, loose coupling, extensibility, and SOLID design — not hard-coded dependency.


        Customer orders → Kitchen decides → Factory creates → UI receives

        */

    }
    // ----------- Product Interface -----------
    public interface IBurger
    {
        void Prepare();
    }
    // ----------- Concrete Products -----------
    public class ChickenBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing Chicken Whopper...\nGrilling chicken patty\nAdding bun\nPacking \n");
        }
    }
    public class VegBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing Veg Burger...\nCooking veg patty\nAdding lettuce and cheese\nPacking \n");
        }
    }
    public class FishBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing Fish Burger...\nFrying fish patty\nAdding tartar sauce\nPacking\n");
        }
    }
    // ----------- Factory Class (Kitchen) -----------
    public class BurgerFactory
    {
        public static IBurger CreateBurger(string type)
        {
            switch (type)
            {
                case "Chicken":
                    return new ChickenBurger();
                case "Veg":
                    return new VegBurger();
                case "Fish":
                    return new FishBurger();
                default:
                    throw new Exception("Invalid Burger Type");
            }
        }
        
    }

}
