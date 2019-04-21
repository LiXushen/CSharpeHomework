using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public int i = 0;
        public int j = 0;
        public static OrderService orderService = new OrderService();
        public static List<Order> orders;
        public static Order order;
        public static OrderDetail detail;

        public void update(List<Order> results)
        {
            if(results.Count==0)
            {
                MessageBox.Show("不存在满足要求的订单！");
                return;
            }
            orders = results;
            i = 0;
            showOrder();
        }

        public void showOrder()
        {
            if (i == orders.Count) i--;
            LastOrder.Enabled = !(i == 0);
            NextOrder.Enabled = !(i == orders.Count - 1);
            if (orders.Count == 0)
            {
                i = 0;
                OrderId.Text = "";
                CustomerId.Text = "";
                CustomerName.Text = "";
                LastOrder.Enabled = NextOrder.Enabled = false;
                return;
            }
            order = orders.ElementAt(i);
            OrderId.Text= order.Id.ToString();
            CustomerId.Text = order.Customer.Id.ToString();
            CustomerName.Text = order.Customer.Name;
            j = 0;
            showDetail();
        }

        public void showDetail()
        {
            if (j == order.Details.Count) j--;
            LastDetail.Enabled = !(j == 0);
            NextDetail.Enabled = !(j == order.Details.Count - 1);
            if (order.Details.Count == 0)
            {
                j = 0;
                GoodsId.Text = "";
                GoodsName.Text = "";
                GoodsPrice.Text = "";
                Quantity.Text = "";
                LastDetail.Enabled = NextDetail.Enabled = false;
                return;
            }
            detail = order.Details.ElementAt(j);
            GoodsId.Text = detail.Goods.Id.ToString();
            GoodsName.Text = detail.Goods.Name;
            GoodsPrice.Text = detail.Goods.Price.ToString();
            Quantity.Text = detail.Quantity.ToString();
        }

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Customer customer1 = new Customer(1, "Customer1");
            Customer customer2 = new Customer(2, "Customer2");

            Goods milk = new Goods(1, "Milk", 69.9f);
            Goods eggs = new Goods(2, "eggs", 4.99f);
            Goods apple = new Goods(3, "apple", 5.59f);

            Order order1 = new Order(1, customer1);
            order1.AddDetails(new OrderDetail(apple, 8));
            order1.AddDetails(new OrderDetail(eggs, 10));
            order1.AddDetails(new OrderDetail(milk, 10));

            Order order2 = new Order(2, customer2);
            order2.AddDetails(new OrderDetail(eggs, 10));
            order2.AddDetails(new OrderDetail(milk, 10));

            Order order3 = new Order(3, customer2);
            order3.AddDetails(new OrderDetail(milk, 100));

 
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);

            update(orderService.QueryAll());
        }

        private void LastOrder_Click(object sender, EventArgs e)
        {
            i--;
            showOrder();
            
        }

        private void NextOrder_Click(object sender, EventArgs e)
        {
            i++;
            showOrder();
        }

        private void LastDetail_Click(object sender, EventArgs e)
        {
            j--;
            showDetail();
        }

        private void NextDetail_Click(object sender, EventArgs e)
        {
            j++;
            showDetail();
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            update(orderService.QueryAll());
        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.ShowDialog();
            showOrder();
        }

        private void ChangeOrder_Click(object sender, EventArgs e)
        {
            if (OrderId.Text == "" || CustomerId.Text == "" || CustomerName.Text == "" || GoodsId.Text == "" 
                || GoodsName.Text == "" || GoodsPrice.Text == "" || Quantity.Text == "")
            {
                MessageBox.Show("请输入完整信息!");
                return;
            }
            order.Details.ElementAt(j).Goods.Id = int.Parse(GoodsId.Text);
            order.Details.ElementAt(j).Goods.Name = GoodsName.Text;
            order.Details.ElementAt(j).Goods.Price = int.Parse(GoodsPrice.Text);
            order.Details.ElementAt(j).Quantity = int.Parse(Quantity.Text);
            orderService.Update(order);
            MessageBox.Show("修改成功!");
        }

        private void RemoveOrder_Click(object sender, EventArgs e)
        {
            orders.Remove(order);
            orderService.RemoveOrder(order.Id);
            ChangeOrder.Enabled = RemoveOrder.Enabled = (orders.Count > 0);
            showOrder();
        }

        private void GetById_Click(object sender, EventArgs e)
        {
            if(Id.Text=="")
            {
                MessageBox.Show("请输入完整信息!");
                return;
            }
            order=orderService.GetById(int.Parse(Id.Text));
            if(order==null)
            {
                MessageBox.Show("不存在满足要求的订单！");
                return;
            }
            orders.Clear();
            orders.Add(order);
            showOrder();
        }

        private void QueryByGoodsName_Click(object sender, EventArgs e)
        {
            if (Goods.Text == "")
            {
                MessageBox.Show("请输入完整信息!");
                return;
            }
            update(orderService.QueryByGoodsName(Goods.Text));
        }

        private void QueryByCustomerName_Click(object sender, EventArgs e)
        {
            if (Customer.Text == "")
            {
                MessageBox.Show("请输入完整信息!");
                return;
            }
            update(orderService.QueryByCustomerName(Customer.Text));
        }
    }
    
}
