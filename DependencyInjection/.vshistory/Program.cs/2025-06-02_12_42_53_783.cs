using DependencyInjection;
using System;


namespace DependencyInjectionDemo

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Programe");

            Account account = new Account();
            account.display();

        }


    }



}