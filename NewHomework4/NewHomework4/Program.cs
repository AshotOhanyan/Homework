using System;

namespace NewHomework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter the first integer:");
            Console.ForegroundColor = ConsoleColor.Red;
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter the second integer:");
            Console.ForegroundColor = ConsoleColor.Red;
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nChoose one of the options:");
            Console.Write("\n1-Addition.");
            Console.Write("\n2-Subtraction.");
            Console.Write("\n3-Multiplication.");
            Console.Write("\n4-Division.");
            Console.Write("\n5-Exit.");
            Console.Write("\nInput your choice:");
            Console.ForegroundColor = ConsoleColor.Red;
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Blue;

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"The addition is:");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(num1 + num2);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 2:
                    Console.WriteLine($"The subtraction is:");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(num1 - num2);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 3:
                    Console.WriteLine($"The multiplication is:");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(num1 * num2);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 4:
                    Console.WriteLine($"The division is:");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(num1 / num2);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                default:
                    break;
            }
        }
    }
}
