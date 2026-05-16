using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abune_odenis_sistemi
{
     class User
    {
        public String name { get; set; }
        public String surname { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
        public static String nationality { get; set; }

        public void getData()
        {
            Console.WriteLine("Istifadeci melumatlari");
            Console.WriteLine("Ad: " + name);
            Console.WriteLine("Soyad: " + surname);
            Console.WriteLine("Yas: " + age);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Telefon: " + phone);
            Console.WriteLine("Parol: " + password);
            Console.WriteLine("Milliyet: " + nationality);
        }
    }

}
