using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArg = command // получаваме командата
                    .Split();
                string cmdType = cmdArg[0];// типа на командата;на коя позиция от масива стои името на командата

                if (cmdType == "exchange") // ако командата е тази, трябва да прочетем индекс
                {
                    int index = int.Parse(cmdArg[1]);
                    if (index < 0 || index >= arr.Length) // проверяваме дали индекса е извън границите на масива
                    {
                        Console.WriteLine("Invalid index");
                        continue; // продължаваме с нова команда, ако е невалиден
                    }
                    arr = ExchangeArray(arr, index);// масивът се презаписва и се записва резултата от exchangeArray
                }
                else if (cmdType == "max" || cmdType == "min")
                {
                    string evenOrOddArg = cmdArg[1];
                    int indexOfEl;
                    if (cmdType == "max")
                    {
                        indexOfEl = IndexOfMaxEvenOrOddElement(arr, evenOrOddArg);
                    }
                    else
                    {
                        indexOfEl = IndexOfMinEvenOrOddElement(arr, evenOrOddArg);
                    }

                    if (indexOfEl == -1)
                    {
                        Console.WriteLine($"No matches");
                        continue;
                    }

                    Console.WriteLine(indexOfEl);
                }
                else if (cmdType == "first" || cmdType == "last")
                {
                    int count = int.Parse(cmdArg[1]);
                    string evenOrOddArg = cmdArg[2];

                    if (count > arr.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    int[] elements; 
                    if (cmdType == "first")
                    {
                        elements = FirstEvenOrOddElements(arr, count, evenOrOddArg);
                    }
                    else
                    {
                        elements = LaststEvenOrOddElements(arr, count, evenOrOddArg);
                    }
                    PrintArray(elements);
                }
            }
            PrintArray(arr);
        }
        //Метод, който ще връща променения масив
        static int[] ExchangeArray(int[] originalArr, int index) // параметрите са ориг. масив и индекса
        {
            int[] modifiedArr = new int[originalArr.Length]; // създаваме модифициран масив, със същата дължина като оригиналния
            int modifiedArrIndex = 0; // това е отделен брояч само за модиф. масив, показва докъде сме стигнали в масива

            for (int i = index +1; i < originalArr.Length; i++) // премества числата след зададения индекс отпред в масива
            {
                modifiedArr[modifiedArrIndex] = originalArr[i];
                modifiedArrIndex++;
            }

            for (int i = 0; i <= index; i++) // премества числата преди зададения индекс в края  на масива
            {
                modifiedArr[modifiedArrIndex] = originalArr[i];
                modifiedArrIndex++;
            }
            return modifiedArr;
        }

        // Метод, който ще връща индекса на макс. четен или нечетен елемент
        static int IndexOfMaxEvenOrOddElement(int[] arr, string evenOrOddArg)
        {
            int maxIndex = -1; // избираме дефолтна стойност -1, което ще означава,че не сме намерили макс. елемент
            int currMax = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                int currNum = arr[i];
                if (evenOrOddArg == "even" && currNum % 2 == 0)
                {
                    if (currNum >= currMax) // ако се изисква най-дясното число ">=", ако ни трябва най-лявото само ">"
                    {
                        currMax = currNum;
                        maxIndex = i;
                    }
                }
                if (evenOrOddArg == "odd" && currNum % 2 != 0)
                {
                    if (currNum >= currMax) 
                    {
                        currMax = currNum;
                        maxIndex = i;
                    }
                }
            }
            return maxIndex;
        }

        static int IndexOfMinEvenOrOddElement(int[] arr, string evenOrOddArg)
        {
            int minIndex = -1; 
            int currMin = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                int currNum = arr[i];
                if (evenOrOddArg == "even" && currNum % 2 == 0)
                {
                    if (currNum <= currMin) // <= , защото търсим най-малкото число отдясно
                    {
                        currMin = currNum;
                        minIndex = i;
                    }
                }
                if (evenOrOddArg == "odd" && currNum % 2 != 0)
                {
                    if (currNum <= currMin)
                    {
                        currMin = currNum;
                        minIndex = i;
                    }
                }
            }
            return minIndex;
        }

        // Метод за търсене на първите елементи
        static int[] FirstEvenOrOddElements(int[] arr, int count, string evenOrOddArg)
        {
            int[] firstElArr = new int[count];
            int firstElArrIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (firstElArrIndex >= count) // ако в даден момент вземем повече елементи, отколото е броя
                {
                    break; // прекъсваме цикъла
                }
                
                int currNum = arr[i];
                if(evenOrOddArg == "even" && currNum%2 == 0)
                {
                    firstElArr[firstElArrIndex] = currNum; // в противен случай си вземаме още елементи
                    firstElArrIndex++;
                }
                else if (evenOrOddArg == "odd" && currNum % 2 != 0)
                {
                    firstElArr[firstElArrIndex] = currNum; 
                    firstElArrIndex++;
                }
            }

            firstElArr = ResizeArray(firstElArr, firstElArrIndex);
            return firstElArr;
        }

        // Метод за преоразмеряване на масива
        static int[] ResizeArray(int[] originalArr, int count)
        {
            int[] modifiedArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                modifiedArray[i] = originalArr[i];
            }
            return modifiedArray;
        }

        // Метод за принтиране
        static void PrintArray(int[] arr)
        {
            Console.WriteLine($"[{String.Join(", ", arr)}]");
        }

        // Метод за търсене на първите елементи
        static int[] LaststEvenOrOddElements(int[] arr, int count, string evenOrOddArg)
        {
            int[] firstElArr = new int[count];
            int firstElArrIndex = 0;
            for (int i = arr.Length-1; i >= 0; i--)
            {
                if (firstElArrIndex >= count) // ако в даден момент вземем повече елементи, отколото е броя
                {
                    break; // прекъсваме цикъла
                }

                int currNum = arr[i];
                if (evenOrOddArg == "even" && currNum % 2 == 0)
                {
                    firstElArr[firstElArrIndex] = currNum; // в противен случай си вземаме още елементи
                    firstElArrIndex++;
                }
                else if (evenOrOddArg == "odd" && currNum % 2 != 0)
                {
                    firstElArr[firstElArrIndex] = currNum;
                    firstElArrIndex++;
                }
            }

            firstElArr = ResizeArray(firstElArr, firstElArrIndex);
            firstElArr = ReverseArray(firstElArr);
            return firstElArr;
        }

        // Метод за обръщане на масива
        static int[] ReverseArray(int[] originalArr)
        {
            int[] reversed = new int[originalArr.Length];
            for (int i = originalArr.Length - 1; i >= 0; i--)
            {
                reversed[reversed.Length - i -1] = originalArr[i];
            }
            return reversed;    
        }
    }
}
