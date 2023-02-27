using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0223hw
{
    interface ITransactions
    {
        void SendMoney(Customer c1, Customer c2);
    }
}
