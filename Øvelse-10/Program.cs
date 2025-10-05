class Program
{
    static void Main()
    {
        Console.Clear();
        inputOgValidering();
    }

    static void inputOgValidering()
    {
        int[] gammelSkala = {13, 11, 10, 9, 8, 7, 6, 5, 03, 00};

        bool x = true;
        do
        {
            Console.Clear();
            Console.WriteLine("Karakter (13 trins): ");
            string inputString = Console.ReadLine();

            if (int.TryParse(inputString, out int inputInt))
            
                foreach (int gammelNum in gammelSkala)
                {
                    if (inputInt == gammelNum)
                    {
                        x = false;
                        Console.Clear();
                        Beregner(inputInt);
                    }
                    else
                    {
                        Console.WriteLine("Ikke valid karakter");
                        Thread.Sleep(1000);
                        Console.Clear();
                        inputOgValidering();
                    }
                }
            }
            else
            {
                Console.WriteLine("Ikke valid karakter");
                Thread.Sleep(1000);
                Console.Clear();
            }
        } while (x);
    }

    static void Beregner(int inputIntBeregner)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        switch (inputIntBeregner)
        {
            case 13:
                Console.WriteLine("Din karakter ville være 12");
                Console.ReadKey();
                break;
            case 11:
                Console.WriteLine("Din karakter ville være 12");
                Console.ReadKey();
                break;
            case 10:
                Console.WriteLine("Din karakter ville være 10");
                Console.ReadKey();
                break;
            case 9:
                Console.WriteLine("Din karakter ville være 7");
                Console.ReadKey();
                break;
            case 8:
                Console.WriteLine("Din karakter ville være 7");
                Console.ReadKey();
                break;
            case 7:
                Console.WriteLine("Din karakter ville være 4");
                Console.ReadKey();
                break;
            case 6:
                Console.WriteLine("Din karakter ville være 02");
                Console.ReadKey();
                break;
            case 5:
                Console.WriteLine("Din karakter ville være 00");
                Console.ReadKey();
                break;
            case 03:
                Console.WriteLine("Din karakter vile være 00");
                Console.ReadKey();
                break;
            case 00:
                Console.WriteLine("Din karakter ville være -3");
                Console.ReadKey();
                break;

        }
    }
}
