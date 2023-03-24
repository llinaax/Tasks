using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class BeginTerms
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        

        public BeginTerms CreateDataStart()
        {
            Console.WriteLine("Enter the day of starting project:");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the month of starting project(mm):");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year of starting project:");
            int year = Convert.ToInt32(Console.ReadLine());

            return new BeginTerms()
            {
                Day = day,
                Month = month,
                Year = year
            };
        }
       
    }
}
