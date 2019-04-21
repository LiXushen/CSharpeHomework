namespace WindowsFormsApp1
{
    partial class Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NextDetail = new System.Windows.Forms.Button();
            this.LastDetail = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.GoodsPrice = new System.Windows.Forms.TextBox();
            this.GoodsName = new System.Windows.Forms.TextBox();
            this.GoodsId = new System.Windows.Forms.TextBox();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.CustomerId = new System.Windows.Forms.TextBox();
            this.OrderId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Sure = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.ChangeDetail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NextDetail
            // 
            this.NextDetail.Location = new System.Drawing.Point(180, 113);
            this.NextDetail.Name = "NextDetail";
            this.NextDetail.Size = new System.Drawing.Size(75, 23);
            this.NextDetail.TabIndex = 43;
            this.NextDetail.Text = "下一个";
            this.NextDetail.UseVisualStyleBackColor = true;
            this.NextDetail.Click += new System.EventHandler(this.NextDetail_Click);
            // 
            // LastDetail
            // 
            this.LastDetail.Location = new System.Drawing.Point(96, 113);
            this.LastDetail.Name = "LastDetail";
            this.LastDetail.Size = new System.Drawing.Size(75, 23);
            this.LastDetail.TabIndex = 42;
            this.LastDetail.Text = "上一个";
            this.LastDetail.UseVisualStyleBackColor = true;
            this.LastDetail.Click += new System.EventHandler(this.LastDetail_Click);
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(155, 282);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(100, 21);
            this.Quantity.TabIndex = 39;
            // 
            // GoodsPrice
            // 
            this.GoodsPrice.Location = new System.Drawing.Point(212, 251);
            this.GoodsPrice.Name = "GoodsPrice";
            this.GoodsPrice.Size = new System.Drawing.Size(100, 21);
            this.GoodsPrice.TabIndex = 38;
            // 
            // GoodsName
            // 
            this.GoodsName.Location = new System.Drawing.Point(212, 212);
            this.GoodsName.Name = "GoodsName";
            this.GoodsName.Size = new System.Drawing.Size(100, 21);
            this.GoodsName.TabIndex = 37;
            // 
            // GoodsId
            // 
            this.GoodsId.Location = new System.Drawing.Point(212, 172);
            this.GoodsId.Name = "GoodsId";
            this.GoodsId.Size = new System.Drawing.Size(100, 21);
            this.GoodsId.TabIndex = 36;
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(155, 80);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(100, 21);
            this.CustomerName.TabIndex = 35;
            // 
            // CustomerId
            // 
            this.CustomerId.Location = new System.Drawing.Point(155, 46);
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Size = new System.Drawing.Size(100, 21);
            this.CustomerId.TabIndex = 34;
            // 
            // OrderId
            // 
            this.OrderId.Location = new System.Drawing.Point(106, 7);
            this.OrderId.Name = "OrderId";
            this.OrderId.Size = new System.Drawing.Size(100, 21);
            this.OrderId.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(93, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 32;
            this.label11.Text = "购买数量";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(153, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 31;
            this.label10.Text = "货物单价";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(153, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 30;
            this.label9.Text = "货物名称";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(153, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "货物Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 28;
            this.label7.Text = "货物信息";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "购选信息";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "顾客姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "顾客Id";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 24;
            this.label12.Text = "顾客信息";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 23;
            this.label13.Text = "订单Id";
            // 
            // Sure
            // 
            this.Sure.Location = new System.Drawing.Point(51, 315);
            this.Sure.Name = "Sure";
            this.Sure.Size = new System.Drawing.Size(75, 23);
            this.Sure.TabIndex = 44;
            this.Sure.Text = "确认";
            this.Sure.UseVisualStyleBackColor = true;
            this.Sure.Click += new System.EventHandler(this.Sure_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(212, 315);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 45;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(347, 215);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 46;
            this.Remove.Text = "删除";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(347, 118);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 47;
            this.Add.Text = "添加";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ChangeDetail
            // 
            this.ChangeDetail.Location = new System.Drawing.Point(347, 172);
            this.ChangeDetail.Name = "ChangeDetail";
            this.ChangeDetail.Size = new System.Drawing.Size(75, 23);
            this.ChangeDetail.TabIndex = 48;
            this.ChangeDetail.Text = "确认修改";
            this.ChangeDetail.UseVisualStyleBackColor = true;
            this.ChangeDetail.Click += new System.EventHandler(this.ChangeDetail_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 343);
            this.Controls.Add(this.ChangeDetail);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Sure);
            this.Controls.Add(this.NextDetail);
            this.Controls.Add(this.LastDetail);
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
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Name = "Edit";
            this.Text = "订单信息";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextDetail;
        private System.Windows.Forms.Button LastDetail;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox GoodsPrice;
        private System.Windows.Forms.TextBox GoodsName;
        private System.Windows.Forms.TextBox GoodsId;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.TextBox CustomerId;
        private System.Windows.Forms.TextBox OrderId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Sure;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button ChangeDetail;
    }
}