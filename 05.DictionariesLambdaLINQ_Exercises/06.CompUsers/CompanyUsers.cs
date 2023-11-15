Dictionary<string, List<string>> companies = new();

string input = Console.ReadLine();

while (input != "End")
{
    string[] inputArray = input.Split(" -> ");
    string company = inputArray[0];
    string employeeId = inputArray[1];

    if (!companies.ContainsKey(company))
    {
        companies.Add(company, new List<string>());
    }

    if (!companies[company].Contains(employeeId))
    {
        companies[company].Add(employeeId);
    }
    
    input = Console.ReadLine();
}

foreach (var currentCompany in companies)
{
    Console.WriteLine(currentCompany.Key);

    foreach (string currentEmployeeId in currentCompany.Value)
    {
        Console.WriteLine($"-- {currentEmployeeId}");
    }
}