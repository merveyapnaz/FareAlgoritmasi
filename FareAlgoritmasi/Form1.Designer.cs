namespace FareAlgoritmasi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEn = new System.Windows.Forms.Label();
            this.lblBoy = new System.Windows.Forms.Label();
            this.btnMinnie = new System.Windows.Forms.Button();
            this.btnMickey = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnCiz = new System.Windows.Forms.Button();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.pnlIcerik = new System.Windows.Forms.Panel();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnYeniOyun);
            this.panel1.Controls.Add(this.lblEn);
            this.panel1.Controls.Add(this.lblBoy);
            this.panel1.Controls.Add(this.btnMinnie);
            this.panel1.Controls.Add(this.btnMickey);
            this.panel1.Controls.Add(this.btnBasla);
            this.panel1.Controls.Add(this.btnCiz);
            this.panel1.Controls.Add(this.txtY);
            this.panel1.Controls.Add(this.txtX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(789, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(132, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(132, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 557);
            this.panel1.TabIndex = 0;
            // 
            // lblEn
            // 
            this.lblEn.AutoSize = true;
            this.lblEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEn.Location = new System.Drawing.Point(66, 33);
            this.lblEn.Name = "lblEn";
            this.lblEn.Size = new System.Drawing.Size(28, 15);
            this.lblEn.TabIndex = 11;
            this.lblEn.Text = "En:";
            // 
            // lblBoy
            // 
            this.lblBoy.AutoSize = true;
            this.lblBoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBoy.Location = new System.Drawing.Point(11, 33);
            this.lblBoy.Name = "lblBoy";
            this.lblBoy.Size = new System.Drawing.Size(34, 15);
            this.lblBoy.TabIndex = 10;
            this.lblBoy.Text = "Boy:";
            // 
            // btnMinnie
            // 
            this.btnMinnie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMinnie.Enabled = false;
            this.btnMinnie.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMinnie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMinnie.Location = new System.Drawing.Point(14, 167);
            this.btnMinnie.Name = "btnMinnie";
            this.btnMinnie.Size = new System.Drawing.Size(107, 47);
            this.btnMinnie.TabIndex = 9;
            this.btnMinnie.Tag = "-1,-1";
            this.btnMinnie.Text = "Minnie\'yi Yerleştir";
            this.btnMinnie.UseVisualStyleBackColor = false;
            this.btnMinnie.Click += new System.EventHandler(this.btnMinnie_Click);
            // 
            // btnMickey
            // 
            this.btnMickey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMickey.Enabled = false;
            this.btnMickey.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMickey.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMickey.Location = new System.Drawing.Point(14, 116);
            this.btnMickey.Name = "btnMickey";
            this.btnMickey.Size = new System.Drawing.Size(105, 45);
            this.btnMickey.TabIndex = 8;
            this.btnMickey.Tag = "-1,-1";
            this.btnMickey.Text = "Mickey\'i Yerleştir";
            this.btnMickey.UseVisualStyleBackColor = false;
            this.btnMickey.Click += new System.EventHandler(this.btnMickey_Click);
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBasla.Enabled = false;
            this.btnBasla.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBasla.Location = new System.Drawing.Point(15, 220);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(106, 31);
            this.btnBasla.TabIndex = 7;
            this.btnBasla.Tag = "-1,-1";
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnCiz
            // 
            this.btnCiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCiz.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnCiz.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCiz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCiz.Location = new System.Drawing.Point(13, 80);
            this.btnCiz.Name = "btnCiz";
            this.btnCiz.Size = new System.Drawing.Size(107, 30);
            this.btnCiz.TabIndex = 6;
            this.btnCiz.Tag = "-1,-1";
            this.btnCiz.Text = "Çiz";
            this.btnCiz.UseVisualStyleBackColor = false;
            this.btnCiz.Click += new System.EventHandler(this.btnCiz_Click);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(69, 49);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(50, 20);
            this.txtY.TabIndex = 5;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(13, 49);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(50, 20);
            this.txtX.TabIndex = 4;
            // 
            // pnlIcerik
            // 
            this.pnlIcerik.BackColor = System.Drawing.Color.White;
            this.pnlIcerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIcerik.Location = new System.Drawing.Point(0, 0);
            this.pnlIcerik.Name = "pnlIcerik";
            this.pnlIcerik.Size = new System.Drawing.Size(789, 557);
            this.pnlIcerik.TabIndex = 1;
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnYeniOyun.Enabled = false;
            this.btnYeniOyun.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniOyun.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnYeniOyun.Location = new System.Drawing.Point(15, 312);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(106, 110);
            this.btnYeniOyun.TabIndex = 12;
            this.btnYeniOyun.Tag = "-1,-1";
            this.btnYeniOyun.Text = "Yeni Oyun";
            this.btnYeniOyun.UseVisualStyleBackColor = false;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 557);
            this.Controls.Add(this.pnlIcerik);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnCiz;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Panel pnlIcerik;
        private System.Windows.Forms.Button btnMinnie;
        private System.Windows.Forms.Button btnMickey;
		private System.Windows.Forms.Label lblEn;
		private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.Button btnYeniOyun;
    }
}

