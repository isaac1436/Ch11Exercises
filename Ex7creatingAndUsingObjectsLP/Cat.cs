namespace Ex7CreatingAndUsingObjectsLP
{
    public class Cat
    {
        public string name;

        public Cat(string name)
        {
            this.name = name;
        }

        public static void SayMiau(string name)
        {
            Console.WriteLine("\n{0} says miau!!!\n", name);
        }
    }
}