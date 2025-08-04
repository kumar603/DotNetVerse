using DotNetVerse.CSharp.DeepOops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.SOLIDPrinciples.LiskovSubstitutionPrinciple_LSP
{
    /*****************************************************************************************************
   Writer       : Kiran Kumar J
   Description  : Get to know about Liskov Substitution Principle(LSP) how it is useful for  advanced object
                  oriented programming
   Created Date : 04 - August - 2025
   Created By   : Kiran Kumar
   Changed Date : 04 - August - 2025
   Changed By   : Kiran Kumar
   JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/DLP-18
  *****************************************************************************************************/
    /*
     * Liskov Substitution Principle : ensure that subclasses can be used in place of their 
     *                                  parent classes without affecting the correctness of the program
     *                                  The Liskov Substitution Principle (LSP), introduced by Liskov
     *                                  
     *                                  Objects of a superclass should be replaceable with 
     *                                  objects of its subclasses without breaking the application.
     *                                  
     *                                  A derived class must behave in a way that doesn’t surprise or 
     *                                  break the expectations of the base class users.
     *                                  
     *                                  Overriding methods in a subclass that throw NotImplementedException
     *                                  Changing expected behavior or return types
     *                                  
     * RreRequisites          : inheritance and method overriding , Familiarity with polymorphism
     *                                  
     * Features           :  LSP helps prevent "half-baked" inheritance
                             

     Project Structure Snapshot:
        LSPPaymentExample/
        │
        ├── Interfaces/
        │   ├── IPaymentProcessor.cs            --> Base interface for all payments
        │   └── ICreditCardProcessor.cs         --> Interface specific to credit card support
        │
        ├── Processors/
        │   ├── CreditCardPayment.cs           --> Implements both IPaymentProcessor and ICreditCardProcessor
        │   └── UPIPayment.cs                  --> Implements only IPaymentProcessor
        │
        ├── Program.cs                         --> Entry point demonstrating the usage

    Conclusion About LSP Principle : 
     LSP helps prevent "half-baked" inheritance.
     Use interfaces to segregate capabilities.
     Design for substitution by asking: "Can every derived type work seamlessly in place of the base type"

     */
    internal class LiskovSubstitutionPrinciple
    {
        //Use Case: Payment Gateways
        //You have a base class PaymentProcessor and different payment types like CreditCardProcessor and UPIPaymentProcessor.

        //LSP Violation Example:
        //Calling ProcessCreditCard() on a UPIPaymentProcessor will crash the app.
        //This violates LSP because UPIPaymentProcessor cannot be substituted for PaymentProcessor.
        public class PaymentProcessor
        {
            public virtual void ProcessCreditCard(string cardNumber)
            {
                Console.WriteLine("Processing credit card: " + cardNumber);
            }
        }

        public class UPIPaymentProcessor : PaymentProcessor
        {
            public override void ProcessCreditCard(string cardNumber)
            {
                throw new NotSupportedException("UPI doesn't support credit card payments");
            }
        }


        //LSP-Compliant Refactored Version:
        //Split Responsibilities Using Interfaces
        public interface IPaymentProcessor
        {
            void ProcessPayment();
        }

        public interface ICreditCardProcessor
        {
            void ProcessCreditCard(string cardNumber);
        }

        //Implement Interfaces Accordingly
        public class CreditCardPayment : IPaymentProcessor, ICreditCardProcessor
        {
            public void ProcessPayment()
            {
                Console.WriteLine("Processing generic credit card payment");
            }

            public void ProcessCreditCard(string cardNumber)
            {
                Console.WriteLine($"Charged credit card: {cardNumber}");
            }
        }

        public class UPIPayment : IPaymentProcessor
        {
            public void ProcessPayment()
            {
                Console.WriteLine("Processing UPI payment");
            }
        }

        //CreditCardPayment and UPIPayment don’t throw exceptions unexpectedly.
        //Each class adheres to the contracts(interfaces) it supports.
        //Code expecting a ICreditCardProcessor will only use types that actually implement credit card processing
    }
}
