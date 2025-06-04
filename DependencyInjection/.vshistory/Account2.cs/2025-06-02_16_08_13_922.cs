using System;




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

    class BankAccount
    {
        private IAccount ia;

        //constructor for Interface IAccount having paramter
        public BankAccount(IAccount ia)
        {

            this.ia = ia;
        }

        public void PrintAccount() { 

            ia.display();
        
        }
    }
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
