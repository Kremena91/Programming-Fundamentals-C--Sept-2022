using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>(); // списък с всички създадени отбори до момента

            InitializeTeams(teams);
            JoinTeams(teams);

            PrintValidTeams(teams);
            PrintTeamsToDisband(teams);
        }

        static void InitializeTeams(List<Team> teams) // създаваме метод, който проверява съществуват ли отбора и създателя
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] teamArgs = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);

                string creator = teamArgs[0];
                string teamName = teamArgs[1];

                if (TeamExists(teams, teamName)) //Ако отбора вече съществува
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (AlreadyCreatedATeam(teams, creator)) //Ако създателя вече съществува
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else // в противен случай създаваме такъв отбор
                {
                    Team newTeam = new Team(teamName, creator); // създаваме нов отбор
                    teams.Add(newTeam);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }
        }

        static bool TeamExists(List<Team> teams, string teamName) //  Метод, който проверява дали отбора съществува
        {
            return teams.Any(t => t.Name == teamName); // Any връща true or false и казва има ли елемент от колекцията, който да отговаря на това условие
        } // името на отбора равно ли е на това име което сме получили
        // ако има такова име, това означа че този отбор вече съществува

        static bool AlreadyCreatedATeam(List<Team> teams, string creator) // Метод, който проверява дали създателя съществува
        {
            return teams.Any(t => t.Creator == creator); 
        } // създателя равен ли е на създателя, който сме получили
        // ако има такъв създател, това означа че този създател вече съществува

        static void JoinTeams(List<Team> teams) // Метод за добавяне на член към отбора
        {
            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] cmdArgs = command
                    .Split("->", StringSplitOptions.RemoveEmptyEntries);
                string user = cmdArgs[0];
                string teamName = cmdArgs[1];

                if (!TeamExists(teams, teamName)) // Ако този отбор не съществува в тези отбори
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (AlreadyAMemberOfATeam(teams, user)) // Ако вече е член на някой отбор
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else // в противен случай го добавяме в отбора
                {
                    Team teamToJoin = teams
                        .First(t => t.Name == teamName); // дай ми първи отбор, който отговаря на това условие (името на отбора да е равно на търсения отбор)
                    teamToJoin.AddMember(user);
                }
            }
        }

        static bool AlreadyAMemberOfATeam(List<Team> teams, string user) // проверка дали някой вече е член на отборa
        {
            return teams.Any(t => t.Members.Contains(user)) ||
                teams.Any(t => t.Creator == user);
            // Проверяваме има ли някой отбор на който членовете съдържат този user или в отборите има ли някой на който creator-a е равен на този user
        }

        static void PrintValidTeams(List<Team> teams)
        {
            List<Team> teamsWithMembers = teams // дай ми само тези отбори на които броя на членовете е по-голям от 0
                .Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name) // ако съвпаднат по брой, се прилага сортиране по име
                .ToList();
            foreach (Team team in teamsWithMembers) // за всеки отбор от всички отбори
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (string memberName in team.Members.OrderBy(m => m)) //  за всеки член в отбора
                {
                    Console.WriteLine($"-- {memberName}");
                }
            }
        }

        static void PrintTeamsToDisband(List<Team> teams)
        {
            List<Team> teamsToDisband = teams
                .Where(t => t.Members.Count == 0) // дай ми само тези отбори на които броя членове е равен на 0
                .OrderBy(t => t.Name)
                .ToList();
            Console.WriteLine($"Teams to disband:");
            foreach (Team disbandTeam in teamsToDisband) // за всеки отстранен отбор
            {
                Console.WriteLine($"{disbandTeam.Name}");
            }
        }
    }

    public class Team
    {
        // колекциите винаги се правят като fields
        // readonly - в самия списък можем да правим всякакви промени - Add, Remove, Insert, но не позволява да презаписваме ст-та в списъка
        private readonly List<string> members; // field, който е празен списък

        public Team(string name, string creator)
        {
            this.Name = name;
            this.Creator = creator;

            this.members = new List<string>(); // създаваме го за да не е празен списъка на field-a
        }

        public string Name { get; private set; } // име

        public string Creator { get; private set; } // създател

        //Get-only property - когато се пробва някой да го достъпи ще върне стойноста на field-a
        //To be right => IReadOnlyCollection<string>, за да e по правилна задачата с този израз трябва да се замести листа, но не сме го учили
        // направена задачата с лист, могат да ни четат и променят листа отвън, а с другата опция само да го четат
        public List<string> Members // това property винаги връща ст-та, която е във field-a и целта му е да изнесе стойоноста навън
            => this.members;

        // Метод, който добавя нов член 
        public void AddMember(string memberName)
        {
            this.members.Add(memberName);
        }
    }
}
