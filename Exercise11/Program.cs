class Exercise11
{
    static void Main()
    {
        string[] Phrases ={
            "Can you smell," ,
            "I will destroy everything you hold dear and then in your pit of despair, " ,
            "You have failed",
            "Now run Barry,",
            "My favorite"};
        string[] pt2 ={
            "What the ROCK is Cooking",
            "I'll finally give you my permission to DIE!",
            "THIS CITY! >--->",
            "RUN!! ",
            "American"};

        string[] fNames = { "Dwayne", "Slade", "Oliver", "Barry", "Anatoly" };
        string[] lNames = { "Johnson", "Wilson", "Queen", "Allen", "Knyazev" };
        string[] Cities = { "Miami", "Australia", "Star City", "Central City", "Russian Bratva" };

        Random rnd = new Random();

        for (int i = 0, j = 0; j < 5; i++)
        {
            int rndLp = rnd.Next(0, 5);
            int rndLs = rnd.Next(0, 5);
            int rndFn = rnd.Next(0, 5);
            int rndLn = rnd.Next(0, 5);
            int rndC = rnd.Next(0, 5);



            if (rndLp == rndLs && rndLp == rndFn && rndLp == rndLn && rndLp == rndC)
            {
                Console.WriteLine("{0} {1} - {2} {3}, {4}", Phrases[rndLp], pt2[rndLs], fNames[rndFn], lNames[rndLn], Cities[rndC]);
                Console.WriteLine("\n");
                j++;

            }
        }
    }
}