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
    public partial class Edit : Form
    {
        public static int j = 0;
        public static Order order = new Order();
        public static OrderDetail detail;

        public Edit()
        {
            InitializeComponent();
        }

        public void showDetail()
        {
            if (j == order.Details.Count) j--;
            LastDetail.Enabled = !(j == 0);
            NextDetail.Enabled = !(j == order.Details.Count - 1);
            if (order.Details.Count==0)
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

        private void Edit_Load(object sender, EventArgs e)
        {
            LastDetail.Enabled = false;
            NextDetail.Enabled = false;
            Remove.Enabled = false;
            ChangeDetail.Enabled = false;
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

        private void Add_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
            ChangeDetail.Enabled=Remove.Enabled = (order.Details.Count > 0);
            showDetail();
        }
        
        private void ChangeDetail_Click(object sender, EventArgs e)
        {
            if (GoodsId.Text == "" || GoodsName.Text == "" || GoodsPrice.Text == "" || Quantity.Text == "")
            {
                MessageBox.Show("请输入完整信息!");
                return;
            }
            order.Details.ElementAt(j).Goods.Id = int.Parse(GoodsId.Text);
            order.Details.ElementAt(j).Goods.Name = GoodsName.Text;
            order.Details.ElementAt(j).Goods.Price = int.Parse(GoodsPrice.Text);
            order.Details.ElementAt(j).Quantity = int.Parse(Quantity.Text);
            MessageBox.Show("修改成功!");
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            order.Details.Remove(detail);
            ChangeDetail.Enabled=Remove.Enabled = (order.Details.Count > 0);
            showDetail();
        }

        private void Sure_Click(object sender, EventArgs e)
        {
            if (OrderId.Text == "" || CustomerId.Text == "" || CustomerName.Text == "")
            {
                MessageBox.Show("请输入完整信息!");
                return;
            }
            if (order.Details.Count == 0)
            {
                MessageBox.Show("请添加订单明细!");
                return;
            }
            order.Id = int.Parse(OrderId.Text);
            Customer customer = new Customer();
            customer.Id = int.Parse(CustomerId.Text);
            customer.Name = CustomerName.Text;
            order.Customer = customer;
            try
            {
                Main.orderService.AddOrder(order);
            }
            catch (Exception)
            {
                MessageBox.Show("订单Id重复!");
                return;
            }
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
