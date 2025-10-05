/*
Opret et array med 10 tilfældige positive int værdier mellem 1 og 9.
Programmet skal i en forløkke opsummere disse tilfældige værdier og tilsidst udskrive
summen og gennemsnittet af tallene i arrayet. 
Find det største tal og positionen der er i.
Der skal dannes et array baseret på det første hvor alle tal under 5 gemmes i.
*/
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

class Program
{
    static void Main()
    {
        int[] array1 = Array_1();
        int[] array2 = Array_2(array1);
        StørsteTal(array1);
        SumGennemsnit(array1);

    }

    static int[] Array_1()
    {
        int[] array1 = new int[10];
        Random random = new Random();

        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = random.Next(1, 10); 
        }
        Console.WriteLine("Array1 værdier:");
        foreach (int tal in array1)
        {
            Console.WriteLine(tal);
            Console.WriteLine("-");
        }
        Console.WriteLine("------------------------------------------------------------------");
        return array1;
}

    static int[] Array_2(int[] array1)
    {
        Console.WriteLine("Tal under 5:");
        var list = new List<int>();
        foreach (int talUnderFem in array1)
        {
            if (talUnderFem < 5)
            {
                list.Add(talUnderFem);
            }
        }
        int[] array2 = list.ToArray();
        foreach (int tal in array2)
        {
            Console.WriteLine(tal);
            Console.WriteLine("-");
        }
        Console.WriteLine("------------------------------------------------------------------");
        return array2;
    }

    static void StørsteTal(int[] array1)
    {
        int størst = array1[0];
        int index = 0;

        for (int i = 1; i < array1.Length; i++)
        {
            if (array1[i] > størst)
            {
                størst = array1[i];
                index = i;
            }
        }
        Console.WriteLine($"Største tal: {størst}\n Index: {index}");
        Console.WriteLine("------------------------------------------------------------------");
    }

    static void SumGennemsnit(int[] array1)
    {
        int sum = 0; 
        foreach (int tal in array1)
        {
            sum += tal;
        }
        double gennemsnit = (double)sum / array1.Length;
        Console.WriteLine($"Sum: {sum}\n Gennemsnit: {gennemsnit}");
        Console.WriteLine("------------------------------------------------------------------");

    }
}