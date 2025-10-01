namespace AnimalShopCount;

class Program
{
    static void Main()
    {
        Console.WriteLine("Finding combinations where:");
        Console.WriteLine("- Total money spent = 100 kr");
        Console.WriteLine("- Total animals = 100");
        Console.WriteLine("- Prices: Pigs = 10 kr, Chickens = 3 kr, Doves = 0.50 kr\n");

        int count = 0;

        for (int pigs = 0; pigs <= 10; pigs++)
        {
            for (int chickens = 0; chickens <= 33; chickens++)
            {
                for (int doves = 0; doves <= 200; doves++)
                {
                    if (pigs + chickens + doves == 100 && 
                        pigs * 10 + chickens * 3 + doves * 0.5 == 100)
                    {
                        count++;
                        Console.WriteLine($"Combination {count}:");
                        Console.WriteLine($"  Pigs: {pigs} (Cost: {pigs * 10} kr)");
                        Console.WriteLine($"  Chickens: {chickens} (Cost: {chickens * 3} kr)");
                        Console.WriteLine($"  Doves: {doves} (Cost: {doves * 0.5} kr)");
                        Console.WriteLine($"  Total Animals: 100");
                        Console.WriteLine($"  Total Cost: 100 kr");
                        Console.WriteLine("------------------------");
                    }
                }
            }
        }
        
        Console.WriteLine($"Total number of combinations found: {count}");
    }
}