using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abune_odenis_sistemi
{
    internal class Payment
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public string PaymentMethod { get; set; }
        public bool PaymentStatus { get; set; }
        public DateTime PaymentDate { get; set; }

        public void ShowPayment()
        {
            Console.WriteLine("Payment melumatlari");
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Mebleg: " + Amount);
            Console.WriteLine("Odenis usulu: " + PaymentMethod);
            Console.WriteLine("Status: " + PaymentStatus);
            Console.WriteLine("Tarix: " + PaymentDate);
        }
    }
}
