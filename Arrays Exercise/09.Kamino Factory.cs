using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] bestSequence = new int[n];

            int bestCount = 1;
            int bestStartIndex = 0;
            int bestSequenceSum = 0;
            int bestSequenceIndex = 0;

            int sequenceCounter = 0; // брои коя подред редица сме взели

            string command;
            while ((command = Console.ReadLine()) != "Clone them!")
            {
                int[] currSequence = command
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                sequenceCounter++;

                int currCount = 1;
                int bestCurrCount = 1;
                int startCurrIndex = 0;
                int currSequenceSum = 0;

                for (int i = 0; i < currSequence.Length - 1; i++)  // обхождаме масива от първия до предпоследния елемент, за да не изслезенм от него
                {
                    if (currSequence[i] == currSequence[i + 1])
                    {
                        currCount++;
                    }
                    else
                    {
                        currCount = 1;
                    }
                    if (currCount > bestCurrCount)
                    {
                        bestCurrCount = currCount;
                        startCurrIndex = i;
                    }
                    currSequenceSum += currSequence[i];
                }
                currSequenceSum += currSequence[currSequence.Length - 1]; // за да добавим и последния елемент, тъй като в цикъла не е включен

                if (bestCurrCount > bestCount)
                {
                    bestCount = bestCurrCount;
                    bestStartIndex = startCurrIndex;
                    bestSequenceSum = currSequenceSum;
                    bestSequenceIndex = sequenceCounter;
                    bestSequence = currSequence.ToArray();
                }
                else if (bestCurrCount == bestCount) // ако са равни
                {
                    if (startCurrIndex < bestStartIndex) // да вземем най-вляво
                    {
                        bestCount = bestCurrCount;
                        bestStartIndex = startCurrIndex;
                        bestSequenceSum = currSequenceSum;
                        bestSequenceIndex = sequenceCounter;
                        bestSequence = currSequence.ToArray();
                    }
                    else if (startCurrIndex == bestStartIndex)
                    {
                        if (currSequenceSum > bestSequenceSum)
                        {
                            bestCount = bestCurrCount;
                            bestStartIndex = startCurrIndex;
                            bestSequenceSum = currSequenceSum;
                            bestSequenceIndex = sequenceCounter;
                            bestSequence = currSequence.ToArray();
                        }
                    }

                }

            }
            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(" ", bestSequence));
        }
    }
}
