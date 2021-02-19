using System;
using System.Text;

namespace NewHomework1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            string replacement = "%20";
            for(int i = 0; i < text.Length; i++)
            {
                if(text[i] != ' ')
                {
                    result.Append(text[i]);
                }
                else{
                    result.Append(replacement);
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}
