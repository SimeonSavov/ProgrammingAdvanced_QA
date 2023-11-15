Dictionary<string, List<decimal>> products = new();

string input = Console.ReadLine();

while (input != "buy")
{
    string[] inputArray = input.Split();
    string product = inputArray[0];
    decimal price = decimal.Parse(inputArray[1]);
    decimal quantity = decimal.Parse(inputArray[2]);

    if (!products.ContainsKey(product))
    {
        products.Add(product, new List<decimal>() { price, quantity });
    }
    else
    {
        products[product][0] = price;
        products[product][1] += quantity;
    }

    input = Console.ReadLine();
}

foreach (var pair in products)
{
    string currentProductName = pair.Key;
    decimal currentProductPrice = pair.Value[0];
    decimal currentProductQuantity = pair.Value[1];

    decimal currentProductAmount = currentProductPrice * currentProductQuantity;

    Console.WriteLine($"{currentProductName} -> {currentProductAmount:f2}");
}