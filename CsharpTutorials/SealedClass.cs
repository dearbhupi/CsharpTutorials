using CsharpTutorials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CsharpTutorials
{

    /// <summary>
    /// Sealed Class Example 
    /// class like systemInformation that consisst of valueable method and we dont want to expose them
    /// you want another class to inherit from it, but you want to prevent further inheritance. and copy right issue
    /// difference between sealed and abstract class is that sealed class cannot be inherited at all, while abstract class can be inherited but not instantiated.
    /// difference between sealed class and private class is that sealed class can be accessed from outside the assembly, while private class cannot be accessed outside the class it is defined in.
    /// difference between sealed class and static class is that sealed class can be instantiated, while static class cannot be instantiated.
    /// difference between sealed class and normal class is that sealed class cannot be inherited, while normal class can be inherited.
    /// difference betweeen sealed class and interface is that sealed class can have implementation, while interface cannot have implementation.
    /// difference between sealed class and private class is that sealed class can not be inherited, while private class can be inherited but not accessed outside the class it is defined in.
    /// </summary>
    sealed class SealedClass 
    {
        public void Display()
        {
            Console.WriteLine("This is a Sealed Class");
        }
    }
     public class regularClass
    {
        public void Display()
        {
            Console.WriteLine("This is a regular NON Sealed Class");
        }
    }

    //public class DerivedClass : SealedClass
    public class DerivedClass : regularClass
    {
        // This will cause a compile-time error because SealedClass cannot be inherited.
        public void Show()
        {
            Console.WriteLine("This is a Derived Class");
        }
    }
}


//try this in the main programe
//class Programe
//{
//    static void Main(string[] args)
//    {

//        DerivedClass derived = new DerivedClass();
//        derived.Display();
//        derived.Show();

//        //Console.WriteLine("This is Main programe");
//    }
//}
//"""
//Difference Between Private Class and Sealed Class
//Private Class
//Definition: A class declared with the private access modifier restricts its accessibility to within the same enclosing class or struct (i.e., it is a nested class). A private class cannot be accessed from outside its containing type.

//Purpose: Used to encapsulate implementation details within a parent class, hiding the nested class from external code. It’s primarily about access control.

//Scope: Only accessible within the enclosing class or struct. It cannot be instantiated or accessed from outside, even within the same assembly.

//Extensibility: A private class can still be inherited (if explicitly allowed), but its visibility is restricted to the enclosing type.

//Use Case: Ideal for helper or utility classes that are only relevant within a specific class’s implementation.

//Sealed Class
//Definition: A class declared with the sealed keyword cannot be inherited by other classes. It restricts inheritance, preventing any class from deriving from it.

//Purpose: Used to prevent further extension of a class, ensuring its behavior and implementation remain unchanged. It’s about restricting inheritance.

//Scope: A sealed class can have any access modifier (public, internal, etc.) and is accessible based on that modifier, but no class can inherit from it.

//Extensibility: Explicitly prevents inheritance, locking the class’s structure and behavior.

//Use Case: Useful when a class is fully defined, and you want to prevent unintended modifications through inheritance or ensure performance optimizations (e.g., inlining by the compiler).

//Key Differences
//Feature

//Private Class

//Sealed Class

//Purpose

//Controls visibility (access restriction)

//Prevents inheritance

//Scope

//Only within the enclosing class/struct

//Accessible based on its access modifier

//Inheritance

//Can be inherited (if allowed) within scope

//Cannot be inherited by any class

//Access Modifier

//Always 
//private
// (nested class)

//Can be 
//public
//, 
//internal
//, etc.

//Use Case

//Encapsulation of internal logic

//Finalizing a class’s implementation

//Performance Impact

//No direct performance impact

//May allow compiler optimizations

//10 Real-Life Examples with Detailed Explanations
//Below are 10 real-life scenarios where private classes and sealed classes are used, with code examples and explanations of why each is appropriate.
//Private Class Examples
//Private classes are used for encapsulation, typically as nested classes to hide implementation details within a parent class.
//Order Processing System (OrderItem as Private Class)
//Scenario: An e-commerce system has an Order class that manages order details. An OrderItem class, representing individual items in an order, is only relevant within the Order class.

