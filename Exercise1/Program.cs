class Exercise1
{
    static void Main()
    {
        bool errorCatch = false, leap;
        int year = 0;
        Console.Write("Please enter a year of your choice: ");

        while (errorCatch == false)
        {
            errorCatch = int.TryParse(Console.ReadLine(), out year);
            if (errorCatch && year > 0) { break; }
            Console.Write("\nInvalid option entered. Please enter another year: ");
        }

        leap = DateTime.IsLeapYear(year);

        if (leap)
        {
            Console.WriteLine("\n{0} was a leap year", year);
        }

        else { Console.WriteLine("\n{0} was not a leap year", year); }
    }
}