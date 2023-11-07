using System.Text;

string[] array = Console.ReadLine().Split();

StringBuilder output = new();

for (int i = 0; i < array.Length; i++)
{
    string currentWord = array[i];

	for (int j = 0; j < currentWord.Length; j++)
	{
		output.Append(currentWord);
	}
}

Console.WriteLine(output);

