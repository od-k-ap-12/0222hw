using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0223hw
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM("location");
            Customer c1 = new Customer("name1", "1111 1111 1111 1111", 5000, "456");
            Customer c2 = new Customer("name2", "1111 8111 1111 1151", 2000, "842");
            int choice;
            while (true)
            {
                Console.WriteLine("1.Send money \n2.Withdraw money \n3.Add money \n4.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        atm.SendMoney(c1, c2);
                        atm.ReceiveCheque();
                        break;
                    case 2:
                        atm.Withdraw(c1);
                        atm.ReceiveCheque();
                        break;
                    case 3:
                        atm.Add(c1);
                        atm.ReceiveCheque();
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
        }
    }
}
