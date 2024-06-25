using System;
using System.Linq;
using System.Collections.Generic;

namespace P08.AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split()
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] cmdArgs = command
                    .Split();
                string cmdType = cmdArgs[0];

                if (cmdType == "merge")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    FixInvalidIndexes(words, ref startIndex, ref endIndex);
                    MergeWords(words, startIndex, endIndex);
                }
                else if (cmdType == "divide")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int partitions = int.Parse(cmdArgs[2]);

                    //abcde -> ab, bc, e (Wrong, we want the last one to be the longest)
                    //abcde -> a, b, cde 5 : 3 = 1
                    //abcdef -> ab, cd, ef
                    string word = words[index]; // вземаме думата от индекса на който се намира
                    List<string> partitionsList = DivideWord(word, partitions);

                    words.RemoveAt(index);
                    words.InsertRange(index, partitionsList);
                }
            }

            Console.WriteLine(String.Join(" ", words));
        }

        // If any of the given indexes is out of the array, you must take only the range that is inside the array and merge it.
        static void FixInvalidIndexes(List<string> words, ref int startIndex, ref int endIndex)
        {
            if (startIndex < 0) 
            {
                //First possible
                startIndex = 0;
            }

            if (startIndex >= words.Count)
            {
                startIndex = words.Count - 1;
            }

            if (endIndex <= 0)
            {
                endIndex = 0;
            }

            if (endIndex >= words.Count)
            {
                //Last possible
                endIndex = words.Count - 1;
            }
        }

        static void MergeWords(List<string> words, int startIndex, int endIndex)
        {
            string mergedText = string.Empty; // създаваме празен стринг
            for (int i = startIndex; i <= endIndex; i++)
            {
                string currWord = words[startIndex]; // вземаме елемента на текущия индекс
                mergedText += currWord; // всички думи, които вземаме ще влизат в празния стринг
                words.RemoveAt(startIndex); // всяка дума, която вземем, трябва да я премахнем
                // индексите се променят, когато изтриваме елемент, затова не трябва да се използва i, а startIndex
            }

            words.Insert(startIndex, mergedText); // към нулевия индекс добавяме мърджнатия текст
        }

        static List<string> DivideWord(string word, int partitions)
        {
            int substringsLength = word.Length / partitions; // дължината на думата разделена на броя пропорции, дава на колко части ще делим думата
            int lastSubstringLength = substringsLength + word.Length % partitions;
            //int lastSubstringLength = word.Length - ((partitions - 1) * substringsLength);

            List<string> partitionsList = new List<string>();
            //All without the last one
            for (int i = 0; i < partitions; i++)
            {
                int desiredLength = substringsLength; // исканата дължина, първоначално ще бъде равна на първоначалната дължина
                if (i == partitions - 1) // когато стигнем до последната част
                {
                    desiredLength = lastSubstringLength;
                }

                char[] newPartitionArr = word
                    .Skip(i * substringsLength) //пропуска толкова на брой символи, колкото сме задали
                    .Take(desiredLength) // взема толкова на брой символи, колкото сме задали
                    .ToArray();
                string newPartition = String.Join("", newPartitionArr);
                partitionsList.Add(newPartition);
            }

            return partitionsList;
        }
    }
}
