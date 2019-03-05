using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] m = new int[100];
            int i,j;
            for (i = 0; i <100; i++) m[i] = i+2;
            i = 0;
            while (i < 99)
            {
                for (j = i + 1; j < 99; j++) if (m[j] % m[i] == 0) m[j] = 0;
                do
                {
                    i++;
                } while (m[i] == 0);
            }
            for (i = 0; i < 99; i++) if (m[i] > 0) Console.Write(m[i] + " ");
            Console.ReadKey();
        }
    }
}
