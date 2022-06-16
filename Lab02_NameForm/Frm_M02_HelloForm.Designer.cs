
using System;
using System.Windows.Forms;

namespace Lab02_NameForm
{
    partial class Frm_M02_HelloForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_M02_HelloForm));
            this.LabName = new System.Windows.Forms.Label();
            this.ButName = new System.Windows.Forms.Button();
            this.TboxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabName
            // 
            this.LabName.AutoSize = true;
            this.LabName.BackColor = System.Drawing.SystemColors.Control;
            this.LabName.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabName.Location = new System.Drawing.Point(297, 547);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(57, 20);
            this.LabName.TabIndex = 0;
            this.LabName.Text = "姓名：";
            // 
            // ButName
            // 
            this.ButName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ButName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ButName.Location = new System.Drawing.Point(650, 536);
            this.ButName.Name = "ButName";
            this.ButName.Size = new System.Drawing.Size(113, 41);
            this.ButName.TabIndex = 1;
            this.ButName.Text = "Hello";
            this.ButName.UseVisualStyleBackColor = true;
            this.ButName.Click += new System.EventHandler(this.ButName_Click);
            // 
            // TboxName
            // 
            this.TboxName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TboxName.Location = new System.Drawing.Point(376, 544);
            this.TboxName.Name = "TboxName";
            this.TboxName.Size = new System.Drawing.Size(210, 29);
            this.TboxName.TabIndex = 2;
            // 
            // Frm_M02_HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(793, 598);
            this.Controls.Add(this.TboxName);
            this.Controls.Add(this.ButName);
            this.Controls.Add(this.LabName);
            this.Name = "Frm_M02_HelloForm";
            this.Text = "Name_Form";
            this.Load += new System.EventHandler(this.NameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabName;
        private System.Windows.Forms.Button ButName;
        private System.Windows.Forms.TextBox TboxName;
    }
}

