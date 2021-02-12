using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"If you want to calculate the sum of numbers from one to {num}, enter 1.");
            Console.WriteLine($"And if you want to calculate the multiplication of numbers from one to {num}, enter 2");
            int choice = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            int mult = 1;
            if (choice == 1)
            {
                sum = ((1 + num) * num) / 2;
                Console.WriteLine(sum);
            }
            else
            {
                for (int i = 2; i <= num; i++)
                {
                    mult = mult * i;
                }
                Console.WriteLine(mult);
            }
        }
    }
}
