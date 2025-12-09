using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.DesignPatterns.Behavioral_StrategyPattern.BurgerKingStratergyPattern
{
    internal class BurgerKingStrategyPattern
    {

    }

    // ============================================================
    // 1. STRATEGY INTERFACE
    //    Defines the behavior (cooking style)
    // ============================================================
    public interface ICookingStrategy
    {
        void Cook(string burgerName);
    }

    // ============================================================
    // 2. CONCRETE STRATEGIES
    //    Different cooking methods (behaviors)
    // ============================================================

    // Grilled cooking style
    public class GrilledStrategy : ICookingStrategy
    {
        public void Cook(string burgerName)
        {
            Console.WriteLine($"[Grilled] Cooking {burgerName} on open flame grill...");
        }
    }

    // Crispy cooking style
    public class CrispyStrategy : ICookingStrategy
    {
        public void Cook(string burgerName)
        {
            Console.WriteLine($"[Crispy] Deep frying {burgerName} until golden crispy...");
        }
    }

    // Spicy cooking style
    public class SpicyStrategy : ICookingStrategy
    {
        public void Cook(string burgerName)
        {
            Console.WriteLine($"[Spicy] Marinating {burgerName} with spicy sauce and grilling...");
        }
    }

    // ============================================================
    // 3. CONTEXT CLASS (BURGER)
    //    This class uses a strategy to decide HOW the burger is cooked.
    // ============================================================
    public class Burger
    {
        private string _burgerName;
        private ICookingStrategy _cookingStrategy;   // Composition → Strategy is stored here

        public Burger(string name)
        {
            _burgerName = name;
        }

        // Assign strategy at runtime (Grilled, Crispy, Spicy...)
        public void SetCookingStrategy(ICookingStrategy cookingStrategy)
        {
            _cookingStrategy = cookingStrategy;
        }

        // Execute the selected strategy
        public void Cook()
        {
            if (_cookingStrategy == null)
            {
                Console.WriteLine("No cooking strategy selected for the burger!");
                return;
            }

            _cookingStrategy.Cook(_burgerName);
        }
    }
}
