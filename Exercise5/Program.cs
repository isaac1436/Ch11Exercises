class Exercise5
{
    static void Main()
    {
        bool errorcatch = false;
        double a=0, b=0,hyp;
        Console.WriteLine(@" |\ ");
        Console.WriteLine(@" | \ ");
        Console.WriteLine(@"a|  \ ");
        Console.WriteLine(@" |   \ ");
        Console.WriteLine(@" |    \ ");
        Console.WriteLine(@" |_____\");
        Console.WriteLine("     b    ");

        Console.Write("\nPlease enter the value of side \'a\': ");
        while (errorcatch == false) { errorcatch = double.TryParse(Console.ReadLine(), out a); }

        errorcatch = false;
        Console.Write("\nPlease enter the value of side \'b\': ");
        while (errorcatch == false) { errorcatch = double.TryParse(Console.ReadLine(), out b); }

        hyp = Math.Sqrt(Math.Pow(a,2)+ Math.Pow(b , 2));

        Console.WriteLine("\nThe value of the hypotenuse of the right angle triangle is {0}",hyp);
    }
}