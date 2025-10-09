using System.ComponentModel;
using System.Net.WebSockets;
class Vare
{
    public string? navn;
    public int antal;
    public double længde;
    public double højde;
    public double bredde;

    public double BeregnRumfang()
    {
        return længde * højde * bredde;
    }
}

class Program
{
    static void Main()
    {
        Console.Clear();
        Vare[] varer = new Vare[4];

        varer[0] = new Vare
        {
            navn = "Cola",
            antal = 2,
            længde = 2.0,
            højde = 0.5,
            bredde = 0.5
        };

        varer[1] = new Vare
        {
            navn = "Slikkepind",
            antal = 10,
            længde = 1.0,
            højde = 0.3,
            bredde = 0.1
        };

        varer[2] = new Vare
        {
            navn = "Rugbrød",
            antal = 2,
            længde = 3.0,
            højde = 0.4,
            bredde = 0.10
        };

        varer[3] = new Vare
        {
            navn = "Øl",
            antal = 100,
            længde = 2.0,
            højde = 1.4,
            bredde = 0.10
        };

        double totalRumfang = 0;
        double gennemsnitsRumfang = 0;

        foreach (var v in varer)
        {
            Console.WriteLine($"{v.antal} stk {v.navn} Rumfang: {v.BeregnRumfang():F2} m³");
            totalRumfang += v.BeregnRumfang();
        }
        gennemsnitsRumfang += totalRumfang / varer.Length;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Total rumfang: {totalRumfang:F2} m³");
        Console.WriteLine($"Gennemsnits rumfang: {gennemsnitsRumfang:F2} m³");
    }
}