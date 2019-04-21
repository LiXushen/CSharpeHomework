namespace WindowsFormsApp1
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.OrderId = new System.Windows.Forms.TextBox();
            this.CustomerId = new System.Windows.Forms.TextBox();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.GoodsId = new System.Windows.Forms.TextBox();
            this.GoodsName = new System.Windows.Forms.TextBox();
            this.GoodsPrice = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.LastOrder = new System.Windows.Forms.Button();
            this.NextOrder = new System.Windows.Forms.Button();
            this.LastDetail = new System.Windows.Forms.Button();
            this.NextDetail = new System.Windows.Forms.Button();
            this.AddOrder = new System.Windows.Forms.Button();
            this.ChangeOrder = new System.Windows.Forms.Button();
            this.GetById = new System.Windows.Forms.Button();
            this.RemoveOrder = new System.Windows.Forms.Button();
            this.QueryByGoodsName = new System.Windows.Forms.Button();
            this.QueryByCustomerName = new System.Windows.Forms.Button();
            this.ShowAll = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.TextBox();
            this.Goods = new System.Windows.Forms.TextBox();
            this.Customer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "订单Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "顾客信息";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "顾客Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "顾客姓名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "购选信息";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "货物信息";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "货物Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(189, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "货物名称";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(189, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "货物单价";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(132, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "购买数量";
            // 
            // OrderId
            // 
            this.OrderId.Location = new System.Drawing.Point(142, 34);
            this.OrderId.Name = "OrderId";
            this.OrderId.Size = new System.Drawing.Size(100, 21);
            this.OrderId.TabIndex = 11;
            // 
            // CustomerId
            // 
            this.CustomerId.Location = new System.Drawing.Point(203, 88);
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Size = new System.Drawing.Size(100, 21);
            this.CustomerId.TabIndex = 12;
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(203, 124);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(100, 21);
            this.CustomerName.TabIndex = 13;
            // 
            // GoodsId
            // 
            this.GoodsId.Location = new System.Drawing.Point(258, 205);
            this.GoodsId.Name = "GoodsId";
            this.GoodsId.Size = new System.Drawing.Size(100, 21);
            this.GoodsId.TabIndex = 14;
            // 
            // GoodsName
            // 
            this.GoodsName.Location = new System.Drawing.Point(258, 243);
            this.GoodsName.Name = "GoodsName";
            this.GoodsName.Size = new System.Drawing.Size(100, 21);
            this.GoodsName.TabIndex = 15;
            // 
            // GoodsPrice
            // 
            this.GoodsPrice.Location = new System.Drawing.Point(258, 277);
            this.GoodsPrice.Name = "GoodsPrice";
            this.GoodsPrice.Size = new System.Drawing.Size(100, 21);
            this.GoodsPrice.TabIndex = 16;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(203, 310);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(100, 21);
            this.Quantity.TabIndex = 17;
            // 
            // LastOrder
            // 
            this.LastOrder.Location = new System.Drawing.Point(97, 5);
            this.LastOrder.Name = "LastOrder";
            this.LastOrder.Size = new System.Drawing.Size(75, 23);
            this.LastOrder.TabIndex = 18;
            this.LastOrder.Text = "上一个";
            this.LastOrder.UseVisualStyleBackColor = true;
            this.LastOrder.Click += new System.EventHandler(this.LastOrder_Click);
            // 
            // NextOrder
            // 
            this.NextOrder.Location = new System.Drawing.Point(203, 5);
            this.NextOrder.Name = "NextOrder";
            this.NextOrder.Size = new System.Drawing.Size(75, 23);
            this.NextOrder.TabIndex = 19;
            this.NextOrder.Text = "下一个";
            this.NextOrder.UseVisualStyleBackColor = true;
            this.NextOrder.Click += new System.EventHandler(this.NextOrder_Click);
            // 
            // LastDetail
            // 
            this.LastDetail.Location = new System.Drawing.Point(142, 152);
            this.LastDetail.Name = "LastDetail";
            this.LastDetail.Size = new System.Drawing.Size(75, 23);
            this.LastDetail.TabIndex = 20;
            this.LastDetail.Text = "上一个";
            this.LastDetail.UseVisualStyleBackColor = true;
            this.LastDetail.Click += new System.EventHandler(this.LastDetail_Click);
            // 
            // NextDetail
            // 
            this.NextDetail.Location = new System.Drawing.Point(267, 152);
            this.NextDetail.Name = "NextDetail";
            this.NextDetail.Size = new System.Drawing.Size(75, 23);
            this.NextDetail.TabIndex = 21;
            this.NextDetail.Text = "下一个";
            this.NextDetail.UseVisualStyleBackColor = true;
            this.NextDetail.Click += new System.EventHandler(this.NextDetail_Click);
            // 
            // AddOrder
            // 
            this.AddOrder.Location = new System.Drawing.Point(404, 54);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(146, 23);
            this.AddOrder.TabIndex = 22;
            this.AddOrder.Text = "添加订单";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // ChangeOrder
            // 
            this.ChangeOrder.Location = new System.Drawing.Point(404, 104);
            this.ChangeOrder.Name = "ChangeOrder";
            this.ChangeOrder.Size = new System.Drawing.Size(146, 23);
            this.ChangeOrder.TabIndex = 23;
            this.ChangeOrder.Text = "确认修改";
            this.ChangeOrder.UseVisualStyleBackColor = true;
            this.ChangeOrder.Click += new System.EventHandler(this.ChangeOrder_Click);
            // 
            // GetById
            // 
            this.GetById.Location = new System.Drawing.Point(404, 208);
            this.GetById.Name = "GetById";
            this.GetById.Size = new System.Drawing.Size(146, 23);
            this.GetById.TabIndex = 24;
            this.GetById.Text = "根据订单Id查询";
            this.GetById.UseVisualStyleBackColor = true;
            this.GetById.Click += new System.EventHandler(this.GetById_Click);
            // 
            // RemoveOrder
            // 
            this.RemoveOrder.Location = new System.Drawing.Point(404, 157);
            this.RemoveOrder.Name = "RemoveOrder";
            this.RemoveOrder.Size = new System.Drawing.Size(146, 23);
            this.RemoveOrder.TabIndex = 25;
            this.RemoveOrder.Text = "删除本订单";
            this.RemoveOrder.UseVisualStyleBackColor = true;
            this.RemoveOrder.Click += new System.EventHandler(this.RemoveOrder_Click);
            // 
            // QueryByGoodsName
            // 
            this.QueryByGoodsName.Location = new System.Drawing.Point(404, 258);
            this.QueryByGoodsName.Name = "QueryByGoodsName";
            this.QueryByGoodsName.Size = new System.Drawing.Size(146, 23);
            this.QueryByGoodsName.TabIndex = 26;
            this.QueryByGoodsName.Text = "根据货物名称查询";
            this.QueryByGoodsName.UseVisualStyleBackColor = true;
            this.QueryByGoodsName.Click += new System.EventHandler(this.QueryByGoodsName_Click);
            // 
            // QueryByCustomerName
            // 
            this.QueryByCustomerName.Location = new System.Drawing.Point(404, 310);
            this.QueryByCustomerName.Name = "QueryByCustomerName";
            this.QueryByCustomerName.Size = new System.Drawing.Size(146, 23);
            this.QueryByCustomerName.TabIndex = 27;
            this.QueryByCustomerName.Text = "根据客户姓名查询";
            this.QueryByCustomerName.UseVisualStyleBackColor = true;
            this.QueryByCustomerName.Click += new System.EventHandler(this.QueryByCustomerName_Click);
            // 
            // ShowAll
            // 
            this.ShowAll.Location = new System.Drawing.Point(404, 9);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(146, 23);
            this.ShowAll.TabIndex = 29;
            this.ShowAll.Text = "显示全部订单";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(576, 210);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(100, 21);
            this.Id.TabIndex = 30;
            // 
            // Goods
            // 
            this.Goods.Location = new System.Drawing.Point(576, 260);
            this.Goods.Name = "Goods";
            this.Goods.Size = new System.Drawing.Size(100, 21);
            this.Goods.TabIndex = 31;
            // 
            // Customer
            // 
            this.Customer.Location = new System.Drawing.Point(576, 310);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(100, 21);
            this.Customer.TabIndex = 32;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 346);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.Goods);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.ShowAll);
            this.Controls.Add(this.QueryByCustomerName);
            this.Controls.Add(this.QueryByGoodsName);
            this.Controls.Add(this.RemoveOrder);
            this.Controls.Add(this.GetById);
            this.Controls.Add(this.ChangeOrder);
            this.Controls.Add(this.AddOrder);
            this.Controls.Add(this.NextDetail);
            this.Controls.Add(this.LastDetail);
            this.Controls.Add(this.NextOrder);
            this.Controls.Add(this.LastOrder);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.GoodsPrice);
            this.Controls.Add(this.GoodsName);
            this.Controls.Add(this.GoodsId);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.CustomerId);
            this.Controls.Add(this.OrderId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "订单管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox OrderId;
        private System.Windows.Forms.TextBox CustomerId;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.TextBox GoodsId;
        private System.Windows.Forms.TextBox GoodsName;
        private System.Windows.Forms.TextBox GoodsPrice;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Button LastOrder;
        private System.Windows.Forms.Button NextOrder;
        private System.Windows.Forms.Button LastDetail;
        private System.Windows.Forms.Button NextDetail;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.Button ChangeOrder;
        private System.Windows.Forms.Button GetById;
        private System.Windows.Forms.Button RemoveOrder;
        private System.Windows.Forms.Button QueryByGoodsName;
        private System.Windows.Forms.Button QueryByCustomerName;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.TextBox Goods;
        private System.Windows.Forms.TextBox Customer;
    }
}

