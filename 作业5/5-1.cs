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
            OrderSerevice s = new OrderSerevice();
            while(true)
            {
                Console.WriteLine("请选择：");
                Console.WriteLine("1.添加订单");
                Console.WriteLine("2.删除订单");
                Console.WriteLine("3.修改订单");
                Console.WriteLine("4.查询订单");
                Console.WriteLine("5.订单号排序");
                Console.WriteLine("6.订单总额排序");
                Console.WriteLine("7.退出");
                int i = Int32.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1: s.outadd(); break;
                    case 2: s.del(); break;
                    case 3: s.change(); break;
                    case 4: s.outfind(); break;
                    case 5: s.sort();break;
                    case 6: s.sort_price();break;
                    default: return;
                }
            }
        }
    }
    class Order
    {
        public string commodity;
        public int num;
        public int price;
        public void setcommodity(string s)
        {
            this.commodity = s;
        }
        public void setnum(int n)
        {
            this.num = n;
        }
        public void setprice(int n)
        {
            this.price = n;
        }
        public int calculate()
        {
            return num * price;
        }
        public void ToString()
        {
            Console.WriteLine("商品：" + this.commodity);
            Console.WriteLine("数量：" + this.num);
            Console.WriteLine("单价：" + this.price);
        }
        public bool equals(Order o)
        {
            if (this.num != o.num) return false;
            if (this.commodity != o.commodity) return false;
            if (this.price != o.price) return false;
            return true;
        }
    }
    class OrderDetails
    {
        public string no;
        public string client;
        public Order order;
        public OrderDetails()
        {
            order = new Order();
        }
        public int price()
        {
            return order.calculate();
        }
        public void setno(string s)
        {
            this.no = s;
        }
        public void setclient(string s)
        {
            this.client = s;
        }
        public void ToString()
        {
            Console.WriteLine("订单号：" + this.no);
            Console.WriteLine("客户：" + this.client);
            order.ToString();
            Console.WriteLine("总额：" + order.calculate());
        }
        public bool equals(OrderDetails o)
        {
            if (this.no != o.no) return false;
            if (this.client != o.client) return false;
            if (!this.order.equals(o.order)) return false;
            return true;
        }
    }
    public interface IComparable
    {
        void sort();
    }
    class OrderSerevice : IComparable
    {
        List<OrderDetails> list;
        public OrderSerevice()
        {
            list = new List<OrderDetails>();
        }
        public void outadd()
        {
            if(ad()) Console.WriteLine("添加成功");
        }
        public bool ad()
        {
            OrderDetails o = new OrderDetails();
            Console.Write("请输入订单号：" );
            o.setno(Console.ReadLine());
            Console.Write("请输入客户：");
            o.setclient(Console.ReadLine());
            Console.Write("请输入商品名：");
            o.order.setcommodity(Console.ReadLine());
            Console.Write("请输入数量：");
            o.order.setnum(Int32.Parse(Console.ReadLine()));
            Console.Write("请输入单价：");
            o.order.setprice(Int32.Parse(Console.ReadLine()));
            foreach (OrderDetails p in list)
            {
                if (p.equals(o)) return false;
            }
            list.Add(o);
            return true;
        }
        public void outfind()
        {
            try
            {
                list.ElementAt(find()).ToString();
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("查找失败！");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("查找失败！");
            }
        }
        public int find()
        {
            Console.WriteLine("请选择：");
            Console.WriteLine("1.按订单号查找");
            Console.WriteLine("2.按商品名查找");
            Console.WriteLine("3.按客户查找");
            int i = Int32.Parse(Console.ReadLine()); 
            switch (i)
            {
                case 1: Console.Write("请输入订单号：");return findByNo(Console.ReadLine());
                case 2: Console.Write("请输入商品名："); return findByCommodity(Console.ReadLine());
                case 3: Console.Write("请输入客户："); return findByClient(Console.ReadLine());
                default:return -1;
            }
        }
        public int findByNo(string s)
        {
            int i = 0;
            foreach(OrderDetails o in list)
            {
                if (o.no == s) return i;
                i++;
            }
            return -1;
        }
        public int findByCommodity(string s)
        {
            int i = 0;
            foreach (OrderDetails o in list)
            {
                if (o.order.commodity == s) return i;
                i++;
            }
            return -1;
        }
        public int findByClient(string s)
        {
            int i = 0;
            foreach (OrderDetails o in list)
            {
                if (o.client == s) return i;
                i++;
            }
            return -1;
        }
        public void del()
        {
            try
            {
                list.RemoveAt(find());
                Console.WriteLine("删除成功！");
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("删除失败！");
            }
        }
        public void change()
        {
            try
            {
                list.RemoveAt(find());
                if(ad()) Console.WriteLine("修改成功！");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("修改失败！");
            }
        }
        public void sort()
        {
            this.list.Sort((a,b)=>a.no.CompareTo(b.no));
        }
        public void sort_price()
        {
            this.list.Sort((a, b)=>a.price().CompareTo(a.price()));
        }
    }
}
