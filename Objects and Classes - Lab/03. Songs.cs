using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // брой редове

            // всеки път създаваме обекти измежду които всеки път ще търсим 
            List<Song> songs = new List<Song>(); // затова създаваме лист от песните

            for (int i = 0; i < n; i++)
            {
                string[] currentInput = Console.ReadLine().Split('_');

                string typeList = currentInput[0];
                string name = currentInput[1];
                string time = currentInput[2];

                Song song = new Song(typeList, name, time); // създаваме обекта
                songs.Add(song);
            }

            string list = Console.ReadLine(); // получаваме командите all, TypeList

            for (int i = 0; i < songs.Count; i++) // обхождаме листа
            {
                Song currentSong = songs[i];  // вземаме настоящата песен

                if (list == "all")
                {
                    Console.WriteLine(currentSong.Name);
                }
                else if (list == currentSong.TypeList)
                {
                    Console.WriteLine(currentSong.Name);
                }
            }
        }
    }

    public class Song
    {
        public Song(string typeList, string name, string time) // това е конструктора и трябва да ни подадат тези данни
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        // това са пропъртитата; това, което ни подадат като информация отвън ще се запише във всяко едно пропърти 
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}
