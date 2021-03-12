using System;
using System.Collections.Generic;

namespace OnlineAttendance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your name please.");
            Action<string> action = DisplayName;
            action(Console.ReadLine());
        }
        public static void DisplayName(string name)
        {
            List<string> bannedUsersNames = new List<string>() { "Arman", "Karen", "Arsen", "Xachik" };
            for (int i = 0; i < bannedUsersNames.Count; i++)
            {
                if (name == bannedUsersNames[i])
                {
                    Console.WriteLine("This users name is banned!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Welcome {name}");
                    break;
                }
            }

        }
    }
}
