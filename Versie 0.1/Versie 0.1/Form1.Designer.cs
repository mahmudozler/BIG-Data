namespace Versie_0._1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Resetmap = new System.Windows.Forms.Button();
            this.zoomin = new System.Windows.Forms.Button();
            this.Zoomout = new System.Windows.Forms.Button();
            this.Security = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(307, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1022, 547);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wijknaam";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Zoeken";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1019, 544);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(307, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 547);
            this.panel1.TabIndex = 9;
            // 
            // Resetmap
            // 
            this.Resetmap.Location = new System.Drawing.Point(112, 317);
            this.Resetmap.Name = "Resetmap";
            this.Resetmap.Size = new System.Drawing.Size(92, 23);
            this.Resetmap.TabIndex = 10;
            this.Resetmap.Text = "Rotterdam";
            this.Resetmap.UseVisualStyleBackColor = true;
            this.Resetmap.Click += new System.EventHandler(this.Resetmap_Click);
            // 
            // zoomin
            // 
            this.zoomin.Location = new System.Drawing.Point(61, 26);
            this.zoomin.Name = "zoomin";
            this.zoomin.Size = new System.Drawing.Size(75, 23);
            this.zoomin.TabIndex = 11;
            this.zoomin.Text = "+";
            this.zoomin.UseVisualStyleBackColor = true;
            this.zoomin.Click += new System.EventHandler(this.zoomin_Click);
            // 
            // Zoomout
            // 
            this.Zoomout.Location = new System.Drawing.Point(177, 26);
            this.Zoomout.Name = "Zoomout";
            this.Zoomout.Size = new System.Drawing.Size(75, 23);
            this.Zoomout.TabIndex = 12;
            this.Zoomout.Text = "-";
            this.Zoomout.UseVisualStyleBackColor = true;
            this.Zoomout.Click += new System.EventHandler(this.Zoomout_Click);
            // 
            // Security
            // 
            this.Security.Location = new System.Drawing.Point(112, 369);
            this.Security.Name = "Security";
            this.Security.Size = new System.Drawing.Size(92, 42);
            this.Security.TabIndex = 13;
            this.Security.Text = "Parkeer veiligheid";
            this.Security.UseVisualStyleBackColor = true;
            this.Security.Click += new System.EventHandler(this.Security_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 547);
            this.Controls.Add(this.Security);
            this.Controls.Add(this.Zoomout);
            this.Controls.Add(this.zoomin);
            this.Controls.Add(this.Resetmap);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.splitter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Secureparking";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Resetmap;
        private System.Windows.Forms.Button zoomin;
        private System.Windows.Forms.Button Zoomout;
        private System.Windows.Forms.Button Security;
    }
}

