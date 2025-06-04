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
            cs.display();

            IAccount sa = new SavingAccount();
            sa.display();

        }


    }



}