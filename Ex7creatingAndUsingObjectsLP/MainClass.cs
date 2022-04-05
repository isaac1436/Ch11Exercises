using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7CreatingAndUsingObjectsLP
{
    internal class MainClass
    {
        static void Main()
        {
            string[] catNames = new string[10];

            for (int i = 0; i < catNames.Length; i++)
            {
                Console.Write("\nEnter the name of the Cat: ");
                Cat currCat = new Cat(Console.ReadLine());
                catNames[Sequence.currVal] = currCat.name;
                Sequence.nextVal();
            }

            for (int i = 0; i < catNames.Length; i++)
            {
                Cat.SayMiau(catNames[i]);
            }
        }

    }
}
