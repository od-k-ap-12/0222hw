using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0223hw
{
    class Customer
    {
        public string name { get; set; }
        public string cardnumber { get; set; }
        public int balance { get; set; }
        public string pin { get; set; }

        public Customer(string _name, string _cardnumber, int _balance, string _pin)
        {
            name = _name;
            cardnumber = _cardnumber;
            balance = _balance;
            pin = _pin;
        }
    }
}
