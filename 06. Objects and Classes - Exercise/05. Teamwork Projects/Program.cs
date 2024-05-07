using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());

            List<Team> teamsList = new List<Team>();

            for (int i = 0; i < teamsCount; i++)
            {
                string infoLine = Console.ReadLine();
                string[] tokens = infoLine.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string user = tokens[0];
                string teamName = tokens[1];

                Team existingTeamName = teamsList.Find(x => x.TeamName == teamName);
                Team existingTeamCreator = teamsList.Find(x => x.Creator == user);

                if (existingTeamName != null)
                {
                    Console.WriteLine($"Team {existingTeamName.TeamName} was already created!");
                    continue;
                }

                if (existingTeamCreator != null)
                {
                    Console.WriteLine($"{user} cannot create another team!");
                    continue;
                }

                Team team = new Team(teamName, user);

                teamsList.Add(team);
                Console.WriteLine($"Team {team.TeamName} has been created by {team.Creator}!");
            }

            string userAndTeamInfo = Console.ReadLine();

            while (userAndTeamInfo != "end of assignment")
            {
                string[] userTokens = userAndTeamInfo.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string userName = userTokens[0];
                string teamName = userTokens[1];

                bool isTeamExisting = teamsList.Any(x => x.TeamName == teamName);
                bool isUserCheating = teamsList.Any(x => x.Creator == userName);
                bool isAlreadyMember = teamsList.Any(x => x.Members.Contains(userName));

                if (isTeamExisting && isUserCheating == false && isAlreadyMember == false)
                {
                    int teamIndex = teamsList.FindIndex(x => x.TeamName == teamName);
                    teamsList[teamIndex].Members.Add(userName);
                }
                else if (!isTeamExisting)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (isAlreadyMember || isUserCheating)
                {
                    Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                }

                userAndTeamInfo = Console.ReadLine();
            }

            List<Team> teamsWithMembers = teamsList
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName)
                .ToList();

            List<Team> teamsToDrop = teamsList
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.TeamName)
                .ToList();

            foreach (Team current in teamsWithMembers)
            {
                Console.WriteLine(current.TeamName);
                Console.WriteLine("- " + current.Creator);
                current.Members.Sort();
                Console.WriteLine(string.Join(Environment.NewLine, current.Members.Select(x => "-- " + x)));
            }

            Console.WriteLine("Teams to disband:");

            foreach (Team teamToDrop in teamsToDrop)
            {
                Console.WriteLine(teamToDrop.TeamName);
            }
        }
    }

    public class Team
    {
        public Team(string teamName, string creatorName)
        {
            TeamName = teamName;
            Creator = creatorName;
            Members = new List<string>();
        }

        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
}