//Why Private?: OrderItem is an implementation detail of Order and should not be exposed or instantiated outside it.

//Code:
//csharp

//public class Order
//{
//    private class OrderItem
//    {
//        public string ItemName { get; set; }
//        public decimal Price { get; set; }
//        public int Quantity { get; set; }

//        public decimal GetTotal() => Price * Quantity;
//    }

//    private List<OrderItem> items = new List<OrderItem>();

//    public void AddItem(string name, decimal price, int quantity)
//    {
//        items.Add(new OrderItem { ItemName = name, Price = price, Quantity = quantity });
//    }

//    public decimal CalculateTotal()
//    {
//        return items.Sum(item => item.GetTotal());
//    }
//}

//Explanation: OrderItem is private to ensure no external code can create or manipulate order items directly, maintaining encapsulation. The Order class fully controls how items are managed.

//Bank Account (Transaction as Private Class)
//Scenario: A BankAccount class tracks transactions (deposits, withdrawals). A Transaction class is used internally to store transaction details.

//Why Private?: Transactions are specific to the account’s internal logic and shouldn’t be accessible outside.

//Code:
//csharp

//public class BankAccount
//{
//    private class Transaction
//    {
//        public DateTime Date { get; set; }
//        public decimal Amount { get; set; }
//        public string Type { get; set; } // Deposit or Withdrawal
//    }

//    private List<Transaction> transactions = new List<Transaction>();
//    public decimal Balance { get; private set; }

//    public void Deposit(decimal amount)
//    {
//        Balance += amount;
//        transactions.Add(new Transaction { Date = DateTime.Now, Amount = amount, Type = "Deposit" });
//    }
//}

//Explanation: The private Transaction class ensures that transaction data is only managed by BankAccount, preventing external manipulation.

//Game Engine (Sprite as Private Class)
//Scenario: A game engine’s Scene class manages visual elements like sprites. A Sprite class is used internally to handle sprite properties.

//Why Private?: Sprites are internal to the scene’s rendering logic and shouldn’t be exposed to other parts of the game.

//Code:
//csharp

//public class Scene
//{
//    private class Sprite
//    {
//        public string Image { get; set; }
//        public int X { get; set; }
//        public int Y { get; set; }
//    }

//    private List<Sprite> sprites = new List<Sprite>();

//    public void AddSprite(string image, int x, int y)
//    {
//        sprites.Add(new Sprite { Image = image, X = x, Y = y });
//    }
//}

//Explanation: Sprite is private to encapsulate rendering logic within Scene, ensuring external code doesn’t interfere with sprite management.

//Logger (LogEntry as Private Class)
//Scenario: A Logger class records log messages. A LogEntry class stores details of each log entry (timestamp, message, level).

//Why Private?: Log entries are internal to the logger’s functionality and shouldn’t be manipulated externally.

//Code:
//csharp

//public class Logger
//{
//    private class LogEntry
//    {
//        public DateTime Timestamp { get; set; }
//        public string Message { get; set; }
//        public string Level { get; set; }
//    }

//    private List<LogEntry> logs = new List<LogEntry>();

//    public void Log(string message, string level)
//    {
//        logs.Add(new LogEntry { Timestamp = DateTime.Now, Message = message, Level = level });
//    }
//}

//Explanation: LogEntry is private to prevent external code from creating or modifying log entries, ensuring the logger’s integrity.

//Shopping Cart (CartItem as Private Class)
//Scenario: A ShoppingCart class manages items added by a user. A CartItem class stores details of each item.

//Why Private?: Cart items are only relevant within the cart’s context and should be hidden from external access.

//Code:
//csharp

//public class ShoppingCart
//{
//    private class CartItem
//    {
//        public string ProductId { get; set; }
//        public int Quantity { get; set; }
//    }

//    private List<CartItem> items = new List<CartItem>();

//    public void AddItem(string productId, int quantity)
//    {
//        items.Add(new CartItem { ProductId = productId, Quantity = quantity });
//    }
//}

