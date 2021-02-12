using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any integer:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("For computing sum enter 1");
            Console.WriteLine("For computing multiplication enter 2");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int mult = 1;

            if (n == 1)
            {
                sum = (1 + num) * num / 2;

                Console.WriteLine($"Sum is : {sum}");
            }
            else if (n == 2)
            {
                for (int i = 2; i <= num; i++)
                {
                    mult = mult * i;
                }
                Console.WriteLine($"Multiplication is : {mult}");
            }
            else
            {
                Console.WriteLine("Please enter a correct number!");
            }
        }
    }
}
