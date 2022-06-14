namespace nesneyeYönelik
{
    partial class frmAnaSayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.label1 = new System.Windows.Forms.Label();
            this.btnprofil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList4 = new System.Windows.Forms.ImageList(this.components);
            this.btnbakiye = new System.Windows.Forms.Button();
            this.btnryap = new System.Windows.Forms.Button();
            this.btnrezervasyon = new System.Windows.Forms.Button();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÜNİYEMEK";
            // 
            // btnprofil
            // 
            this.btnprofil.BackColor = System.Drawing.Color.MediumPurple;
            this.btnprofil.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprofil.Image = global::nesneyeYönelik.Properties.Resources.icon_kullanıcı;
            this.btnprofil.Location = new System.Drawing.Point(589, 13);
            this.btnprofil.Name = "btnprofil";
            this.btnprofil.Size = new System.Drawing.Size(86, 68);
            this.btnprofil.TabIndex = 0;
            this.btnprofil.Text = "Profil";
            this.btnprofil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnprofil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnprofil.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 560);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanılabilir Bakiye";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.Tag = "";
            this.ımageList1.TransparentColor = System.Drawing.Color.Black;
            this.ımageList1.Images.SetKeyName(0, "rzrvasyon.jpg");
            this.ımageList1.Images.SetKeyName(1, "rzrvasyon.jpg");
            // 
            // ımageList2
            // 
            this.ımageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ımageList3
            // 
            this.ımageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList3.TransparentColor = System.Drawing.Color.IndianRed;
            // 
            // ımageList4
            // 
            this.ımageList4.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList4.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList4.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnbakiye
            // 
            this.btnbakiye.Font = new System.Drawing.Font("Segoe UI Variable Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbakiye.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbakiye.Image = global::nesneyeYönelik.Properties.Resources.bakiye;
            this.btnbakiye.Location = new System.Drawing.Point(12, 325);
            this.btnbakiye.Margin = new System.Windows.Forms.Padding(126, 236, 166, 196);
            this.btnbakiye.Name = "btnbakiye";
            this.btnbakiye.Size = new System.Drawing.Size(662, 207);
            this.btnbakiye.TabIndex = 1;
            this.btnbakiye.Text = "ÖDEME";
            this.btnbakiye.UseVisualStyleBackColor = true;
            this.btnbakiye.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnryap
            // 
            this.btnryap.Font = new System.Drawing.Font("Segoe UI Variable Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnryap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnryap.Image = global::nesneyeYönelik.Properties.Resources.rezervasyon_yap;
            this.btnryap.Location = new System.Drawing.Point(348, 104);
            this.btnryap.Margin = new System.Windows.Forms.Padding(126, 236, 166, 196);
            this.btnryap.Name = "btnryap";
            this.btnryap.Size = new System.Drawing.Size(326, 207);
            this.btnryap.TabIndex = 1;
            this.btnryap.Text = "REZERVASYON YAP";
            this.btnryap.UseVisualStyleBackColor = true;
            this.btnryap.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnrezervasyon
            // 
            this.btnrezervasyon.Font = new System.Drawing.Font("Segoe UI Variable Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrezervasyon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnrezervasyon.Image = ((System.Drawing.Image)(resources.GetObject("btnrezervasyon.Image")));
            this.btnrezervasyon.Location = new System.Drawing.Point(12, 104);
            this.btnrezervasyon.Margin = new System.Windows.Forms.Padding(126, 236, 166, 196);
            this.btnrezervasyon.Name = "btnrezervasyon";
            this.btnrezervasyon.Size = new System.Drawing.Size(326, 207);
            this.btnrezervasyon.TabIndex = 1;
            this.btnrezervasyon.Text = "REZERVASYONLARIM";
            this.btnrezervasyon.UseVisualStyleBackColor = true;
            this.btnrezervasyon.Click += new System.EventHandler(this.button2_Click);
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.label1);
            this.gunaGradientPanel1.Controls.Add(this.btnprofil);
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.MidnightBlue;
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.SlateBlue;
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.Silver;
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.Plum;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(-1, -1);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(693, 98);
            this.gunaGradientPanel1.TabIndex = 3;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(691, 587);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnbakiye);
            this.Controls.Add(this.btnryap);
            this.Controls.Add(this.btnrezervasyon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAnaSayfa";
            this.Text = "Form2";
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnprofil;
        public System.Windows.Forms.Button btnryap;
        public System.Windows.Forms.Button btnbakiye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.ImageList ımageList3;
        private System.Windows.Forms.ImageList ımageList4;
        public System.Windows.Forms.Button btnrezervasyon;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
    }
}