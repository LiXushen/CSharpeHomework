using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int a, b;
            System.Console.Write("请输入第一个数:");
            s = Console.ReadLine();
            a = Int32.Parse(s);
            System.Console.Write("请输入第二个数:");
            s = Console.ReadLine();
            b = Int32.Parse(s);
            Console.WriteLine("积："+(a*b));
            Console.ReadKey();
        }
    }
}
