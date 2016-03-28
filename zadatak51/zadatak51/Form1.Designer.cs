namespace zadatak51
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
            this.T1 = new System.Windows.Forms.TextBox();
            this.T2 = new System.Windows.Forms.TextBox();
            this.T3 = new System.Windows.Forms.TextBox();
            this.T4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // T1
            // 
            this.T1.Location = new System.Drawing.Point(220, 84);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(100, 31);
            this.T1.TabIndex = 0;
            // 
            // T2
            // 
            this.T2.Location = new System.Drawing.Point(220, 136);
            this.T2.Name = "T2";
            this.T2.Size = new System.Drawing.Size(100, 31);
            this.T2.TabIndex = 1;
            // 
            // T3
            // 
            this.T3.Location = new System.Drawing.Point(220, 189);
            this.T3.Name = "T3";
            this.T3.Size = new System.Drawing.Size(100, 31);
            this.T3.TabIndex = 2;
            // 
            // T4
            // 
            this.T4.Location = new System.Drawing.Point(220, 249);
            this.T4.Name = "T4";
            this.T4.Size = new System.Drawing.Size(100, 31);
            this.T4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 561);
            this.Controls.Add(this.T4);
            this.Controls.Add(this.T3);
            this.Controls.Add(this.T2);
            this.Controls.Add(this.T1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox T1;
        private System.Windows.Forms.TextBox T2;
        private System.Windows.Forms.TextBox T3;
        private System.Windows.Forms.TextBox T4;
    }
}

