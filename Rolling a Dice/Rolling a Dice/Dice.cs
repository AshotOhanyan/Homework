using System;
using System.Collections.Generic;
using System.Text;

namespace Rolling_a_Dice
{
    class Dice
    {
        public delegate void ForEvent(string message);
        public event ForEvent Trigger;
        
        public void Roll(int instanceForRolls)
        {
            int[] rollNums = new int[instanceForRolls];
            for (int i = 0; i < instanceForRolls; i++)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 6);
                rollNums[i] = randomNumber;
            }

            int sumOfFives = 0;
            for (int i = 1; i < rollNums.Length; i++)
            {
                if (rollNums[i] == 5 && rollNums[i - 1] == 5)
                {
                    sumOfFives++;
                }
            }
            Trigger?.Invoke($"Two fives in a row appeared {sumOfFives} time.");

            int tossSewuencesSum = 0;

            for(int i = 0; i < rollNums.Length; i++)
            {
                if(i + 4 >= rollNums.Length)
                {
                    break;
                }
                int sum = rollNums[i] + rollNums[i + 1] + rollNums[i + 2] + rollNums[i + 3] + rollNums[i + 4];
                if(sum >= 21)
                {
                    tossSewuencesSum++;
                }
            }
            Trigger?.Invoke($"There are {tossSewuencesSum} toss sequences with an overall sum greaterthan or equal 21.");
        }       
    }
}
