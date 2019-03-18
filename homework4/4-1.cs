using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var clock = new Clock();
            clock.going += alarm;
            clock.go();
            Console.ReadKey();
        }
        static void alarm(object sender,TimeArgs e)
        {
            Console.WriteLine("时间已到");
        }
    }
    public class TimeArgs : EventArgs
    {
        string time;
    }
    public delegate void TimeHandler(object sender, TimeArgs e);
    public class Clock
    {
        public event TimeHandler going;
        public void go()
        {
            Console.Write("请设置闹钟时间（时:分）：");
            string s=Console.ReadLine();
            string t = DateTime.Now.ToShortTimeString();
            while(true)
            {
                t = DateTime.Now.ToShortTimeString();
                System.Threading.Thread.Sleep(500);

                if(s==t)
                {
                    TimeArgs args = new TimeArgs();
                    going(this, args);
                    break;
                }
            }
        }
    }
}
