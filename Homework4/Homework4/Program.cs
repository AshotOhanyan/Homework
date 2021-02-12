using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine(Func());
        }
        public static string Func()
        {
            string text = Console.ReadLine();
            string[] characters = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            int charLength = characters.Length;

            for (int i = 0; i < charLength - 1; i++)
            {
                if(characters[i].Length == 1 && characters[i].EndsWith('.'))
                {
                    continue;
                }
                if (characters[i].Length > 1)
                {
                    sb = sb.Append(characters[i].Substring(1));
                }
                sb = sb.Append(Char.ToLower(characters[i][0]));
                sb = sb.Append("ey ");
            }

            string lastSymbol = "";
            string last = characters[charLength - 1];
            if(last.Length == 1 && last[0] == '.')
            {
                sb.Append('.');
                return sb.ToString();
            }
            if (last.EndsWith('.') || last.EndsWith('?'))
            {

                lastSymbol = last[last.Length - 1] + "";
                last = last.Substring(0, last.Length - 1);
            }

            if (last.Length > 1)
            {
                sb = sb.Append(last.Substring(1));
            }
            sb.Append(Char.ToLower(last[0])).Append("ey").Append(lastSymbol);
            return sb.ToString();
        }
    }
}
