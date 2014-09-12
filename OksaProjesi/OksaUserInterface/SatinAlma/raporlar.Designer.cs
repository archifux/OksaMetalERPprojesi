namespace OksaUserInterface.SatinAlma
{
    partial class raporlar
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.stokAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stokKodu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.girisMiktari = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cikismiktari = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.asgariStok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kalanMiktar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sonAlisFiyati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Girilen Siparişler",
            "Üretimde olan Siparişler",
            "Teslim Bekleyen Siparişler",
            "Teslim Tarihine göre Raporlama",
            "Stok Bazlı Raporlama"});
            this.comboBox1.Location = new System.Drawing.Point(163, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Raporlama türü:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(362, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Başlangıç Tarihi:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(511, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rapor Süresi:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Günlük",
            "Belirli Aralığa göre"});
            this.comboBox2.Location = new System.Drawing.Point(163, 76);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(362, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bitiş Tarihi:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(511, 74);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stokAdi,
            this.stokKodu,
            this.girisMiktari,
            this.cikismiktari,
            this.asgariStok,
            this.kalanMiktar,
            this.sonAlisFiyati});
            this.listView1.Location = new System.Drawing.Point(16, 121);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(635, 215);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // stokAdi
            // 
            this.stokAdi.Text = "Stok Adı";
            this.stokAdi.Width = 174;
            // 
            // stokKodu
            // 
            this.stokKodu.Text = "Stok Kodu";
            this.stokKodu.Width = 86;
            // 
            // girisMiktari
            // 
            this.girisMiktari.Text = "Giriş Miktarı";
            this.girisMiktari.Width = 66;
            // 
            // cikismiktari
            // 
            this.cikismiktari.Text = "Çıkış Miktarı";
            this.cikismiktari.Width = 72;
            // 
            // asgariStok
            // 
            this.asgariStok.Text = "Asgari Stok";
            this.asgariStok.Width = 67;
            // 
            // kalanMiktar
            // 
            this.kalanMiktar.Text = "Kalan Miktar";
            this.kalanMiktar.Width = 74;
            // 
            // sonAlisFiyati
            // 
            this.sonAlisFiyati.Text = "Son Alış Fiyatı";
            this.sonAlisFiyati.Width = 87;
            // 
            // raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 375);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "raporlar";
            this.Text = "raporlar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader stokAdi;
        private System.Windows.Forms.ColumnHeader stokKodu;
        private System.Windows.Forms.ColumnHeader girisMiktari;
        private System.Windows.Forms.ColumnHeader cikismiktari;
        private System.Windows.Forms.ColumnHeader asgariStok;
        private System.Windows.Forms.ColumnHeader kalanMiktar;
        private System.Windows.Forms.ColumnHeader sonAlisFiyati;
    }
}