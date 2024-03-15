Random random = new Random();
int coinLucky = random.Next(2);

Console.WriteLine($"Result: {(coinLucky==1? "Cara":"Cruz") }");