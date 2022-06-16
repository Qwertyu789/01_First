
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
            this.SuspendLayout();
            // 
            // OpnHelloForm
            // 
            this.OpnHelloForm.Location = new System.Drawing.Point(476, 102);
            this.OpnHelloForm.Name = "OpnHelloForm";
            this.OpnHelloForm.Size = new System.Drawing.Size(229, 66);
            this.OpnHelloForm.TabIndex = 0;
            this.OpnHelloForm.Text = "Open Hello Form";
            this.OpnHelloForm.UseVisualStyleBackColor = true;
            this.OpnHelloForm.Click += new System.EventHandler(this.OpnHelloForm_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "My First Method";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_M04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OpnHelloForm);
            this.Name = "Frm_M04";
            this.Text = "Frm_M04";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpnHelloForm;
        private System.Windows.Forms.Button button1;
    }
}