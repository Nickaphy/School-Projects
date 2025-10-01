namespace SkudarBeregner     
{
    internal class Program
    {
        /* For at et år kan være et skud år skal den leve op til følgende krav:
        1. Den skal kunne deles med 4 (x/4)
        2. Hvis den kan deles med 400 er den også et skud år (x/400)
        3. Hvis den kan deles med 100 er den ikke et skudår (x/100)
        */

        static int årsTalInt; //Erklærer dem på klasse niveau 
        static string resultat;
        static void Main(string[] args)
        {
            bool x = true;
            while (x == true)
            {
                Console.Write("Indtast årstallet: ");
                string årsTalString = Console.ReadLine();
                if (int.TryParse(årsTalString, out årsTalInt)) //En fejlsikker "Convert"
                {
                    resultat = Beregner(årsTalInt); //Går videre til beregner metoden
                    x = false; //Afslutter loopet
                }
                else
                {
                    Console.WriteLine("Du skulle indtaste et årstal...");
                    Thread.Sleep(1500);
                    Console.Clear();
                }
            }
            Console.WriteLine($"År {årsTalInt} {resultat}");
        }

        static string Beregner(int årsTalInt)
        {
            int divisionHundredRest = årsTalInt % 100;
            int divisionFireRest = årsTalInt % 4;
            int divisionFirehundredRest = årsTalInt % 400;

            if (divisionHundredRest == 0)
            {
                return "Er/var ikke et skudår";
            }else if (divisionFireRest == 0)
            {
                return "Er/var et skudår";
            }else if (divisionFirehundredRest == 0)
            {
                return "Er/var et skudår";
            }else
            {
                return "Er/var ikke et skudår";
            }            
        }
    }
}