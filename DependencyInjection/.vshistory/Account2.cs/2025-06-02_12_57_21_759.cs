using System;
using System.Security.Cryptography.X509Certificates;


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

    class Account
    {
        private IAccount ia;

        //constructor for Interface IAccount
        public Account(IAccount ia)
        {

            this.ia = ia;
        }
    }
}
