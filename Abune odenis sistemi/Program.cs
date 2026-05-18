using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abune_odenis_sistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            for (int i = 0; i < 3; i++)
            {
                User u1 = new User();
                Console.WriteLine(" Adinizi daxil edin:");
                u1.name = Console.ReadLine();
                Console.WriteLine("Soyadinizi daxil edin:");
                u1.surname = Console.ReadLine();
                Console.WriteLine("Emailinizi daxil edin:");
                u1.email = Console.ReadLine();
                Console.WriteLine("Telefon nomrenizi daxil edin:");
                u1.phone = Console.ReadLine();
                Console.WriteLine("Yashinizi daxil edin:");
                u1.age = int.Parse(Console.ReadLine());
                if (u1.age >= 18)
                { 
                Console.WriteLine("Parolunuzu daxil edin:");
                u1.password = Console.ReadLine();
                
                users.Add(u1);

                Console.WriteLine("User ugurla elave edildi");
                Console.WriteLine(u1.name + " " + u1.surname);
                }
                else
                {
                    Console.WriteLine("Abune olmaq ucun yasin 18 ve ya daha boyuk olmalidir.");
                }
                Console.WriteLine("\n===== LISTDEKI USERLER =====");

                foreach (User user in users)
                {
                    Console.WriteLine("Ad: " + user.name);
                    Console.WriteLine("Soyad: " + user.surname);
                    Console.WriteLine("Email: " + user.email);
                    Console.WriteLine("Telefon: " + user.phone);
                    Console.WriteLine("Yas: " + user.age);

                    Console.WriteLine("--------------------------");
                }
            }
            Admin admin1 = new Admin();
            admin1.Id = 1;
            admin1.Username = "admin";
            admin1.Password = "12345";

            admin1.ShowInfo();

            Subscription s1 = new Subscription();

            s1.Id = 1;
            s1.PlanName = "Premium";
            s1.Price = 10;
            s1.Month = 1;
            s1.IsActive = true;

            s1.ShowSubscription();


            Plan p1 = new Plan();

            p1.Id = 1;
            p1.PlanName = "Premium";
            p1.MonthlyPrice = 10;
            p1.Description = "Reklamsiz ve tam access";

            p1.ShowPlan();

            Payment pay1 = new Payment();

            pay1.Id = 1;
            pay1.Amount = 10;
            pay1.PaymentMethod = "Card";
            pay1.PaymentStatus = true;
            pay1.PaymentDate = DateTime.Now;

            pay1.ShowPayment();

            Invoice_Class i1 = new Invoice_Class();

            i1.Id = 1;
            i1.InvoiceNumber = "INV-1001";
            i1.TotalAmount = 10;
            i1.InvoiceDate = DateTime.Now;

            i1.ShowInvoice();

        }
    }
 
}
 
