using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            string s;
            Console.Write("请输入一个整数:");
            s = Console.ReadLine();
            n = Int32.Parse(s);
            Console.Write(n + "=");
            for (i = 2; i <= n; i++)
            {
                while (i < n)
                {
                    if (n % i > 0) break;
                    else { Console.Write(i + "*"); n = n / i; }
                }
            }
            Console.Write(n);
            Console.ReadKey();
        }
    }
}
