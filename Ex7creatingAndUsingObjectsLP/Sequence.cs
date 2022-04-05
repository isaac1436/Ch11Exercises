using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7CreatingAndUsingObjectsLP
{
    internal class Sequence
    {
        public static int currVal = 0;

        public static int nextVal()
        {
            currVal++;
            return currVal;
        }
    }
}
