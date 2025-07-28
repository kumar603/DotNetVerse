using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.DeepOops
{
    /*****************************************************************************************************
    Writer       : Kiran Kumar J
    Description  : Get to know about Encapsulation in oops with hiding variables access specifiers
    Created Date : 28 - July - 2025
    Created By   : Kiran Kumar
    Changed Date : 28 - July - 2025
    Changed By   : Kiran Kumar
    JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/DLP-12
 *****************************************************************************************************/
    /*
     * Encapsulation : Encapsulation is the process of wrapping data (variables) and code (methods) together into a single unit — a class.
     * Rules         : Internal data is kept private and only exposed using public properties (getters/setters).
     * Features      : Prevent unintended access and Changes, Reduce tight coupling between classes
    
     */
    internal class Encapsulation
    {
        internal void EncapsulationExample() {
            var account = new BankAccount();
            account.Deposit(1000);
            account.Withdraw(500);
            Console.WriteLine(account.Balence); // Output: 500
        }
        public class BankAccount
        {
        private double balence; // internal data is hidden

        public double Balence
        {
        get { return balence; }
        private set // secure the setter, only allow updates inside class
        {
            if (value >= 0)
                balence = value;
        }
        }

        public void Deposit(double amount)
        {
        if (amount > 0)
        {
            Balence += amount;
        }
        }

        public void Withdraw(double amount)
        {
        if (amount > 0 && amount <= Balence)
        {
            Balence -= amount;
        }
        }
        }
    }
}
