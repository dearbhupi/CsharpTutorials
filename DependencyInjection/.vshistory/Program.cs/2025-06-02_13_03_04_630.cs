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
            Account _account = new Account(cs); // we need a paramter constrocutor

            _account.PrintAccount();

            IAccount sa = new SavingAccount();
            Account _account2 = new Account(sa); // we need a paramter constrocutor

            _account2.PrintAccount();
        }


    }



}