using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.DesignPatterns.Structural_AdapterDecorator.BurgerKingAdapterPattern
{
    internal class BurgerKingAdapterPattern
    {
        /*
         * ⭐ ADAPTER PATTERN — FULL EXPLANATION
1️⃣ What is Adapter Pattern?

Adapter Pattern is a Structural Design Pattern that lets two incompatible systems work together by converting one interface into another.

Simple meaning:

Adapter = Converter / Translator
Like a charger that converts 220V to 5V for your phone.

🍔 Burger King REAL STORY (Perfect Life Example)
Situation:

Burger King’s billing POS system only accepts:

Card Swipe

Card Tap

But the modern customer wants to pay using:

Google Pay

PhonePe

Paytm

UPI QR Code

Problem:
👉 POS machine cannot understand UPI format.

Solution:
👉 Add a UPI Payment Adapter that converts UPI request → POS readable format.

Flow:
Customer → UPI → UPI Adapter → POS Machine → Billing done


🔥 THIS is Adapter Pattern.

🎯 Why Adapter Pattern?

Because:

Old system ≠ new system

You cannot change POS machine code

You cannot force UPI to change

Adapter is middle layer that converts formats

🧠 Memory Hook
Adapter = Power Converter

Different plug shapes → same socket
Different payment types → same POS interface

2️⃣ ADAPTER DIAGRAM (Burger King Version)
        (UPI App)
         Client
           |
           v
   -----------------
   |  UPI Adapter  |  ← Converts UPI payment
   -----------------
           |
           v
    -------------------
    |  POS Payment     | ← Existing old interface
    -------------------
           |
           v
      Payment Done

3️⃣ .NET FRAMEWORK 4.8 CODE (FULL, CLEAN, COMMENTED)

Using:

IPayment (POS expected interface)

UpiPayment (Incompatible interface)

UpiToPosAdapter (Adapter class)

POS (Old system that only understands cards)
         */
    }
    // ============================================================
    // 1. TARGET INTERFACE (POS expects this)
    // ============================================================
    public interface IPayment
    {
        void Pay(double amount);
    }

    // ============================================================
    // 2. EXISTING POS CARD PAYMENT CLASS (Old System)
    // ============================================================
    public class CardPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid Rs {amount} using Card Swipe/Tap.");
        }
    }

    // ============================================================
    // 3. ADAPTEE (Incompatible UPI payment system)
    // ============================================================
    public class UpiPayment
    {
        public void SendUpiTransaction(double amount)
        {
            Console.WriteLine($"Paid Rs {amount} using UPI (Google Pay / PhonePe / Paytm).");
        }
    }

    // ============================================================
    // 4. ADAPTER (Convert UPI → IPayment interface)
    // ============================================================
    public class UpiToPosAdapter : IPayment
    {
        private UpiPayment _upiPayment;

        public UpiToPosAdapter(UpiPayment upiPayment)
        {
            _upiPayment = upiPayment;
        }

        // Convert POS payment method → UPI call
        public void Pay(double amount)
        {
            Console.WriteLine("Adapter converting POS request to UPI format...");
            _upiPayment.SendUpiTransaction(amount);
        }
    }
    }
