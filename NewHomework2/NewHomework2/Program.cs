using System;

namespace NewHomework2
{
    class Program
    {
        static void Main(string[] args)
        {
            exeption:
            Console.WriteLine("Please enter month number!");
            int month = Convert.ToInt32(Console.ReadLine());
            if(month <= 0 || month > 12)
            {
                Console.WriteLine("Invalid number!");
                Console.WriteLine("There are only 12 months in a year.");
                goto exeption;
            }
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("This month has 31 days");
                    break;
                case 2:
                    Console.WriteLine("This month has 28 days");
                    break;
                default:
                    Console.WriteLine("This month has 30 days");
                    break;
            }
        }
    }
}
