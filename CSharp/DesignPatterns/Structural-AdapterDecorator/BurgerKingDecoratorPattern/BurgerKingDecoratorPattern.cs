using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.DesignPatterns.Structural_AdapterDecorator.BurgerKingDecoratorPattern
{
    internal class BurgerKingDecoratorPattern
    {
    }
    // ============================================================
    // 1. COMPONENT INTERFACE
    //    The base contract for Burger
    // ============================================================
    public interface IBurger
    {
        string GetDescription();
        double GetCost();
    }

    // ============================================================
    // 2. CONCRETE COMPONENT
    //    Base Burger (Chicken Whopper, Veg Whopper etc.)
    // ============================================================
    public class ChickenWhopper : IBurger
    {
        public string GetDescription()
        {
            return "Chicken Whopper";
        }

        public double GetCost()
        {
            return 150.00;   // base price
        }
    }

    // ============================================================
    // 3. DECORATOR BASE CLASS
    //    Wraps IBurger and adds new features
    // ============================================================
    public abstract class BurgerDecorator : IBurger
    {
        protected IBurger _burger;

        public BurgerDecorator(IBurger burger)
        {
            _burger = burger; // store original burger
        }

        public virtual string GetDescription()
        {
            return _burger.GetDescription();
        }

        public virtual double GetCost()
        {
            return _burger.GetCost();
        }
    }

    // ============================================================
    // 4. CONCRETE DECORATORS (Add-ons)
    // ============================================================

    // Add Cheese
    public class CheeseDecorator : BurgerDecorator
    {
        public CheeseDecorator(IBurger burger) : base(burger) { }

        public override string GetDescription()
        {
            return _burger.GetDescription() + ", Extra Cheese";
        }

        public override double GetCost()
        {
            return _burger.GetCost() + 20.00;
        }
    }

    // Add Extra Patty
    public class ExtraPattyDecorator : BurgerDecorator
    {
        public ExtraPattyDecorator(IBurger burger) : base(burger) { }

        public override string GetDescription()
        {
            return _burger.GetDescription() + ", Extra Patty";
        }

        public override double GetCost()
        {
            return _burger.GetCost() + 40.00;
        }
    }

    // Add Crispy Topping
    public class CrispyDecorator : BurgerDecorator
    {
        public CrispyDecorator(IBurger burger) : base(burger) { }

        public override string GetDescription()
        {
            return _burger.GetDescription() + ", Crispy Topping";
        }

        public override double GetCost()
        {
            return _burger.GetCost() + 25.00;
        }
    }
    }
