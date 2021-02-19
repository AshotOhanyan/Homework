using System;

namespace NewHomework3
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is for go to.
            exepction:
            Console.WriteLine("Please enter your grade.");
            int num = Convert.ToInt32(Console.ReadLine());
            string[] grades = new string[] { "F", "D", "C", "B", "A", "A+" };
            if(num > 10)
            {
                Console.WriteLine("Check again!");
                Console.WriteLine("Your grade should be between zero and ten!");
                goto exepction;
            }
                switch (num)
                {
                    case 5:
                        Console.WriteLine(grades[1]);
                        break;
                    case 6:
                        Console.WriteLine(grades[2]);
                        break;
                    case 7:
                        Console.WriteLine(grades[3]);
                        break;
                    case 8:
                        Console.WriteLine(grades[3]);
                        break;
                    case 9:
                        Console.WriteLine(grades[4]);
                        break;
                    case 10:
                        Console.WriteLine(grades[5]);
                        break;
                    default:
                        Console.WriteLine(grades[0]);
                        break;
                }
            

            
        }
    }
}
