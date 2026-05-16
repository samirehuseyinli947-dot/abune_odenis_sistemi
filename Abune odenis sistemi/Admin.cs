using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abune_odenis_sistemi
{
    internal class Admin
    {
       
            public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public void ShowInfo()
            {
                Console.WriteLine("Admin melumatları");
                Console.WriteLine("Id: " + Id);
                Console.WriteLine("Username: " + Username);
            }
    }
}
