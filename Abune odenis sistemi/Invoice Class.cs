using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abune_odenis_sistemi
{
    internal class Invoice_Class
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public double TotalAmount { get; set; }
        public DateTime InvoiceDate { get; set; }

        public void ShowInvoice()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("         FAKTURA (INVOICE)           ");
            Console.WriteLine("=====================================");
            Console.WriteLine("Invoice melumatları:");
            Console.WriteLine($"Id              : {Id}");
            Console.WriteLine($"Invoice nomresi : {InvoiceNumber}");
            Console.WriteLine($"Umumi mebleğ    : {TotalAmount} AZN");
            Console.WriteLine($"Tarix           : {InvoiceDate.ToString("dd.MM.yyyy HH:mm")}");
            Console.WriteLine("=====================================");
        }
    }
}
