using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.Games
{
    public static class AudioShuffle
    {
        public static void GenerateShuffleNumbersWithTempArray(int max)
        {
            int[] values = new int[max];
            bool[] valueExists = new bool[max];

            int value = 0;

            for (int i = 0; i < max; i++)
            {
                value = generateRandomNumber() % max;

                if (valueExists[value])
                    i--;
                else
                {
                    values[i] = value;
                    valueExists[value] = true;
                }
            }

            // print all shuffle values
            printAllShuffleValues(values);
        }

        static int generateRandomNumber()
        {
            System.Random random = new System.Random();
            return random.Next();
        }

        static void printAllShuffleValues(int[] array)
        {
            // Print all shuffle values
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
