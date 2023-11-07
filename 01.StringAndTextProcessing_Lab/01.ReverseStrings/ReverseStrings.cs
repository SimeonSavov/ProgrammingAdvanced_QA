string command = Console.ReadLine();

while (command != "end")
{
    string reversedWord = string.Join("", command.ToCharArray().Reverse());

    Console.WriteLine($"{command} = {reversedWord}");

    command = Console.ReadLine();
}
