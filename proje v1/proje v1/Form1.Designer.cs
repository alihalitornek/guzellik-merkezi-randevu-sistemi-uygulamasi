namespace proje_v1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.hizmetler = new System.Windows.Forms.Button();
            this.personel = new System.Windows.Forms.Button();
            this.musteriler = new System.Windows.Forms.Button();
            this.randevu = new System.Windows.Forms.Button();
            this.randevukontrol1 = new proje_v1.randevukontrol();
            this.personelkontrol1 = new proje_v1.personelkontrol();
            this.musterikontrol1 = new proje_v1.musterikontrol();
            this.hizmetkontrol1 = new proje_v1.hizmetkontrol();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.hizmetler);
            this.panel1.Controls.Add(this.personel);
            this.panel1.Controls.Add(this.musteriler);
            this.panel1.Controls.Add(this.randevu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 494);
            this.panel1.TabIndex = 0;
            // 
            // hizmetler
            // 
            this.hizmetler.BackColor = System.Drawing.Color.Firebrick;
            this.hizmetler.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.hizmetler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hizmetler.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hizmetler.ForeColor = System.Drawing.Color.White;
            this.hizmetler.Location = new System.Drawing.Point(0, 299);
            this.hizmetler.Name = "hizmetler";
            this.hizmetler.Size = new System.Drawing.Size(200, 71);
            this.hizmetler.TabIndex = 2;
            this.hizmetler.Text = "hizmetler";
            this.hizmetler.UseVisualStyleBackColor = false;
            this.hizmetler.Click += new System.EventHandler(this.hizmetler_Click);
            // 
            // personel
            // 
            this.personel.BackColor = System.Drawing.Color.Firebrick;
            this.personel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.personel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personel.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personel.ForeColor = System.Drawing.Color.White;
            this.personel.Location = new System.Drawing.Point(0, 222);
            this.personel.Name = "personel";
            this.personel.Size = new System.Drawing.Size(200, 71);
            this.personel.TabIndex = 3;
            this.personel.Text = "personel";
            this.personel.UseVisualStyleBackColor = false;
            this.personel.Click += new System.EventHandler(this.personel_Click);
            // 
            // musteriler
            // 
            this.musteriler.BackColor = System.Drawing.Color.Firebrick;
            this.musteriler.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.musteriler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteriler.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musteriler.ForeColor = System.Drawing.Color.White;
            this.musteriler.Location = new System.Drawing.Point(-3, 145);
            this.musteriler.Name = "musteriler";
            this.musteriler.Size = new System.Drawing.Size(200, 71);
            this.musteriler.TabIndex = 2;
            this.musteriler.Text = "musteriler";
            this.musteriler.UseVisualStyleBackColor = false;
            this.musteriler.Click += new System.EventHandler(this.musteriler_Click);
            // 
            // randevu
            // 
            this.randevu.BackColor = System.Drawing.Color.Firebrick;
            this.randevu.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.randevu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randevu.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randevu.ForeColor = System.Drawing.Color.White;
            this.randevu.Location = new System.Drawing.Point(0, 68);
            this.randevu.Name = "randevu";
            this.randevu.Size = new System.Drawing.Size(200, 71);
            this.randevu.TabIndex = 1;
            this.randevu.Text = "randevu";
            this.randevu.UseVisualStyleBackColor = false;
            this.randevu.Click += new System.EventHandler(this.randevu_Click);
            // 
            // randevukontrol1
            // 
            this.randevukontrol1.Location = new System.Drawing.Point(203, 3);
            this.randevukontrol1.Name = "randevukontrol1";
            this.randevukontrol1.Size = new System.Drawing.Size(668, 500);
            this.randevukontrol1.TabIndex = 4;
            // 
            // personelkontrol1
            // 
            this.personelkontrol1.Location = new System.Drawing.Point(203, 3);
            this.personelkontrol1.Name = "personelkontrol1";
            this.personelkontrol1.Size = new System.Drawing.Size(668, 500);
            this.personelkontrol1.TabIndex = 3;
            // 
            // musterikontrol1
            // 
            this.musterikontrol1.Location = new System.Drawing.Point(203, 3);
            this.musterikontrol1.Name = "musterikontrol1";
            this.musterikontrol1.Size = new System.Drawing.Size(668, 500);
            this.musterikontrol1.TabIndex = 2;
            // 
            // hizmetkontrol1
            // 
            this.hizmetkontrol1.Location = new System.Drawing.Point(203, 3);
            this.hizmetkontrol1.Name = "hizmetkontrol1";
            this.hizmetkontrol1.Size = new System.Drawing.Size(668, 500);
            this.hizmetkontrol1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 494);
            this.Controls.Add(this.randevukontrol1);
            this.Controls.Add(this.personelkontrol1);
            this.Controls.Add(this.musterikontrol1);
            this.Controls.Add(this.hizmetkontrol1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güzellik merkezi uygulaması";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button randevu;
        private System.Windows.Forms.Button hizmetler;
        private System.Windows.Forms.Button personel;
        private System.Windows.Forms.Button musteriler;
        private hizmetkontrol hizmetkontrol1;
        private musterikontrol musterikontrol1;
        private personelkontrol personelkontrol1;
        private randevukontrol randevukontrol1;
    }
}

