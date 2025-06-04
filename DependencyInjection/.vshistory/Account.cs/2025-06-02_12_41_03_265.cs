using System;


namespace DependencyInjection
{
    public class Account
    {
        public void display()
        {
            Console.WriteLine("Main account branch");
        }
    }

    public class CurrentAccount
    {
        public void display()
        {
            Console.WriteLine("Current account branch");
        }

    }

    public class SavingAccount
    {
        public void display()
        {
            Console.WriteLine("Saving account branch");
        }
    }
}
