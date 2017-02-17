using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseletOnBankAccounts
{

    abstract class Account
    {
        private static long AccountNumber = 100000000000;
        private string UserName;
        private int Balance;

        public string UserName1
        {
            get
            {
                return UserName;
            }

            set
            {
                UserName = value;
            }
        }

        public static long AccountNumber1
        {
            get
            {
                return AccountNumber;
            }
        }

        public int Balance1
        {
            get
            {
                return Balance;
            }

            set
            {   if(value > 1000)
                Balance = value;
                else
                    Console.WriteLine("Minimum Balance must be greater than 1000");
                Environment.Exit(0);
            }
        }

        public void OpenAccount()
        {
            Console.WriteLine("Enter the User Name: ");
            UserName1=Console.ReadLine();
            Console.WriteLine("Enter your Balance: ");
            Balance1 = Convert.ToInt32(Console.ReadLine());
            AccountNumber++;
            Console.WriteLine("Account Opened!");
        }

        public void EditAccount()
        {

        }

    }














    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
