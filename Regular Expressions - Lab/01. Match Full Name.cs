using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b"; // \b (boundaries - граница) - това което търсим трябва преди него да има празно място (не трябва да има някаква дръга дума и др.); казваме му че искаме думата да започва по този начин 
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(input);

            foreach (Match item in matchCollection)
            {
                Console.Write(item.Value + " "); // принтира само успешните мачвания
            }
        }
    }
}
