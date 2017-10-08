namespace LamKimQuan_Bai2
{
    partial class Form1
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
            this.lbmess = new System.Windows.Forms.ListBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.txtmess = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbmess
            // 
            this.lbmess.FormattingEnabled = true;
            this.lbmess.Location = new System.Drawing.Point(101, 68);
            this.lbmess.Name = "lbmess";
            this.lbmess.Size = new System.Drawing.Size(269, 121);
            this.lbmess.TabIndex = 3;
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(295, 239);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(75, 23);
            this.btnsend.TabIndex = 5;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // txtmess
            // 
            this.txtmess.Location = new System.Drawing.Point(101, 239);
            this.txtmess.Name = "txtmess";
            this.txtmess.Size = new System.Drawing.Size(167, 20);
            this.txtmess.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 291);
            this.Controls.Add(this.txtmess);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.lbmess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbmess;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.TextBox txtmess;
    }
}

