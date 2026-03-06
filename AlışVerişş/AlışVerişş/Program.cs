using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("Laptop", 15000);
            Product p2 = new Product("Mouse", 2500);
            Product p3 = new Product("Klavye", 4000);

            Cart cart = new Cart();

            Console.WriteLine("Ürünler : ");
            Console.WriteLine("1- Laptop (15.000 TL)");
            Console.WriteLine("2- Mouse (2.500 Tl)");
            Console.WriteLine("3- Klavye (4.000 Tl)");
            Console.WriteLine();
            Console.Write("Seçmek İstediğiniz Ürün Numarası Giriniz : ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    cart.AddProduct(p1);
                    break;
                case 2:
                    cart.AddProduct(p2);
                    break;
                case 3:
                    cart.AddProduct(p3);
                    break;
                default:
                    Console.WriteLine("Geçersiz Seçim!!!");
                    return;
            }
            decimal total = cart.GetTotalPrice();
            Console.WriteLine($"Toplam Sepet Tutarı : {total} TL");

            Console.WriteLine("Ödeme Yöntemi Seçiniz : 1- Kredi Kartı / 2- Nakit");
            int PaymentChoice = int.Parse(Console.ReadLine());

            IPayment payment;

            if (PaymentChoice == 1)
                payment = new CrediCardPayments();

            else 
                payment = new CashPayments();

            payment.Pay(total);

            Console.WriteLine("Alışveriş Tamamlandı...");

            Console.ReadKey();


        }
    }
}
