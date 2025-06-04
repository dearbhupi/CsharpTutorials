using System;


namespace DependencyInjection
{


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
