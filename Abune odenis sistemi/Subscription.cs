using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abune_odenis_sistemi
{
   
    using System;

        internal class Subscription
        {
        public int Id { get; set; }
        public string PlanName { get; set; }
        public double Price { get; set; }
        public int Month { get; set; }
        public bool IsActive { get; set; }

        public void ShowSubscription()
        {
            Console.WriteLine("Subscription melumatlari");
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Plan adi: " + PlanName);
            Console.WriteLine("Qiymet: " + Price);
            Console.WriteLine("Muddet: " + Month + " ay");
            Console.WriteLine("Aktivdir: " + IsActive);
        }
        }
    }


