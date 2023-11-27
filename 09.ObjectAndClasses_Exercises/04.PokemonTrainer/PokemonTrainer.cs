string command = Console.ReadLine();

List<Trainer> trainers = new List<Trainer>();

while  (command != "Tournament")
{
    //{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}
    string[] data = command.Split().ToArray();

    Pokemon currentPokemon = new Pokemon(data[1], data[2], int.Parse(data[3]));

    bool trainerExists = false;

    Trainer existingTrainers = new Trainer();
    foreach (Trainer trainer in trainers)
    {
        if (data[0] == trainer.Name)
        {
            trainerExists = true;
            existingTrainers = trainer;
        }
    }

    if (trainerExists)
    {
        existingTrainers.Pokemons.Add(currentPokemon);
    }
    else
    {
        Trainer currentTrainer = new Trainer(data[0]);
        currentTrainer.Pokemons.Add(currentPokemon);
        trainers.Add(currentTrainer);
    }

    command = Console.ReadLine();
}

string commandTwo = Console.ReadLine();

while (commandTwo != "End")
{
    for (int i = 0; i < trainers.Count; i++)
    {
        bool hasPokemon = false;

        foreach (Pokemon pokemon in trainers[i].Pokemons)
        {
            if (commandTwo == pokemon.Element)
            {
                hasPokemon = true;
            }
        }

        if (hasPokemon)
        {
            trainers[i].Badges++;
        }
        else
        {
            trainers[i].Pokemons.ForEach(p => { p.Health -= 10; });
        }

        trainers[i].Pokemons.RemoveAll(x => x.Health <= 0);
    }

    commandTwo = Console.ReadLine();
}

List<Trainer> sortedTrainers = trainers.OrderByDescending(t => t.Badges).ToList();
foreach (Trainer t in sortedTrainers)
{
    Console.WriteLine($"{t.Name} {t.Badges} {t.Pokemons.Count}");
}