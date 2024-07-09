using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("\\"); // => [C:, Internal, training-internal, Template.pptx]
            string file = input[input.Length - 1]; // вземаме последния индекс => Template.pptx
            string[] splitLastWord = file.Split('.'); // => създаваме нов масив и го сплитваме [Template, pptx]
            string fileName = splitLastWord[0];
            string extension = splitLastWord[1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
