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
            OrderSerevice s = new OrderSerevice();
            while(true)
            {
                Console.WriteLine("请选择：");
                Console.WriteLine("1.添加订单");
                Console.WriteLine("2.删除订单");
                Console.WriteLine("3.修改订单");
                Console.WriteLine("4.查询订单");
                int i = Int32.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1: s.outadd(); break;
                    case 2: s.del(); break;
                    case 3: s.change(); break;
                    case 4: s.outfind(); break;
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
        public void show()
        {
            Console.WriteLine("商品：" + this.commodity);
            Console.WriteLine("数量：" + this.num);
            Console.WriteLine("单价：" + this.price);
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
        public void setno(string s)
        {
            this.no = s;
        }
        public void setclient(string s)
        {
            this.client = s;
        }
        public void show()
        {
            Console.WriteLine("订单号：" + this.no);
            Console.WriteLine("客户：" + this.client);
            order.show();
            Console.WriteLine("总额：" + order.calculate());
        }
    }
    class OrderSerevice 
    {
        List<OrderDetails> list;
        public OrderSerevice()
        {
            list = new List<OrderDetails>();
        }
        public void outadd()
        {
            add();
            Console.WriteLine("添加成功");
        }
        public void add()
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
            list.Add(o);
        }
        public void outfind()
        {
            try
            {
                list.ElementAt(find()).show();
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
                add();
                Console.WriteLine("修改成功！");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("修改失败！");
            }
        }
        
    }
}
