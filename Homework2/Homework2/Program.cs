using System;

namespace Homework2
{
    class Program
    {
        public static void leapYears()
        {
            int year = 2020;
            for (int i = 0; 20 > i; i++)
            {
                Console.WriteLine(year);
                year = year - 4;
            }
        }
        static void Main(string[] args)
        {
            leapYears();
        }
        
    }
    
}
