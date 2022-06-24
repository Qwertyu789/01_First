
namespace Lab02_NameForm
{
    partial class Frm_M20
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
            this.butIf = new System.Windows.Forms.Button();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.lbGrade = new System.Windows.Forms.Label();
            this.btnCase = new System.Windows.Forms.Button();
            this.butWhile = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.butForLoop = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "!!!!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "屁眼派對";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // butIf
            // 
            this.butIf.Location = new System.Drawing.Point(247, 221);
            this.butIf.Name = "butIf";
            this.butIf.Size = new System.Drawing.Size(167, 34);
            this.butIf.TabIndex = 2;
            this.butIf.Text = "Push";
            this.butIf.UseVisualStyleBackColor = true;
            this.butIf.Click += new System.EventHandler(this.butScore_Click);
            // 
            // tbScore
            // 
            this.tbScore.Location = new System.Drawing.Point(247, 184);
            this.tbScore.Name = "tbScore";
            this.tbScore.Size = new System.Drawing.Size(167, 22);
            this.tbScore.TabIndex = 3;
            // 
            // lbGrade
            // 
            this.lbGrade.AutoSize = true;
            this.lbGrade.Location = new System.Drawing.Point(429, 187);
            this.lbGrade.Name = "lbGrade";
            this.lbGrade.Size = new System.Drawing.Size(33, 12);
            this.lbGrade.TabIndex = 4;
            this.lbGrade.Text = "label1";
            // 
            // btnCase
            // 
            this.btnCase.Location = new System.Drawing.Point(247, 261);
            this.btnCase.Name = "btnCase";
            this.btnCase.Size = new System.Drawing.Size(167, 34);
            this.btnCase.TabIndex = 5;
            this.btnCase.Text = "date";
            this.btnCase.UseVisualStyleBackColor = true;
            this.btnCase.Click += new System.EventHandler(this.btnCase_Click);
            // 
            // butWhile
            // 
            this.butWhile.Location = new System.Drawing.Point(535, 187);
            this.butWhile.Name = "butWhile";
            this.butWhile.Size = new System.Drawing.Size(167, 34);
            this.butWhile.TabIndex = 6;
            this.butWhile.Text = "While loop";
            this.butWhile.UseVisualStyleBackColor = true;
            this.butWhile.Click += new System.EventHandler(this.butWhile_Click);
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(535, 228);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(167, 34);
            this.btnDo.TabIndex = 7;
            this.btnDo.Text = "Do loop";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // butForLoop
            // 
            this.butForLoop.Font = new System.Drawing.Font("細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butForLoop.Location = new System.Drawing.Point(535, 268);
            this.butForLoop.Name = "butForLoop";
            this.butForLoop.Size = new System.Drawing.Size(167, 34);
            this.butForLoop.TabIndex = 8;
            this.butForLoop.Text = "For loop";
            this.butForLoop.UseVisualStyleBackColor = true;
            this.butForLoop.Click += new System.EventHandler(this.butForLoop_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(621, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 34);
            this.button3.TabIndex = 9;
            this.button3.Text = "Foeach";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Frm_M20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.butForLoop);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.butWhile);
            this.Controls.Add(this.btnCase);
            this.Controls.Add(this.lbGrade);
            this.Controls.Add(this.tbScore);
            this.Controls.Add(this.butIf);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Frm_M20";
            this.Text = "Frm_M20";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button butIf;
        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.Label lbGrade;
        private System.Windows.Forms.Button btnCase;
        private System.Windows.Forms.Button butWhile;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button butForLoop;
        private System.Windows.Forms.Button button3;
    }
}