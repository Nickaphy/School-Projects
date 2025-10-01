namespace BiggestNumberCalc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 2;
            int maks = 0;

            for (int i = 0; i <= count; i++) //Saa laenge i >= count i+1 (tæller)
            {
                Console.WriteLine("Et helt nummer: ");
                int nummer = Convert.ToInt32(Console.ReadLine());
                if (nummer > maks) //Hvis nummer > maks (opdater nye maks)
                {
                    maks = nummer;
                }
            }
            Console.WriteLine($"Det største nummer er: {maks}");
        }
    }
}