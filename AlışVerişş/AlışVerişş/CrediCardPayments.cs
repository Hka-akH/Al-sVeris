using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CrediCardPayments : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Kredi Kartı İle {amount} Tl İle Ödeme Yapıldı...");
        }


    }
}
