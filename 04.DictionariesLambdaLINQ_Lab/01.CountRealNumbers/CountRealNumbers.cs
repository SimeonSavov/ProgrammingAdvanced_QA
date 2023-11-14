int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

SortedDictionary<int, int> numbersFrequency = new();

foreach (int num in numbers)
{
    if (numbersFrequency.ContainsKey(num))
    {
        numbersFrequency[num]++;
    }
    else
    {
        numbersFrequency[num] = 1;
    }
}

foreach (KeyValuePair<int, int> pair in numbersFrequency)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}
