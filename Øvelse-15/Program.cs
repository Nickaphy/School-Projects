/*
Et c# program der simulere 600 kast men en terning.
Antal af 0..5 skal gemmes i et array kaldet "antal" med plads til 6 int værdier.
Lige mange af hver kast?
Udskriv tabellens elementer på skærmen under hindanden.
*/
class program
{
    static void Main()
    {
        int[] antal = new int[6];
        Random terningKast = new Random();

        for (int i = 0; i <= 600; i++)
        {
            int kast = terningKast.Next(0, 6);
            antal[kast]++;
        }
        for (int i = 0; i < antal.Length; i++)
        {
            Console.WriteLine($"Antal af {i}: {antal[i]}");
        }
    }
}




