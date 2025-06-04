using System;


// please check the Account.cs for the reference as this is the modified class
// here we are implimenting the interface

namespace DependencyInjection
{

    interface IAccount
    {
        public void display();
    }
    public class CurrentAccount : IAccount
    {
        public void display()
        {
            Console.WriteLine("Current account branch");
        }

    }

    public class SavingAccount : IAccount
    {
        public void display()
        {
            Console.WriteLine("Saving account branch");
        }
    }

    public class Account
    {
        /// <summary>
        /// the main account class is dpendepnt upon above two classes
        /// if I block the code of any one above class the program throw error 
        /// </summary>
        public void display()
        {
            CurrentAccount ca = new CurrentAccount();
            ca.display();

            SavingAccount sa = new SavingAccount();
            sa.display();

            Console.WriteLine("Main account branch");
        }
    }
}
