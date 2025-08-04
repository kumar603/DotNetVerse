using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.SOLIDPrinciples.OpenClosedPrinciple_OCP
{
    /*****************************************************************************************************
   Writer       : Kiran Kumar J
   Description  : Get to know about Open Closed Principle and how it is useful for  advanced object
                  oriented programming
   Created Date : 04 - August - 2025
   Created By   : Kiran Kumar
   Changed Date : 04 - August - 2025
   Changed By   : Kiran Kumar
   JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/DLP-17
  *****************************************************************************************************/
    /*
     * Open Closed Principle :Software entities should be open for extension but closed for Changes
     *                        This means you should be able to add new function without changing 
     *                        the existing, tested, and deployed code.
     *              
     * Features           : Prevents breaking existing functions
                            Encourages plugin-like architecture
                            Fosters scalability and maintainability

    Use abstraction: interfaces or base classes
    Use polymorphism (method overriding)
    Apply inheritance or composition

    PreRequisites : Knowledge of Interfaces and Inheritance in C#
                    Basic understanding of Polymorphism

    Project Structure Snapshot:
    OCPExample/
    │
    ├── IDiscountStrategy.cs          --> Interface for discount behavior
    ├── RegularCustomerDiscount.cs    --> Logic for regular customers
    ├── PremiumCustomerDiscount.cs    --> Logic for premium customers
    ├── DiscountCalculator.cs         --> Uses the strategy
    ├── Program.cs                    --> Entry point

    Conclusion About SRP Principle : 
    OCP promotes code reuse and extensibility.
    Avoids risky changes in existing, working logic.
    Implementing using interfaces, inheritance, or strategy/decorator patterns

     */
    internal class OpenClosedPrinciple
    {
        //Violating OCP
        //Each time a new customer type is introduced, the method must be changed, violating OCP.
        public class DiscountCalculator
        {
            public double CalculateDiscount(string customerType, double amount)
            {
                if (customerType == "Regular")
                    return amount * 0.1;
                else if (customerType == "Premium")
                    return amount * 0.2;
                else
                    return 0;
            }
        }

        //Good Example: OCP Applied with Strategy Pattern
        public interface IDiscountStrategy
        {
            double ApplyDiscount(double amount);
        }
        public class RegularCustomerDiscount : IDiscountStrategy
        {
            public double ApplyDiscount(double amount) => amount * 0.1;
        }
        public class PremiumCustomerDiscount : IDiscountStrategy
        {
            public double ApplyDiscount(double amount) => amount * 0.2;
        }
        public class DiscountCalculatorOCP
        {
            private readonly IDiscountStrategy _strategy;

            public DiscountCalculatorOCP(IDiscountStrategy strategy)
            {
                _strategy = strategy;
            }

            public double GetDiscountedPrice(double amount)
            {
                return _strategy.ApplyDiscount(amount);
            }
        }
    }
}
