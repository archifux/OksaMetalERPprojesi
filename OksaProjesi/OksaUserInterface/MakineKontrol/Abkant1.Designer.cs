namespace OksaUserInterface.MakineKontrol
{
    partial class Abkant1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstAbkant1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAbkant1Basla = new System.Windows.Forms.Button();
            this.btnAbkant1Bitir = new System.Windows.Forms.Button();
            this.btnAbkant1Eksik = new System.Windows.Forms.Button();
            this.btnAbkant1Cikis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAbkant1Vardiya = new System.Windows.Forms.TextBox();
            this.txtAbkant1Makina = new System.Windows.Forms.TextBox();
            this.txtAbkant1Operator = new System.Windows.Forms.TextBox();
            this.txtAbkant1Tarih = new System.Windows.Forms.TextBox();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAbkant1TeknikResim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(373, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abkant 1 İş Takip Formu";
            // 
            // lstAbkant1
            // 
            this.lstAbkant1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstAbkant1.Location = new System.Drawing.Point(21, 103);
            this.lstAbkant1.Name = "lstAbkant1";
            this.lstAbkant1.Size = new System.Drawing.Size(532, 215);
            this.lstAbkant1.TabIndex = 1;
            this.lstAbkant1.UseCompatibleStateImageBehavior = false;
            this.lstAbkant1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Stok Kodu";
            this.columnHeader1.Width = 69;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Büküm Sayısı";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Bük. Parça Sayısı";
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İlk Parça Onay";
            this.columnHeader4.Width = 84;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Proses Kontrol";
            this.columnHeader5.Width = 85;
            // 
            // btnAbkant1Basla
            // 
            this.btnAbkant1Basla.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAbkant1Basla.Location = new System.Drawing.Point(616, 103);
            this.btnAbkant1Basla.Name = "btnAbkant1Basla";
            this.btnAbkant1Basla.Size = new System.Drawing.Size(105, 52);
            this.btnAbkant1Basla.TabIndex = 2;
            this.btnAbkant1Basla.Text = "Başla";
            this.btnAbkant1Basla.UseVisualStyleBackColor = true;
            // 
            // btnAbkant1Bitir
            // 
            this.btnAbkant1Bitir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAbkant1Bitir.Location = new System.Drawing.Point(745, 103);
            this.btnAbkant1Bitir.Name = "btnAbkant1Bitir";
            this.btnAbkant1Bitir.Size = new System.Drawing.Size(105, 52);
            this.btnAbkant1Bitir.TabIndex = 3;
            this.btnAbkant1Bitir.Text = "Bitir";
            this.btnAbkant1Bitir.UseVisualStyleBackColor = true;
            // 
            // btnAbkant1Eksik
            // 
            this.btnAbkant1Eksik.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAbkant1Eksik.Location = new System.Drawing.Point(745, 182);
            this.btnAbkant1Eksik.Name = "btnAbkant1Eksik";
            this.btnAbkant1Eksik.Size = new System.Drawing.Size(105, 52);
            this.btnAbkant1Eksik.TabIndex = 4;
            this.btnAbkant1Eksik.Text = "Eksik Tamamlandı";
            this.btnAbkant1Eksik.UseVisualStyleBackColor = true;
            this.btnAbkant1Eksik.Click += new System.EventHandler(this.btnEksik_Click);
            // 
            // btnAbkant1Cikis
            // 
            this.btnAbkant1Cikis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAbkant1Cikis.Location = new System.Drawing.Point(745, 342);
            this.btnAbkant1Cikis.Name = "btnAbkant1Cikis";
            this.btnAbkant1Cikis.Size = new System.Drawing.Size(105, 52);
            this.btnAbkant1Cikis.TabIndex = 5;
            this.btnAbkant1Cikis.Text = "Çıkış";
            this.btnAbkant1Cikis.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vardiya:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(212, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Makina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(409, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Operatör:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(613, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tarih:";
            // 
            // txtAbkant1Vardiya
            // 
            this.txtAbkant1Vardiya.Location = new System.Drawing.Point(89, 47);
            this.txtAbkant1Vardiya.Name = "txtAbkant1Vardiya";
            this.txtAbkant1Vardiya.Size = new System.Drawing.Size(100, 20);
            this.txtAbkant1Vardiya.TabIndex = 10;
            // 
            // txtAbkant1Makina
            // 
            this.txtAbkant1Makina.Location = new System.Drawing.Point(291, 47);
            this.txtAbkant1Makina.Name = "txtAbkant1Makina";
            this.txtAbkant1Makina.Size = new System.Drawing.Size(100, 20);
            this.txtAbkant1Makina.TabIndex = 11;
            // 
            // txtAbkant1Operator
            // 
            this.txtAbkant1Operator.Location = new System.Drawing.Point(491, 50);
            this.txtAbkant1Operator.Name = "txtAbkant1Operator";
            this.txtAbkant1Operator.Size = new System.Drawing.Size(100, 20);
            this.txtAbkant1Operator.TabIndex = 12;
            // 
            // txtAbkant1Tarih
            // 
            this.txtAbkant1Tarih.Location = new System.Drawing.Point(673, 50);
            this.txtAbkant1Tarih.Name = "txtAbkant1Tarih";
            this.txtAbkant1Tarih.Size = new System.Drawing.Size(100, 20);
            this.txtAbkant1Tarih.TabIndex = 13;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Açıklama";
            this.columnHeader6.Width = 109;
            // 
            // btnAbkant1TeknikResim
            // 
            this.btnAbkant1TeknikResim.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAbkant1TeknikResim.Location = new System.Drawing.Point(616, 182);
            this.btnAbkant1TeknikResim.Name = "btnAbkant1TeknikResim";
            this.btnAbkant1TeknikResim.Size = new System.Drawing.Size(105, 52);
            this.btnAbkant1TeknikResim.TabIndex = 14;
            this.btnAbkant1TeknikResim.Text = "Teknik Resim";
            this.btnAbkant1TeknikResim.UseVisualStyleBackColor = true;
            // 
            // Abkant1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 412);
            this.Controls.Add(this.btnAbkant1TeknikResim);
            this.Controls.Add(this.txtAbkant1Tarih);
            this.Controls.Add(this.txtAbkant1Operator);
            this.Controls.Add(this.txtAbkant1Makina);
            this.Controls.Add(this.txtAbkant1Vardiya);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAbkant1Cikis);
            this.Controls.Add(this.btnAbkant1Eksik);
            this.Controls.Add(this.btnAbkant1Bitir);
            this.Controls.Add(this.btnAbkant1Basla);
            this.Controls.Add(this.lstAbkant1);
            this.Controls.Add(this.label1);
            this.Name = "Abkant1";
            this.Text = "Abkant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstAbkant1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnAbkant1Basla;
        private System.Windows.Forms.Button btnAbkant1Bitir;
        private System.Windows.Forms.Button btnAbkant1Eksik;
        private System.Windows.Forms.Button btnAbkant1Cikis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAbkant1Vardiya;
        private System.Windows.Forms.TextBox txtAbkant1Makina;
        private System.Windows.Forms.TextBox txtAbkant1Operator;
        private System.Windows.Forms.TextBox txtAbkant1Tarih;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnAbkant1TeknikResim;

    }
}