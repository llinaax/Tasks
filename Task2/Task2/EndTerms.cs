using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class EndTerms
    {
        public int DayEnd { get; set; }
        public int MonthEnd { get; set; }
        public int YearEnd { get; set; }
        public EndTerms CreateDataEnd()
        {
            Console.WriteLine("Enter the day of ending project:");
            int dayEnd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the month of ending project(mm):");
            int monthEnd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year of ending project:");
            int yearEnd = Convert.ToInt32(Console.ReadLine());

            return new EndTerms()
            {
                DayEnd = dayEnd,
                MonthEnd = monthEnd,
                YearEnd = yearEnd

            };
        }
    }
}
