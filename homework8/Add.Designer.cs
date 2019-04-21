namespace WindowsFormsApp1
{
    partial class Add
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
            this.Quantity = new System.Windows.Forms.TextBox();
            this.GoodsPrice = new System.Windows.Forms.TextBox();
            this.GoodsName = new System.Windows.Forms.TextBox();
            this.GoodsId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Sure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(82, 139);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(100, 21);
            this.Quantity.TabIndex = 48;
            // 
            // GoodsPrice
            // 
            this.GoodsPrice.Location = new System.Drawing.Point(123, 106);
            this.GoodsPrice.Name = "GoodsPrice";
            this.GoodsPrice.Size = new System.Drawing.Size(100, 21);
            this.GoodsPrice.TabIndex = 47;
            // 
            // GoodsName
            // 
            this.GoodsName.Location = new System.Drawing.Point(123, 63);
            this.GoodsName.Name = "GoodsName";
            this.GoodsName.Size = new System.Drawing.Size(100, 21);
            this.GoodsName.TabIndex = 46;
            // 
            // GoodsId
            // 
            this.GoodsId.Location = new System.Drawing.Point(123, 27);
            this.GoodsId.Name = "GoodsId";
            this.GoodsId.Size = new System.Drawing.Size(100, 21);
            this.GoodsId.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 44;
            this.label11.Text = "购买数量";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 43;
            this.label10.Text = "货物单价";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 42;
            this.label9.Text = "货物名称";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 41;
            this.label8.Text = "货物Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 40;
            this.label7.Text = "货物信息";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(148, 184);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 50;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Sure
            // 
            this.Sure.Location = new System.Drawing.Point(14, 184);
            this.Sure.Name = "Sure";
            this.Sure.Size = new System.Drawing.Size(75, 23);
            this.Sure.TabIndex = 49;
            this.Sure.Text = "确认";
            this.Sure.UseVisualStyleBackColor = true;
            this.Sure.Click += new System.EventHandler(this.Sure_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 228);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Sure);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.GoodsPrice);
            this.Controls.Add(this.GoodsName);
            this.Controls.Add(this.GoodsId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "Add";
            this.Text = "添加订单明细";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox GoodsPrice;
        private System.Windows.Forms.TextBox GoodsName;
        private System.Windows.Forms.TextBox GoodsId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Sure;
    }
}