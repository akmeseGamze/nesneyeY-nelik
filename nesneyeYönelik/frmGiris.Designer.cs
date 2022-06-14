namespace nesneyeYönelik
{
    partial class frmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            this.btngrs = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.kullanıcıAdıTb = new System.Windows.Forms.TextBox();
            this.sifreTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btngrs
            // 
            this.btngrs.BackColor = System.Drawing.Color.MediumPurple;
            this.btngrs.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btngrs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngrs.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrs.Location = new System.Drawing.Point(229, 226);
            this.btngrs.Name = "btngrs";
            this.btngrs.Size = new System.Drawing.Size(177, 36);
            this.btngrs.TabIndex = 0;
            this.btngrs.Tag = "";
            this.btngrs.Text = "GİRİŞ";
            this.btngrs.UseVisualStyleBackColor = false;
            this.btngrs.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.Location = new System.Drawing.Point(119, 125);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(96, 21);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Kullanıcı Adı";
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsifre.Location = new System.Drawing.Point(119, 175);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(41, 21);
            this.lblsifre.TabIndex = 2;
            this.lblsifre.Text = "Şifre";
            // 
            // kullanıcıAdıTb
            // 
            this.kullanıcıAdıTb.Location = new System.Drawing.Point(233, 116);
            this.kullanıcıAdıTb.Multiline = true;
            this.kullanıcıAdıTb.Name = "kullanıcıAdıTb";
            this.kullanıcıAdıTb.Size = new System.Drawing.Size(173, 30);
            this.kullanıcıAdıTb.TabIndex = 3;
            this.kullanıcıAdıTb.TextChanged += new System.EventHandler(this.kullanıcıAdıTb_TextChanged);
            // 
            // sifreTb
            // 
            this.sifreTb.Location = new System.Drawing.Point(233, 166);
            this.sifreTb.Multiline = true;
            this.sifreTb.Name = "sifreTb";
            this.sifreTb.PasswordChar = '*';
            this.sifreTb.Size = new System.Drawing.Size(173, 30);
            this.sifreTb.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(230, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 44);
            this.label6.TabIndex = 0;
            this.label6.Text = "ÜNİYEMEK";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SlateBlue;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.MediumPurple;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Lavender;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "ÇIKIŞ";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 30;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.DarkSlateBlue;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DarkSlateBlue;
            this.bunifuThinButton21.Location = new System.Drawing.Point(213, 293);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(206, 57);
            this.bunifuThinButton21.TabIndex = 6;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.label6);
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.MidnightBlue;
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.DarkSlateBlue;
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.Silver;
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.Plum;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(12, -1);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(624, 97);
            this.gunaGradientPanel1.TabIndex = 7;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // frmGiris
            // 
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(615, 391);
            this.ControlBox = false;
            this.Controls.Add(this.gunaGradientPanel1);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.sifreTb);
            this.Controls.Add(this.kullanıcıAdıTb);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btngrs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmGiris";
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox2;
        protected internal System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Button btngrs;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.TextBox kullanıcıAdıTb;
        private System.Windows.Forms.TextBox sifreTb;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
    }
}

