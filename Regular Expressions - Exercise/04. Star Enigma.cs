using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedPlanets = new List<string>(); // атакуваните планети
            List<string> destroyedPlanets = new List<string>(); // разрушените планети

            string pattern = @"\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*?\:\d+[^\@\-\!\:\>]*?\!(?<attackType>A|D)\![^\@\-\!\:\>]*?\-\>\d+";
            Regex regex = new Regex(pattern);

            int n = int.Parse(Console.ReadLine()); // брой съобщения,които трябва да декриптираме
            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine(); // криптираното съобщение
                string decryptedMessage = DecryptMessage(encryptedMessage);

                Match match = regex.Match(decryptedMessage);
                if (match.Success)
                {
                    string planetName = match.Groups["planet"].Value; // името на планетата
                    string attackType = match.Groups["attackType"].Value; // типа на атаката

                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else if (attackType == "D")
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            PrintPlanets(attackedPlanets, "Attacked");
            PrintPlanets(destroyedPlanets, "Destroyed");
        }

        static string DecryptMessage(string encryptedMessage)
        {
            //We need to be fast!!!
            StringBuilder decryptedMessage = new StringBuilder(); // тук събираме символите на декриптираното съобщение
            int decryptionStep = GetDecryptionStep(encryptedMessage);

            foreach (char oldCh in encryptedMessage) // за всеки стар символ от съобщението
            {
                decryptedMessage.Append((char)(oldCh - decryptionStep)); // от ASCCI ст-та вадим броя символи и добавяме в StringBuilder
            }

            return decryptedMessage.ToString();
        }

        static int GetDecryptionStep(string encryptedMessage) // получава криптираното съобщение и връща стъпката с която трябва да се декриптира
        {
            int decryptionStep = 0;
            foreach (char ch in encryptedMessage.ToLower()) // за всеки символ от криптираното съобщение проверяваме дали символа е
            {
                if (ch == 's' || ch == 't' || ch == 'a' || ch == 'r') // един от изброените
                {
                    decryptionStep++; // брой символи от изброените
                }
            }

            return decryptionStep;
        }

        static void PrintPlanets(List<string> planets, string attackType)
        {
            Console.WriteLine($"{attackType} planets: {planets.Count}");
            foreach (string planetName in planets.OrderBy(p => p)) 
            {
                Console.WriteLine($"-> {planetName}");
            }
        }
    }
}
