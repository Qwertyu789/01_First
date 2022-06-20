
namespace Lab02_NameForm
{
    partial class Frm_M12
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
            this.CounterLB = new System.Windows.Forms.Label();
            this.CounterBtn = new System.Windows.Forms.Button();
            this.frontadd = new System.Windows.Forms.Button();
            this.backadd = new System.Windows.Forms.Button();
            this.localvar1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.InstanceCountLB = new System.Windows.Forms.Label();
            this.StaticCountLB = new System.Windows.Forms.Label();
            this.FrmHelloCallBut = new System.Windows.Forms.Button();
            this.localvar1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CounterLB
            // 
            this.CounterLB.AutoSize = true;
            this.CounterLB.Location = new System.Drawing.Point(21, 9);
            this.CounterLB.Name = "CounterLB";
            this.CounterLB.Size = new System.Drawing.Size(52, 12);
            this.CounterLB.TabIndex = 0;
            this.CounterLB.Text = "Count：0";
            // 
            // CounterBtn
            // 
            this.CounterBtn.Location = new System.Drawing.Point(12, 24);
            this.CounterBtn.Name = "CounterBtn";
            this.CounterBtn.Size = new System.Drawing.Size(94, 35);
            this.CounterBtn.TabIndex = 1;
            this.CounterBtn.Text = "+=-=";
            this.CounterBtn.UseVisualStyleBackColor = true;
            this.CounterBtn.Click += new System.EventHandler(this.CounterBtn_Click);
            // 
            // frontadd
            // 
            this.frontadd.Location = new System.Drawing.Point(12, 65);
            this.frontadd.Name = "frontadd";
            this.frontadd.Size = new System.Drawing.Size(94, 35);
            this.frontadd.TabIndex = 2;
            this.frontadd.Text = "a++";
            this.frontadd.UseVisualStyleBackColor = true;
            this.frontadd.Click += new System.EventHandler(this.frontadd_Click);
            // 
            // backadd
            // 
            this.backadd.Location = new System.Drawing.Point(12, 106);
            this.backadd.Name = "backadd";
            this.backadd.Size = new System.Drawing.Size(94, 35);
            this.backadd.TabIndex = 3;
            this.backadd.Text = "++a";
            this.backadd.UseVisualStyleBackColor = true;
            this.backadd.Click += new System.EventHandler(this.backadd_Click);
            // 
            // localvar1
            // 
            this.localvar1.Controls.Add(this.button2);
            this.localvar1.Controls.Add(this.button1);
            this.localvar1.Location = new System.Drawing.Point(185, 24);
            this.localvar1.Name = "localvar1";
            this.localvar1.Size = new System.Drawing.Size(200, 130);
            this.localvar1.TabIndex = 4;
            this.localvar1.TabStop = false;
            this.localvar1.Text = "Local Variable";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Var";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Local Var";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(185, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 108);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "static";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(45, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Static Count";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(45, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Instance Count";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // InstanceCountLB
            // 
            this.InstanceCountLB.AutoSize = true;
            this.InstanceCountLB.Location = new System.Drawing.Point(359, 211);
            this.InstanceCountLB.Name = "InstanceCountLB";
            this.InstanceCountLB.Size = new System.Drawing.Size(93, 12);
            this.InstanceCountLB.TabIndex = 6;
            this.InstanceCountLB.Text = "Instance Count：0";
            // 
            // StaticCountLB
            // 
            this.StaticCountLB.AutoSize = true;
            this.StaticCountLB.Location = new System.Drawing.Point(372, 250);
            this.StaticCountLB.Name = "StaticCountLB";
            this.StaticCountLB.Size = new System.Drawing.Size(80, 12);
            this.StaticCountLB.TabIndex = 7;
            this.StaticCountLB.Text = "Static Count：0";
            // 
            // FrmHelloCallBut
            // 
            this.FrmHelloCallBut.AutoSize = true;
            this.FrmHelloCallBut.Location = new System.Drawing.Point(229, 283);
            this.FrmHelloCallBut.Name = "FrmHelloCallBut";
            this.FrmHelloCallBut.Size = new System.Drawing.Size(94, 22);
            this.FrmHelloCallBut.TabIndex = 8;
            this.FrmHelloCallBut.Text = "HelloForm";
            this.FrmHelloCallBut.UseVisualStyleBackColor = true;
            this.FrmHelloCallBut.Click += new System.EventHandler(this.FrmHelloCallBut_Click);
            // 
            // Frm_M12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 311);
            this.Controls.Add(this.FrmHelloCallBut);
            this.Controls.Add(this.StaticCountLB);
            this.Controls.Add(this.InstanceCountLB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.localvar1);
            this.Controls.Add(this.backadd);
            this.Controls.Add(this.frontadd);
            this.Controls.Add(this.CounterBtn);
            this.Controls.Add(this.CounterLB);
            this.Name = "Frm_M12";
            this.Text = "Frm_M12";
            this.localvar1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CounterLB;
        private System.Windows.Forms.Button CounterBtn;
        private System.Windows.Forms.Button frontadd;
        private System.Windows.Forms.Button backadd;
        private System.Windows.Forms.GroupBox localvar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label InstanceCountLB;
        private System.Windows.Forms.Label StaticCountLB;
        private System.Windows.Forms.Button FrmHelloCallBut;
    }
}