string[] words = Console.ReadLine().Split();

Dictionary<string, int> wordsCount = new();

foreach (string word in words)
{
    string caseInsensetiveWord = word.ToLower();

    if (wordsCount.ContainsKey(caseInsensetiveWord))
    {
        wordsCount[caseInsensetiveWord]++;
    }
    else
    {
        wordsCount[caseInsensetiveWord] = 1;
    }
}


foreach (KeyValuePair<string, int> pair in wordsCount)
{
    if (pair.Value % 2 != 0)
    {
        Console.Write(pair.Key + " ");
    }
}
