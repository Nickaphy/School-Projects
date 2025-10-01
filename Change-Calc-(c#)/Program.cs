using System;
using System.Threading;

class RestBlöb{
    static void Main()
    {
        Console.Write("Beløb: ");
        int beløb = Convert.ToInt32(Console.ReadLine());
        Console.Write("Betalt: ");
        int betaling = Convert.ToInt32(Console.ReadLine());

        string resultat = Udregner(beløb, betaling);

        Console.WriteLine(resultat);
        Console.ReadLine();
    }

    static string Udregner(int _belöb, int _betaling)
    {
        int retur = _belöb - _betaling;
        int antalTyvere = retur / 20;
        int restEfterTyvere = retur % 20;
        int antalTiere = restEfterTyvere / 10;
        int restEfterTiere = restEfterTyvere % 10;
        int antalFemere = restEfterTiere / 5;
        int restEfterFemere = restEfterTiere % 5;
        int antaltoere = restEfterFemere / 2;
        int restEfterToere = restEfterFemere % 2;
        int antalEnere = restEfterToere % 2;

        return
            $"Antal 20'ere: {antalTyvere}\n" +
            $"Antal 10'ere {antalTiere} \n" +
            $"Antal 5'ere {antalFemere} \n" +
            $"Antal 2'ere {antaltoere} \n"  +
            $"Antal 1'ere {antalEnere}";

    }
}
