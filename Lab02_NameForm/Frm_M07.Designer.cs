
namespace Lab02_NameForm
{
    partial class Frm_M07
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
            this.Register01But = new System.Windows.Forms.Button();
            this.Register02But = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "建立初始化";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "註冊";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Register01But
            // 
            this.Register01But.Location = new System.Drawing.Point(12, 80);
            this.Register01But.Name = "Register01But";
            this.Register01But.Size = new System.Drawing.Size(123, 41);
            this.Register01But.TabIndex = 2;
            this.Register01But.Text = "Register01";
            this.Register01But.UseVisualStyleBackColor = true;
            // 
            // Register02But
            // 
            this.Register02But.Location = new System.Drawing.Point(12, 144);
            this.Register02But.Name = "Register02But";
            this.Register02But.Size = new System.Drawing.Size(123, 41);
            this.Register02But.TabIndex = 3;
            this.Register02But.Text = "Register02";
            this.Register02But.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 41);
            this.button4.TabIndex = 4;
            this.button4.Text = "取消註冊";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Frm_M07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 440);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Register02But);
            this.Controls.Add(this.Register01But);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Frm_M07";
            this.Text = "Frm_M07";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Register01But;
        private System.Windows.Forms.Button Register02But;
        private System.Windows.Forms.Button button4;
    }
}