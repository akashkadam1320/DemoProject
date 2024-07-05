using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public class person1
    { public string accountHolderName;
        public string accountNumber;
        public decimal balance;


        public string GetaccountHolderName()
        {
            return accountHolderName; 
        }
        public void SetaccountHolderName(string newaccountHolderName)
        { 
            accountHolderName = newaccountHolderName;
        }
        public string GetaccountNumber()
        {
            return accountNumber;
        }
        public void SetaccountNumber(string newaccountNumber)
        {
            accountNumber = newaccountNumber;
            }
            public decimal Getbalance()
        {
            return balance;
        }
        public void Setbalance(decimal newbalance)
        {
            balance = newbalance;
        }
    }
     class BankAccount
    {
        static void Main()
        {
            person1 person1 = new person1();
            person1.SetaccountHolderName("akash");
            person1.SetaccountNumber("SIB22663456");
            person1.Setbalance(5000);

            Console.WriteLine("accountHolderName=" + person1.GetaccountHolderName());
            
            Console.WriteLine("accountNumber="+person1.GetaccountNumber());
            Console.WriteLine("balence=" + person1.Getbalance());
        }
    }
}
