using System.Text.RegularExpressions;

string pattern = @"\b(?<Day>\d{2})(?<sep>[\.\-\/])(?<Month>[A-Z][a-z]{2})\k<sep>(?<Year>\d{4})\b";
Regex regex = new Regex(pattern);


string input = Console.ReadLine();

MatchCollection matches = regex.Matches(input);

foreach (Match match in matches)
{
    Console.WriteLine($"Day: {match.Groups["Day"]}, Month: {match.Groups["Month"]}, Year: {match.Groups["Year"]}");
}