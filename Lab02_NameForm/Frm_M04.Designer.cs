
namespace Lab02_NameForm
{
    partial class Frm_M04
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
            this.OpnHelloForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.classmethod = new System.Windows.Forms.Button();
            this.BirdayBut = new System.Windows.Forms.Button();
            this.BirthYearTB = new System.Windows.Forms.TextBox();
            this.AgeLB = new System.Windows.Forms.Label();
            this.ESTestBut = new System.Windows.Forms.Button();
            this.PartialBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpnHelloForm
            // 
            this.OpnHelloForm.Location = new System.Drawing.Point(512, 12);
            this.OpnHelloForm.Name = "OpnHelloForm";
            this.OpnHelloForm.Size = new System.Drawing.Size(229, 66);
            this.OpnHelloForm.TabIndex = 0;
            this.OpnHelloForm.Text = "Open Hello Form";
            this.OpnHelloForm.UseVisualStyleBackColor = true;
            this.OpnHelloForm.Click += new System.EventHandler(this.OpnHelloForm_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "My First Method";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // classmethod
            // 
            this.classmethod.Location = new System.Drawing.Point(512, 158);
            this.classmethod.Name = "classmethod";
            this.classmethod.Size = new System.Drawing.Size(229, 66);
            this.classmethod.TabIndex = 2;
            this.classmethod.Text = "ClassMethod";
            this.classmethod.UseVisualStyleBackColor = true;
            this.classmethod.Click += new System.EventHandler(this.classmethod_Click);
            // 
            // BirdayBut
            // 
            this.BirdayBut.Location = new System.Drawing.Point(512, 230);
            this.BirdayBut.Name = "BirdayBut";
            this.BirdayBut.Size = new System.Drawing.Size(229, 66);
            this.BirdayBut.TabIndex = 3;
            this.BirdayBut.Text = "出生年";
            this.BirdayBut.UseVisualStyleBackColor = true;
            this.BirdayBut.Click += new System.EventHandler(this.BirdayBut_Click);
            // 
            // BirthYearTB
            // 
            this.BirthYearTB.Location = new System.Drawing.Point(473, 254);
            this.BirthYearTB.Name = "BirthYearTB";
            this.BirthYearTB.Size = new System.Drawing.Size(33, 22);
            this.BirthYearTB.TabIndex = 4;
            // 
            // AgeLB
            // 
            this.AgeLB.AutoSize = true;
            this.AgeLB.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AgeLB.Location = new System.Drawing.Point(393, 255);
            this.AgeLB.Name = "AgeLB";
            this.AgeLB.Size = new System.Drawing.Size(74, 21);
            this.AgeLB.TabIndex = 5;
            this.AgeLB.Text = "現在年齡";
            // 
            // ESTestBut
            // 
            this.ESTestBut.Location = new System.Drawing.Point(512, 302);
            this.ESTestBut.Name = "ESTestBut";
            this.ESTestBut.Size = new System.Drawing.Size(229, 66);
            this.ESTestBut.TabIndex = 6;
            this.ESTestBut.Text = "封裝測試";
            this.ESTestBut.UseVisualStyleBackColor = true;
            this.ESTestBut.Click += new System.EventHandler(this.ESTestBut_Click);
            // 
            // PartialBut
            // 
            this.PartialBut.Location = new System.Drawing.Point(512, 374);
            this.PartialBut.Name = "PartialBut";
            this.PartialBut.Size = new System.Drawing.Size(229, 66);
            this.PartialBut.TabIndex = 7;
            this.PartialBut.Text = "Partial Class";
            this.PartialBut.UseVisualStyleBackColor = true;
            this.PartialBut.Click += new System.EventHandler(this.PartialBut_Click);
            // 
            // Frm_M04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PartialBut);
            this.Controls.Add(this.ESTestBut);
            this.Controls.Add(this.AgeLB);
            this.Controls.Add(this.BirthYearTB);
            this.Controls.Add(this.BirdayBut);
            this.Controls.Add(this.classmethod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OpnHelloForm);
            this.Name = "Frm_M04";
            this.Text = "Frm_M04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpnHelloForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button classmethod;
        private System.Windows.Forms.Button BirdayBut;
        private System.Windows.Forms.TextBox BirthYearTB;
        private System.Windows.Forms.Label AgeLB;
        private System.Windows.Forms.Button ESTestBut;
        private System.Windows.Forms.Button PartialBut;
    }
}