using System.Text;
class stringBuildingAndCOmparisons
{
    static StringBuilder fname = new StringBuilder();
    static void Main()
    {
        string name = "Isaac Desmond";
        Random rand = new Random();
        int randomNum = rand.Next(name.Length);
        for (int i = 0; i < name.Length; i++)
        {
            if (String.Equals(name[i], ' '))
            {
                break;
            }
            fname.Append(name[i]);
        }
        Console.WriteLine("The random number chosen is {0} and my first name is {1}", randomNum, fname);
    }
}