namespace versie_0._2
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Zoeken = new System.Windows.Forms.Button();
            this.textbalk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(344, 573);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(344, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(956, 573);
            this.webBrowser1.TabIndex = 1;
            // 
            // Zoeken
            // 
            this.Zoeken.Location = new System.Drawing.Point(125, 107);
            this.Zoeken.Name = "Zoeken";
            this.Zoeken.Size = new System.Drawing.Size(75, 23);
            this.Zoeken.TabIndex = 2;
            this.Zoeken.Text = "Zoeken";
            this.Zoeken.UseVisualStyleBackColor = true;
            this.Zoeken.Click += new System.EventHandler(this.Zoeken_Click);
            // 
            // textbalk
            // 
            this.textbalk.Location = new System.Drawing.Point(86, 64);
            this.textbalk.Name = "textbalk";
            this.textbalk.Size = new System.Drawing.Size(167, 22);
            this.textbalk.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 573);
            this.Controls.Add(this.textbalk);
            this.Controls.Add(this.Zoeken);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button Zoeken;
        private System.Windows.Forms.TextBox textbalk;
    }
}