//Explanation: CartItem is private to encapsulate cart-specific logic, preventing external code from directly manipulating the cart’s contents.

//Sealed Class Examples
//Sealed classes are used to prevent inheritance, ensuring a class’s behavior remains fixed or optimizing performance.
//MathUtility (Sealed Utility Class)
//Scenario: A MathUtility class provides mathematical helper functions (e.g., calculating factorials or square roots).

//Why Sealed?: The class is a utility with fixed functionality, and inheritance could lead to unintended modifications.

//Code:
//csharp

//public sealed class MathUtility
//{
//    public static int Factorial(int n)
//    {
//        if (n < 0) throw new ArgumentException("Negative input not allowed.");
//        if (n == 0) return 1;
//        return n * Factorial(n - 1);
//    }
//}

//Explanation: MathUtility is sealed to prevent inheritance, as its static methods are complete and shouldn’t be overridden or extended.

//ConfigurationManager (Sealed Singleton)
//Scenario: A ConfigurationManager class provides access to application settings using the Singleton pattern.

//Why Sealed?: The singleton pattern requires a single instance, and sealing prevents subclasses from breaking this pattern.

//Code:
//csharp

//public sealed class ConfigurationManager
//{
//    private static readonly ConfigurationManager instance = new ConfigurationManager();
//    private Dictionary<string, string> settings = new Dictionary<string, string>();

//    private ConfigurationManager() { }

//    public static ConfigurationManager Instance => instance;

//    public void SetSetting(string key, string value) => settings[key] = value;
//    public string GetSetting(string key) => settings.GetValueOrDefault(key);
//}

//Explanation: Sealing ensures no class can inherit and alter the singleton behavior, preserving the single-instance guarantee.

//EmailValidator (Sealed Validation Class)
//Scenario: An EmailValidator class validates email addresses using a fixed set of rules.

//Why Sealed?: The validation logic is complete and shouldn’t be modified through inheritance.

//Code:
//csharp

//public sealed class EmailValidator
//{
//    public bool IsValidEmail(string email)
//    {
//        if (string.IsNullOrEmpty(email)) return false;
//        return email.Contains("@") && email.Contains(".");
//    }
//}

//Explanation: EmailValidator is sealed to lock its validation logic, preventing subclasses from altering the rules.

//PaymentProcessor (Sealed Business Logic)
//Scenario: A PaymentProcessor class handles payment transactions for an e-commerce platform.

//Why Sealed?: The payment logic is critical and shouldn’t be extended or modified to ensure security and consistency.

//Code:
//csharp

//public sealed class PaymentProcessor
//{
//    public bool ProcessPayment(decimal amount, string cardNumber)
//    {
//        // Simulate payment processing
//        return cardNumber.Length == 16 && amount > 0;
//    }
//}

//Explanation: Sealing PaymentProcessor prevents inheritance, ensuring the payment logic remains secure and unchanged.

//StringFormatter (Sealed Utility Class)
//Scenario: A StringFormatter class provides utility methods for formatting strings (e.g., title case, trimming).

//Why Sealed?: The formatting logic is fixed and optimized, and inheritance isn’t needed.

//Code:
//csharp

//public sealed class StringFormatter
//{
//    public string ToTitleCase(string input)
//    {
//        if (string.IsNullOrEmpty(input)) return input;
//        return char.ToUpper(input[0]) + input.Substring(1).ToLower();
//    }
//}

//Explanation: StringFormatter is sealed to prevent unnecessary extensions, ensuring its methods remain consistent and optimized.

//Summary
//Private Class: Used for encapsulation within a parent class, hiding implementation details. Ideal for nested classes that are only relevant to the enclosing type (e.g., OrderItem in Order).

//Sealed Class: Used to prevent inheritance, locking a class’s behavior. Ideal for utility classes, singletons, or critical logic that shouldn’t be extended (e.g., ConfigurationManager).

//Real-Life Usage: Private classes are common in systems requiring strong encapsulation (e.g., order processing, logging), while sealed classes are used for fixed, reusable, or sensitive components (e.g., utilities, singletons).

//If you need further clarification, more examples, or a specific scenario implemented, let me know!



//"""