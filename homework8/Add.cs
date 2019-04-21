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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Sure_Click(object sender, EventArgs e)
        {
            if (GoodsId.Text == "" || GoodsName.Text == "" || GoodsPrice.Text == "" || Quantity.Text == "")
            {
                MessageBox.Show("请输入完整信息!");
                return;
            }
            OrderDetail detail = new OrderDetail();
            Goods goods= new Goods();
            goods.Id = int.Parse(GoodsId.Text);
            goods.Name = GoodsName.Text;
            goods.Price = int.Parse(GoodsPrice.Text);
            detail.Goods = goods;
            detail.Quantity = int.Parse(Quantity.Text);
            Edit.order.Details.Add(detail);
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
