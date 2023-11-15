Dictionary<string, string> registered = new();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] commandArray = Console.ReadLine().Split().ToArray();

    string command = commandArray[0];
    string employee = commandArray[1];

    if (command == "register")
    { 
        string plateNumber = commandArray[2];

        if (!registered.ContainsKey(employee))
        {
            registered.Add(employee, plateNumber);
            Console.WriteLine($"{employee} registered {plateNumber} successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: already registered with plate number {registered[employee]}");
        }
    }
    else if (command == "unregister")
    {
        if (registered.ContainsKey(employee))
        {
            registered.Remove(employee);
            Console.WriteLine($"{employee} unregistered successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: user {employee} not found");
        }
    }
}

foreach (var pair in registered)
{
    Console.WriteLine($"{pair.Key} => {pair.Value}");
}