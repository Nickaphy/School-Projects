//mm-dd-yyyy
//yyyy-dd-mm
class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        DateTime today = DateTime.Today;
        Console.WriteLine($"The date today is {today}");
        Console.ResetColor();
        string todayString = Convert.ToString(today);
        subStringConvert(todayString);
    }

    static void subStringConvert(string today_)
    {
        string year = today_.Substring(5, 4);
        string day = today_.Substring(3, 1);
        string month = today_.Substring(0, 2);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{year}-0{day}-{month}");
    }
}