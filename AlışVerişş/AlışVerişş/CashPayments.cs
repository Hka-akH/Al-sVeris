using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CashPayments : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Nakit Olarak {amount} Tl Ödeme Yapıldı...");
        }

    }
}
