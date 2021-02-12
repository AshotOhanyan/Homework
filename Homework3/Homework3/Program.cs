using System;
using System.Text;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] characters = text.Split(' ');
            int maxIndex = 0;
            string maxString = "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i].Length > maxIndex)
                {
                    maxIndex = characters[i].Length;
                    maxString = characters[i];
                }
            }
            
            for (int n = 0; n <= maxIndex + 3; n++)
            {
                sb.Append("*");
            }

            for (int k = 0; k < characters.Length; k++)
            {

                sb.Append(Environment.NewLine);
                sb.Append($"* {characters[k]}");
                sb.Append(' ', maxString.Length - characters[k].Length + 1);
                sb.Append("*");                
            }
            sb.Append(Environment.NewLine);
            for (int n = 0; n <= maxIndex + 3; n++)
            {
                sb.Append("*");
            }


            Console.WriteLine(sb.ToString());
        }
    }
}
