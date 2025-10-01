using System;

class KvartalUdrenger 
{
    static void Main() 
	{
		string? resultat = "";
		Console.WriteLine("Indtast en månedstal (0 - 12)");
		string? brugerInput = Console.ReadLine();


		bool x = true;
		while (x)
		{
			if (int.TryParse(brugerInput, out int brugerInputInt) && brugerInputInt < 13)
			{
				resultat = Beregner(brugerInputInt);
				x = false;

			}else
			{
				Console.WriteLine("A number between 0 - 12 please: ");
				Console.Clear();
			}
		}

		Console.WriteLine(resultat);
	}


	static string Beregner(int brugerInputInt)
	{
		if (brugerInputInt < 5){
			return $"Den {brugerInputInt} måned ligger i første kvartal";
		}else if (brugerInputInt > 4 && brugerInputInt < 9){
			return $"Den {brugerInputInt} måned ligger i andet kvartal";
		}else if (brugerInputInt > 8 && brugerInputInt < 13){
			return $"Den {brugerInputInt} måned ligger i tredje kvartal";
		}else {
			return $"Den {brugerInputInt} måned ligger i tredje kvartal";
		}
	}
}
