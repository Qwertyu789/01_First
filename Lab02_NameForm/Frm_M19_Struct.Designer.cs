
namespace Lab02_NameForm
{
    partial class Frm_M19_Struct
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labName = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.labProduct = new System.Windows.Forms.Label();
            this.labInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "push";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(16, 65);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(75, 27);
            this.labName.TabIndex = 2;
            this.labName.Text = "名稱：";
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPrice.Location = new System.Drawing.Point(16, 133);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(75, 27);
            this.labPrice.TabIndex = 3;
            this.labPrice.Text = "價格：";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbName.Location = new System.Drawing.Point(111, 68);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(152, 30);
            this.tbName.TabIndex = 4;
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbPrice.Location = new System.Drawing.Point(111, 133);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(152, 30);
            this.tbPrice.TabIndex = 5;
            // 
            // labProduct
            // 
            this.labProduct.AutoSize = true;
            this.labProduct.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labProduct.Location = new System.Drawing.Point(290, 9);
            this.labProduct.Name = "labProduct";
            this.labProduct.Size = new System.Drawing.Size(105, 24);
            this.labProduct.TabIndex = 6;
            this.labProduct.Text = "產品一覽：";
            // 
            // labInfo
            // 
            this.labInfo.AutoSize = true;
            this.labInfo.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labInfo.Location = new System.Drawing.Point(2, 282);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(61, 30);
            this.labInfo.TabIndex = 7;
            this.labInfo.Text = "總覽";
            // 
            // Frm_M19_Struct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labInfo);
            this.Controls.Add(this.labProduct);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.labPrice);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Frm_M19_Struct";
            this.Text = "Frm_M19_Struct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label labProduct;
        private System.Windows.Forms.Label labInfo;
    }
}