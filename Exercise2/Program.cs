class Exercise2
{
    static void Main()
    {
        Random rnd = new Random();

        Console.Write("Here are 10 random numbers between 100 and 200: {0}", rnd.Next(100,200));
        for(int i = 0; i < 9; i++)
        {
            Console.Write(", "+rnd.Next(100,200));
        }
    }
}