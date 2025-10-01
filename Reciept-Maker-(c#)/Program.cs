namespace Regningsopgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Varen: ");
            string varenavn = Console.ReadLine();
            Console.Write("Stk pris: ");
            double stkpris = Convert.ToDouble(Console.ReadLine());
            Console.Write("Antal: ");
            int antal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Rabatsats(uden procent:) ");
            int rabatsats = Convert.ToInt32(Console.ReadLine());
            string result = Calc(varenavn, stkpris, antal, rabatsats);
            Console.WriteLine(result);
            Console.WriteLine();
        }

        public static string Calc(string _varenavn, double _stkpris, int _antal, int _rabatsats)
        {
            Console.Clear();
            if (_antal > 10)
            {
                int effektivRabat = _rabatsats + 5; //Den effektive rabat
                double fratrukkenBeløb = (_antal * _stkpris) * effektivRabat / 100; //Det fratrukne beløb
                double prisEfterRabat = _stkpris * (1 - (effektivRabat / 100)); //Den nye pris
                double moms = prisEfterRabat * 0.25; //Moms udregning
                double prisInclMoms = prisEfterRabat + moms; // + moms
                double sidstePris = prisInclMoms * _antal; //sidste prisen incl moms

                return
                    $"Vare: {_varenavn}\n" +
                    $"Antal: {_antal} stk.\n" +
                    $"Stk pris incl. moms: {sidstePris:F2} kr.\n" +
                    $"Effektiv rabat {fratrukkenBeløb:F2} kr.\n" +
                    $"Moms: 25%\n" +
                    $"Beløb: {sidstePris:F2} kr.";
            }
            else
            {
                double prisEfterRabat2 = _stkpris * (1 - (_rabatsats / 100));
                double fratrukkenBeløb2 = (_antal * _stkpris) * _rabatsats / 100;
                double moms2 = prisEfterRabat2 * 0.25;
                double prisInclMoms2 = prisEfterRabat2 + moms2;
                double sidstePris2 = prisInclMoms2 * _antal;

                return
                    $"Vare: {_varenavn}\n" +
                    $"Antal: {_antal} stk.\n" +
                    $"Stk pris incl. moms: {sidstePris2:F2} kr.\n" +
                    $"Effektiv rabat {fratrukkenBeløb2:F2} kr.\n" +
                    $"Moms: 25%\n" +
                    $"Beløb: {sidstePris2:F2} kr.";
            }
        }
    }
}
