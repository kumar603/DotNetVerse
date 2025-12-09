using DotNetVerse.CSharp.DeepOops;
using DotNetVerse.CSharp.DesignPatterns.Behavioral_StrategyPattern.BurgerKingStratergyPattern;
using DotNetVerse.CSharp.DesignPatterns.Creational_FactoryAbstractFactoryPattern.BurgerKingFactoryPattern;
using DotNetVerse.CSharp.DesignPatterns.Creational_SingletonPattern.BurgerKingTokenSystem;
using DotNetVerse.CSharp.DesignPatterns.CreationalFactoryAbstractFactoryPattern;
using DotNetVerse.CSharp.DesignPatterns.CreationalSingletonPattern;
using DotNetVerse.CSharp.Fundementals;
using DotNetVerse.CSharp.SOLIDPrinciples.LiskovSubstitutionPrinciple_LSP;
using DotNetVerse.CSharp.SOLIDPrinciples.OpenClosedPrinciple_OCP;
using DotNetVerse.CSharp.SOLIDPrinciples.SingleResponsibilityPrinciple_SRP;
using DotNetVerse.CSharp.SOLIDPrinciples.SOLIDSampleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DotNetVerse.CSharp.DesignPatterns.CreationalSingletonPattern.CreationalSingletonPattern_CSP;
using static DotNetVerse.CSharp.SOLIDPrinciples.DependencyInversionPrinciple_DIP.DependencyInversionPrinciple;
using static DotNetVerse.CSharp.SOLIDPrinciples.InterfaceSegregationPrinciple_ISP.InterfaceSegregationPrinciple;
using static DotNetVerse.CSharp.SOLIDPrinciples.LiskovSubstitutionPrinciple_LSP.LiskovSubstitutionPrinciple;
using static DotNetVerse.CSharp.SOLIDPrinciples.OpenClosedPrinciple_OCP.OpenClosedPrinciple;
namespace DotNetVerse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ValueReferenceTypes();
            //ControlStructures()'
            //ArraysListsDictionaryCRUD();
            //DataManagement();
            //ExceptionManagement();
            //FilesManagement();
            //RetroFundamentalsAppExample();

            //Part 2 - Deep Dive into OOPS in C#
            //ClassesObjectsConstructors();
            // InheritanceAbstractClass();
            //Interfaces()
            //Polymorphism(); 
            //Encapsulation();
            //EventsDelegatesAnonymousFunctions();
            //TypesSafetyGenericsCollections();

            //Part 3 - SOLID Principles in C#
            //SingleResponsibilityPrinciple();
            //OpenClosedPrinciple();
            //LiskovSubstitutionPrinciple();
            //InterfaceSegregationPrinciple();
            //DependencyInversionPrinciple();
            //SOLIDSampleApp();

            //Part 4 - Design Patterns  in C#
            //CreationalSingletonPattern();
            //CreationalFactoryAbstractFactoryPattern();


            //Relearn Design Pattrens
            //CreationalSingletonPattern_BurgerKingTokenExample();
            //CreationalFactoryAbstractFactoryPattern_CreateBurger();
            BehavioralStrategyPattern_MakeBurgerWithStrateryExample();
        }
        public static void ValueReferenceTypes()
        {
            ValueReferenceTypes valueReferenceTypes = new ValueReferenceTypes();
            valueReferenceTypes.ValueTypeExample();
            valueReferenceTypes.ReferenceTypeExample();
            Console.ReadKey();
        }
        public static void ControlStructures()
        {
            ControlStructures controlStructures = new ControlStructures();
            controlStructures.IfElseExample();
            controlStructures.SwitchExample();
            controlStructures.ForLoopExample();
            controlStructures.WhileLoopExample();
            controlStructures.DoWhileLoopExample();
            controlStructures.ForEachLoopExample();
            Console.ReadKey();
        }
        public static void ArraysListsDictionaryCRUD()
        {
            ArraysListsDictionaryCRUD arraysListsDictionaryCRUD = new ArraysListsDictionaryCRUD();
            arraysListsDictionaryCRUD.ArraysExample();
            arraysListsDictionaryCRUD.ListsExample();
            arraysListsDictionaryCRUD.DictionaryExample();
            Console.ReadKey();
        }
        public static void DataManagement()
        {
            DataManagement dataManagement = new DataManagement();
            dataManagement.StringExample();
            dataManagement.StringBuilderExample();
            dataManagement.DateTimeExample();
            Console.ReadKey();
        }
        public static void ExceptionManagement()
        {
            ExceptionManagement exceptionManagement = new ExceptionManagement();
            exceptionManagement.ExceptionManagementWithSingleTryCatchExample();
            exceptionManagement.ExceptionManagementWithSingleTryMultiCatchExample();

            Console.ReadKey();
        }
        public static void FilesManagement()
        {
            FilesManagement filesManagement = new FilesManagement();
            filesManagement.FilesManagementWithFileExample();
            filesManagement.FilesManagementWithStreamReadAndWriter();

            Console.ReadKey();
        }
        public static void RetroFundamentalsAppExample()
        {
            RetroFundamentalsApp retroFundamentalsApp = new RetroFundamentalsApp();
            retroFundamentalsApp.RetroFundamentalsAppExample();

        }

        //Deep Dive into OOPS in C#
        public static void ClassesObjectsConstructors()
        {
            ClassesObjectsConstructors classesObjectsConstructors = new ClassesObjectsConstructors();
            classesObjectsConstructors.CreateClassWithFieldsExample();
            classesObjectsConstructors.CreateClassWithPropertiesExample();
            classesObjectsConstructors.CreateClassWithFieldsAndConstructorExample();
            Console.ReadKey();
        }
        public static void InheritanceAbstractClass()
        {
            InheritanceAbstractClass inheritanceAbstractClass = new InheritanceAbstractClass();
            inheritanceAbstractClass.InheritanceExample();
            inheritanceAbstractClass.AbstractClassExample();
            Console.ReadKey();
        }
        public static void Interfaces()
        { 
             Interfaces interfaces = new Interfaces();
            interfaces.InterfacesExample();
            interfaces.InterfacesExample();
            Console.ReadKey(); 
        }
        public static void Polymorphism()
        {
            Polymorphism  polymorphism = new Polymorphism();
            polymorphism.CompiletimeMethodOverloadingPolymorhismExample();
            polymorphism.RuntimeMethodOverRidingPolymorhismExample();
            Console.ReadKey();
        }
        public static void Encapsulation()
        {
            Encapsulation  encapsulation = new Encapsulation();
            encapsulation.EncapsulationExample();
            Console.ReadKey();
        }
        public static void EventsDelegatesAnonymousFunctions()
        {
            EventsDelegatesAnonymousFunctions eventsDelegatesAnonymousFunctions = new EventsDelegatesAnonymousFunctions();
            eventsDelegatesAnonymousFunctions.DelegatesExample();
            eventsDelegatesAnonymousFunctions.AnonymousExample();
            eventsDelegatesAnonymousFunctions.EventsExample();
            Console.ReadKey();
        }
        public static void TypesSafetyGenericsCollections()
        {
            TypesSafetyGenericsCollections  typesSafetyGenericsCollections = new TypesSafetyGenericsCollections();
            typesSafetyGenericsCollections.GenericsList();
            typesSafetyGenericsCollections.GenericDictionary();
            typesSafetyGenericsCollections.CustomGenericMethod();
            typesSafetyGenericsCollections.CustomGenericClass();
            Console.ReadKey();
        }
        public static void RetroDeepDiveOops()
        {
            RetroDeepDiveOops retroDeepDiveOops = new RetroDeepDiveOops();
            retroDeepDiveOops.RetroDeepDiveOopsExample();
            Console.ReadKey();
        }
        public static void SingleResponsibilityPrinciple()
        {
            SingleResponsibilityPrinciple.UserService singleResponsibilityPrinciple = new SingleResponsibilityPrinciple.UserService();
            singleResponsibilityPrinciple.RegisterUser("Kiran Kumar");
            Console.ReadKey();
        }
        public static void OpenClosedPrinciple()
        {
            OpenClosedPrinciple.IDiscountStrategy discountStrategy = new OpenClosedPrinciple.PremiumCustomerDiscount();
            var calculator = new DiscountCalculatorOCP(discountStrategy);
            Console.WriteLine("Final Amount: " + calculator.GetDiscountedPrice(1000));
            Console.ReadKey();
        }
        public static void LiskovSubstitutionPrinciple()
        {

            IPaymentProcessor upi = new UPIPayment();
            upi.ProcessPayment();

            ICreditCardProcessor credit = new CreditCardPayment();
            credit.ProcessCreditCard("5111-1111-1111-1111");

            Console.ReadKey();
        }
        public static void InterfaceSegregationPrinciple()
        {
            IPrinterISP printer = new OldPrinterISP();
            printer.Print();

            IScannerLSP scanner = new ScannerOnlyDevice();
            scanner.Scan();

            ModernMultifunctionPrinter mfp = new ModernMultifunctionPrinter();
            mfp.Print();
            mfp.Scan();
            mfp.Fax();
            Console.ReadKey();
        }
        public static void DependencyInversionPrinciple()
        {
            INotificationService emailService = new EmailNotification();
            INotificationService smsService = new SmsNotification();

            var emailSender = new NotificationSenderDIP(emailService);
            emailSender.NotifyDIP("Message from email notifications");

            var smsSender = new NotificationSenderDIP(smsService);
            smsSender.NotifyDIP("Message from sms notifications");
            Console.ReadKey();
        }
        public static void SOLIDSampleApp()
        {
           SOLIDSampleApp sampleApp = new SOLIDSampleApp();
            sampleApp.SOLIDSampleAppExample();
            Console.ReadKey();
        }
        public static void CreationalSingletonPattern()
        {
            CreationalSingletonPattern_CSP creationalSingletonPattern = new CreationalSingletonPattern_CSP();
            creationalSingletonPattern.CreationalSingletonPatternTest();
            Console.ReadKey();
        }
        public static void CreationalFactoryAbstractFactoryPattern()
        {
            CreationalFactoryAbstractFactoryPattern_CFP creationalFactoryAbstractFactoryPattern = new CreationalFactoryAbstractFactoryPattern_CFP();
            creationalFactoryAbstractFactoryPattern.CreationalFactoryPatternTest();
            Console.ReadKey();
        }
        public static void CreationalSingletonPattern_BurgerKingTokenExample()
        {
            // creating screens (normal objects)
            DisplayScreen screenA = new DisplayScreen("Screen A (Counter)");
            DisplayScreen screenB = new DisplayScreen("Screen B (Waiting Area)");
            DisplayScreen screenC = new DisplayScreen("Screen C (Pickup Area)");

            Console.WriteLine("----- Burger King Token Display System (Singleton Example) -----");
            Console.WriteLine();

            // First display (before serving next)
            screenA.Show();
            screenB.Show();
            screenC.Show();

            Console.WriteLine("\nKitchen presses NEXT -> TokenManager.NextToken()\n");

            // Update Token (single instance)
            TokenManager.Instance.NextToken();

            // After update - all screens read same token
            screenA.Show();
            screenB.Show();
            screenC.Show();

            Console.WriteLine("\nKitchen presses NEXT again...\n");

            TokenManager.Instance.NextToken();

            screenA.Show();
            screenB.Show();
            screenC.Show();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        public static void CreationalFactoryAbstractFactoryPattern_CreateBurger()
        {
            Console.WriteLine("===== Welcome to Burger King Factory Pattern Demo =====");
            Console.Write("Enter Burger Type (Chicken / Veg / Fish): ");

            string input = Console.ReadLine();

            // Customer never creates burger directly → asks factory
            IBurger burger = BurgerFactory.CreateBurger(input);

            // Factory returns correct object and prepares it
            burger.Prepare();

            Console.WriteLine("Order Completed Successfully! 🎉");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        public static void BehavioralStrategyPattern_MakeBurgerWithStrateryExample()
        {
            Console.WriteLine("=== Burger King Strategy Pattern Demo ===\n");

            // We fixed burger type as example (Chicken Burger)
            // Factory Pattern would normally select this object.
            Burger burger = new Burger("Chicken Whopper");

            Console.WriteLine("Select Cooking Style:");
            Console.WriteLine("1. Grilled");
            Console.WriteLine("2. Crispy");
            Console.WriteLine("3. Spicy");

            Console.Write("\nEnter option (1-3): ");
            string choice = Console.ReadLine();

            // Set cooking style based on user choice
            switch (choice)
            {
                case "1":
                    burger.SetCookingStrategy(new GrilledStrategy());
                    break;

                case "2":
                    burger.SetCookingStrategy(new CrispyStrategy());
                    break;

                case "3":
                    burger.SetCookingStrategy(new SpicyStrategy());
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    return;
            }

            Console.WriteLine();
            burger.Cook();  // Apply selected behavior

            Console.WriteLine("\nOrder completed! Press any key to exit...");
            Console.ReadKey();
        }
    
    }
}
