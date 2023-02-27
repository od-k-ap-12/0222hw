using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0223hw
{
    class ATM : ITransactions, IMoney, IGetCheque
    {
        public string location { get; set; }
        public ATM(string _location)
        {
            location = _location;
        }

        public void SendMoney(Customer c1, Customer c2)
        {
            Console.WriteLine("Enter PIN:");
            if (c1.pin == Console.ReadLine())
            {
                Console.WriteLine("Enter amount of money to send: ");
                int money = Convert.ToInt32(Console.ReadLine());
                if (c1.balance - money < 0)
                {
                    throw new Exception("Not enough money to take");
                }
                c1.balance = -money;
                c2.balance += money;
                Console.WriteLine("Transaction was successfull");
            }
            else
            {
                Console.WriteLine("Invalid PIN");
            }
        }

        public void Withdraw(Customer c)
        {
            Console.WriteLine("Enter PIN:");
            if (c.pin == Console.ReadLine())
            {
                Console.WriteLine("Enter amount of money to withdraw: ");
                int money = Convert.ToInt32(Console.ReadLine());
                if (c.balance - money < 0)
                {
                    throw new Exception("Not enough money to take");
                }
                else
                {
                    c.balance = -money;
                }
            }
            else
            {
                Console.WriteLine("Invalid PIN");
            }
        }
        public void Add(Customer c)
        {
            Console.WriteLine("Enter PIN:");
            if (c.pin == Console.ReadLine())
            {
                Console.WriteLine("Enter amount of money to add: ");
                c.balance = +Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Invalid PIN");
            }
        }
        public void ReceiveCheque()
        {
            Console.WriteLine("1.Receive the cheque by email \n2.By SMS \n3.Print it");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    EmailCheque();
                    break;
                case 2:
                    SMSCheque();
                    break;
                case 3:
                    PrintCheque();
                    break;
                default:
                    break;
            }
        }
        public void PrintCheque()
        {
            Console.WriteLine("Cheque Print");
        }

        public void EmailCheque()
        {
            Console.WriteLine("Enter your email: ");
            Console.WriteLine("Your cheque has been sent to " + Console.Read());
        }

        public void SMSCheque()
        {
            Console.WriteLine("Your cheque has been sent");
        }
    }
}

