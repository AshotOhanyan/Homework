using System;

namespace Rolling_a_Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            dice.Trigger += DisplayMessage;
            dice.Roll(15);
        }
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
