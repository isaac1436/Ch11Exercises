class Exercise4
{
    static void Main()
    {
        int seconds=Environment.TickCount/1000;
        int minutes=Environment.TickCount/60000;
        int hours = (Environment.TickCount / 3600000);
        int days = Environment.TickCount / 86400000;
        Console.WriteLine("Its been {0} days, {1} hours, {2} minutes and {3} seconds",days,hours,minutes,seconds);
    }
}