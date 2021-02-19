using System;
using System.Text;

namespace NewHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            int sum = 1;

            for(int i = 0;i < text.Length; i++)
            {
                if (i + 1 >= text.Length)
                {
                    result.Append(text[i]).Append(sum);
                }
                else
                {
                    if (text[i] == text[i + 1])
                    {
                        sum++;
                    }
                    else
                    {
                        result.Append(text[i]).Append(sum);
                        sum = 1;
                    }
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}
