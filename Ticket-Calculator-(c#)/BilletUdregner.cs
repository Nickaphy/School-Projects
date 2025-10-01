using System;
using System.Threading;
/*
A train ticket costs 90 kr.
There is a discount based on your age, and which weekday you travel on.

Monday, Tuesday = 10% discount (81 kr)
If the person 12, or over 65 there is a furhter 10 kr discount (71 kr)

If the person is 67 the ticket is always 80 kr.
*/
namespace BilletUdregner
{
    class BilletUdregner
    {
        public static string? resultat;
        public static bool x = true;
        static void Main()
        {
            do
            {
                Console.Write("What is your age: \n");
                string? ageStr = Console.ReadLine();
                Console.Write("Which day?: \n [1] Monday \n [2] Tuesday \n [3] Wednesday \n [4] Thursday \n [5] Friday \n [6] Saturday \n [7] Sunday \n");
                string? weekDayStr = Console.ReadLine();

                if (int.TryParse(ageStr, out int ageInt)
                && int.TryParse(weekDayStr, out int weekDayInt)
                && weekDayInt <= 7 && weekDayInt >= 1)
                {
                    resultat = Udregner(weekDayInt, ageInt);
                    x = false;
                }
                else
                {
                    Console.WriteLine("Are you a little slow?");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            } while (x);
            Console.WriteLine(resultat);
        }

        static string Udregner(int weekDay, int age)
        {
            if (age == 12 || age >= 65)
            {
                if (weekDay == 1 || weekDay == 2)
                {
                    return "Pris: 71 kr.";
                }
                return "Pris: 81 kr.";
            }
            else if (age == 67)
            {
                return "Pris: 80 kr.";
            }
            else
            {
                return "Pris: 90 kr.";
            }
        }
    }
}
