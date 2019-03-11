using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieTicket mt = new MovieTicket();
            double originalPrice = 60.0;
            mt.setPrice(originalPrice);
            Console.WriteLine("原始票价为：" + originalPrice);

            Discount discount = getDiscount();
            mt.setDiscount(discount);
            double currentPrice=mt.getPrice();
            Console.WriteLine("折后价为：" + currentPrice);

        }
        public static Discount getDiscount()
        {
            string s;
            int i;
            System.Console.Write("请选择(1.学生  2.儿童    3.VIP):");
            s = Console.ReadLine();
            i = Int32.Parse(s);
            switch(i)
            {
                case 1:return new StudentDiscount();
                case 2: return new StudentDiscount();
                default: return new StudentDiscount();
            }
        }
    }
    class MovieTicket
    {
        private double price;
        private Discount discount;
        public void setPrice(double price)
        {
            this.price = price;
        }
        public void setDiscount(Discount discount)
        {
            this.discount = discount;
        }
        public double getPrice()
        {
            return discount.calculate(this.price);
        }
    }
    interface Discount
    {
        double calculate(double price);
    }
    class StudentDiscount:Discount
    {
        public double calculate(double price)
        {
            Console.WriteLine("学生票：");
            return price * 0.8;
        }
    }
    class ChiDiscount : Discount
    {
        public double calculate(double price)
        {
            Console.WriteLine("儿童票：");
            return price - 10;
        }
    }
    class VIPDiscount : Discount
    {
        public double calculate(double price)
        {
            Console.WriteLine("VIP票：");
            Console.WriteLine("增加积分");
            return price * 0.5;
        }
    }
}
