int countTeams = int.Parse(Console.ReadLine());

Dictionary<string, Team> teams = new Dictionary<string, Team>();

for (int i = 1; i <= countTeams; i++)
{
    string[] teamData = Console.ReadLine().Split("-").ToArray();
    string creator = teamData[0];
    string teamName = teamData[1];

    if (teams.ContainsKey(teamName))
    {
        Console.WriteLine($"Team {teamName} was already created!");
        continue;
    }

    if (teams.Any(t => t.Value.Creator == creator))
    {
        Console.WriteLine($"{creator} cannot create another team!");
        continue;
    }

    Team team = new Team(teamName, creator);
    Console.WriteLine($"Team {teamName} has been created by {creator}!");

    teams.Add(teamName, team);
}

string command = Console.ReadLine();

while (command != "end of assignment")
{
    string memberJoin = command.Split("->")[0];
    string teamJoining = command.Split("->")[1];

    if (!teams.ContainsKey(teamJoining))
    {
        Console.WriteLine($"Team {teamJoining} does not exist!");
    }
    else
    {
        bool memberAlreadyOnTeam = teams.Values.Any(t => t.Members.Contains(memberJoin));

        if (memberAlreadyOnTeam || memberJoin == teams[teamJoining].Creator)
        {
            Console.WriteLine($"Member {memberJoin} cannot join team {teamJoining}!");
        }
        else
        {
            teams[teamJoining].Members.Add(memberJoin); // Add "member" to "team"
        }
    }

    command = Console.ReadLine();
}

// Sorted and print the team with members only!
foreach (var team in teams.Where(team => team.Value.Members.Count > 0)
                          .OrderByDescending(team => team.Value.Members.Count) 
                          .ThenBy(team => team.Key))
{
    // Sorted Dictionary with teams with members in there!
    Console.WriteLine($"{team.Key}");
    Console.WriteLine($"- {team.Value.Creator}");

    foreach (string member in team.Value.Members.OrderBy(m => m))
    {
        Console.WriteLine($"-- {member}");
    }
}

// Print teams without members
Console.WriteLine($"Teams to disband: ");
foreach (var team in teams.Where(team => team.Value.Members.Count == 0)
                          .OrderBy(team => team.Key)) // Teams without members!
{
    Console.WriteLine($"{team.Key}");
}