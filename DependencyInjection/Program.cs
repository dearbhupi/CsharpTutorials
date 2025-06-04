using DependencyInjection;
using System;


namespace DependencyInjectionDemo

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Programe");

            IAccount cs = new CurrentAccount();
            BankAccount _account = new BankAccount(cs); // we need a paramter constrocutor

            _account.PrintAccount();

            IAccount sa = new SavingAccount();
            BankAccount _account2 = new BankAccount(sa); // we need a paramter constrocutor

            _account2.PrintAccount();
        }


    }



}