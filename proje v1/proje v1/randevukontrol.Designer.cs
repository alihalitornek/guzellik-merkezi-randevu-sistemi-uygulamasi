namespace proje_v1
{
    partial class randevukontrol
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ekle = new System.Windows.Forms.Button();
            this.düzenle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.hizmetAdi = new System.Windows.Forms.ListBox();
            this.kacgun = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.personelAdi = new System.Windows.Forms.ListBox();
            this.musteriAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.musteriSoyadi = new System.Windows.Forms.TextBox();
            this.musteriTelefonu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.eskimusteriTel = new System.Windows.Forms.TextBox();
            this.eskimusteriSoyadi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.eskimusteriAdi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(665, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // ekle
            // 
            this.ekle.BackColor = System.Drawing.Color.Firebrick;
            this.ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ekle.Location = new System.Drawing.Point(61, 427);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(89, 49);
            this.ekle.TabIndex = 1;
            this.ekle.Text = "ekle";
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // düzenle
            // 
            this.düzenle.BackColor = System.Drawing.Color.Firebrick;
            this.düzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.düzenle.ForeColor = System.Drawing.Color.Transparent;
            this.düzenle.Location = new System.Drawing.Point(219, 427);
            this.düzenle.Name = "düzenle";
            this.düzenle.Size = new System.Drawing.Size(92, 49);
            this.düzenle.TabIndex = 2;
            this.düzenle.Text = "düzenle";
            this.düzenle.UseVisualStyleBackColor = false;
            this.düzenle.Click += new System.EventHandler(this.düzenle_Click);
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.Firebrick;
            this.sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sil.Location = new System.Drawing.Point(366, 427);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(97, 49);
            this.sil.TabIndex = 3;
            this.sil.Text = "sil";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // hizmetAdi
            // 
            this.hizmetAdi.FormattingEnabled = true;
            this.hizmetAdi.ItemHeight = 16;
            this.hizmetAdi.Items.AddRange(new object[] {
            "sacBoyama",
            "sacKesimi",
            "makyaj"});
            this.hizmetAdi.Location = new System.Drawing.Point(37, 298);
            this.hizmetAdi.Name = "hizmetAdi";
            this.hizmetAdi.Size = new System.Drawing.Size(120, 116);
            this.hizmetAdi.TabIndex = 4;
            // 
            // kacgun
            // 
            this.kacgun.FormattingEnabled = true;
            this.kacgun.ItemHeight = 16;
            this.kacgun.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.kacgun.Location = new System.Drawing.Point(315, 298);
            this.kacgun.Name = "kacgun";
            this.kacgun.Size = new System.Drawing.Size(120, 116);
            this.kacgun.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "hizmetadi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "kacgunsonra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "personeladi";
            // 
            // personelAdi
            // 
            this.personelAdi.FormattingEnabled = true;
            this.personelAdi.ItemHeight = 16;
            this.personelAdi.Items.AddRange(new object[] {
            "Elif Yılmaz",
            "Zeynep Kaya",
            "Defne Demir",
            "Ece Aksoy",
            "İlayda Çelik",
            "Ada Arslan",
            "Nehir Şahin"});
            this.personelAdi.Location = new System.Drawing.Point(175, 298);
            this.personelAdi.Name = "personelAdi";
            this.personelAdi.Size = new System.Drawing.Size(120, 116);
            this.personelAdi.TabIndex = 8;
            // 
            // musteriAdi
            // 
            this.musteriAdi.Location = new System.Drawing.Point(457, 298);
            this.musteriAdi.Name = "musteriAdi";
            this.musteriAdi.Size = new System.Drawing.Size(100, 22);
            this.musteriAdi.TabIndex = 10;
            this.musteriAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.musteriAdi_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "musteriadi";
            // 
            // musteriSoyadi
            // 
            this.musteriSoyadi.Location = new System.Drawing.Point(457, 346);
            this.musteriSoyadi.Name = "musteriSoyadi";
            this.musteriSoyadi.Size = new System.Drawing.Size(100, 22);
            this.musteriSoyadi.TabIndex = 12;
            this.musteriSoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.musteriSoyadi_KeyPress);
            // 
            // musteriTelefonu
            // 
            this.musteriTelefonu.Location = new System.Drawing.Point(457, 392);
            this.musteriTelefonu.Name = "musteriTelefonu";
            this.musteriTelefonu.Size = new System.Drawing.Size(100, 22);
            this.musteriTelefonu.TabIndex = 13;
            this.musteriTelefonu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.musteriTelefonu_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "musterisoyadi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "musteritelefonu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(565, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "musteritelefonu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(568, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "musterisoyadi";
            // 
            // eskimusteriTel
            // 
            this.eskimusteriTel.Location = new System.Drawing.Point(563, 392);
            this.eskimusteriTel.Name = "eskimusteriTel";
            this.eskimusteriTel.Size = new System.Drawing.Size(100, 22);
            this.eskimusteriTel.TabIndex = 19;
            this.eskimusteriTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eskimusteriTel_KeyPress);
            // 
            // eskimusteriSoyadi
            // 
            this.eskimusteriSoyadi.Location = new System.Drawing.Point(563, 346);
            this.eskimusteriSoyadi.Name = "eskimusteriSoyadi";
            this.eskimusteriSoyadi.Size = new System.Drawing.Size(100, 22);
            this.eskimusteriSoyadi.TabIndex = 18;
            this.eskimusteriSoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eskimusteriSoyadi_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(579, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "musteriadi";
            // 
            // eskimusteriAdi
            // 
            this.eskimusteriAdi.Location = new System.Drawing.Point(563, 298);
            this.eskimusteriAdi.Name = "eskimusteriAdi";
            this.eskimusteriAdi.Size = new System.Drawing.Size(100, 22);
            this.eskimusteriAdi.TabIndex = 16;
            this.eskimusteriAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eskimusteriAdi_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(568, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "düzenlenecek\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(492, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "yeni";
            // 
            // randevukontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.eskimusteriTel);
            this.Controls.Add(this.eskimusteriSoyadi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.eskimusteriAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.musteriTelefonu);
            this.Controls.Add(this.musteriSoyadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.musteriAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.personelAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kacgun);
            this.Controls.Add(this.hizmetAdi);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.düzenle);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "randevukontrol";
            this.Size = new System.Drawing.Size(680, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button düzenle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.ListBox hizmetAdi;
        private System.Windows.Forms.ListBox kacgun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox personelAdi;
        private System.Windows.Forms.TextBox musteriAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox musteriSoyadi;
        private System.Windows.Forms.TextBox musteriTelefonu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox eskimusteriTel;
        private System.Windows.Forms.TextBox eskimusteriSoyadi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox eskimusteriAdi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}
