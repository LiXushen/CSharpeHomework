using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int i,n;
            int max = 0, min = 0;
            float sum =0;
            Console.Write("请输入数组大小:");
            s = Console.ReadLine();
            n = Int32.Parse(s);
            int[] m = new int[n];
            for (i=0;i<n;i++)
            {
                Console.Write("请输入第{0}个元素:",i+1);
                s = Console.ReadLine();
                m[i] = Int32.Parse(s);
                if (i == 0) max = min = m[0];
                else
                {
                    if (m[i] > max) max = m[i];
                    if (m[i] < min) min = m[i];
                }
                sum += m[i];
            }
            Console.WriteLine("最大值:"+max);
            Console.WriteLine("最小值:" + min);
            Console.WriteLine("平均值:" + sum / n);
            Console.WriteLine("总和:" + sum);
            Console.ReadKey();
        }
    }
}
