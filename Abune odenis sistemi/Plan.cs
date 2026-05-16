using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abune_odenis_sistemi
{
    internal class Plan
    {
        public int Id { get; set; }
        public string PlanName { get; set; }
        public double MonthlyPrice { get; set; }
        public string Description { get; set; }

        public void ShowPlan()
        {
            Console.WriteLine("Plan melumatlari");
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Plan adi: " + PlanName);
            Console.WriteLine("Aylıq qiymet: " + MonthlyPrice);
            Console.WriteLine("Tesvir: " + Description);
        }
    }
}
