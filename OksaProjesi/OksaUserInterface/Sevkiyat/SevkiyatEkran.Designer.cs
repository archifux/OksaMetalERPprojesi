﻿namespace OksaUserInterface.Sevkiyat
{
    partial class SevkiyatEkran
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
            this.lblSevkiyatGelen = new System.Windows.Forms.Label();
            this.lstGelenSevk = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSevkiyatGiden = new System.Windows.Forms.Label();
            this.lstGidenSevk = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstSevkIcerik = new System.Windows.Forms.ListBox();
            this.lblSevkIcerik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSevkGidenIcerik = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSevkiyatGelen
            // 
            this.lblSevkiyatGelen.AutoSize = true;
            this.lblSevkiyatGelen.Location = new System.Drawing.Point(17, 16);
            this.lblSevkiyatGelen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSevkiyatGelen.Name = "lblSevkiyatGelen";
            this.lblSevkiyatGelen.Size = new System.Drawing.Size(103, 17);
            this.lblSevkiyatGelen.TabIndex = 0;
            this.lblSevkiyatGelen.Text = "Gelen Sevkiyat";
            // 
            // lstGelenSevk
            // 
            this.lstGelenSevk.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7});
            this.lstGelenSevk.GridLines = true;
            this.lstGelenSevk.Location = new System.Drawing.Point(21, 37);
            this.lstGelenSevk.Margin = new System.Windows.Forms.Padding(4);
            this.lstGelenSevk.Name = "lstGelenSevk";
            this.lstGelenSevk.Size = new System.Drawing.Size(431, 244);
            this.lstGelenSevk.TabIndex = 1;
            this.lstGelenSevk.UseCompatibleStateImageBehavior = false;
            this.lstGelenSevk.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SiparişID";
            this.columnHeader1.Width = 69;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Adı";
            this.columnHeader2.Width = 77;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adet";
            this.columnHeader3.Width = 71;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Beklenen Tarih";
            this.columnHeader7.Width = 103;
            // 
            // lblSevkiyatGiden
            // 
            this.lblSevkiyatGiden.AutoSize = true;
            this.lblSevkiyatGiden.Location = new System.Drawing.Point(17, 308);
            this.lblSevkiyatGiden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSevkiyatGiden.Name = "lblSevkiyatGiden";
            this.lblSevkiyatGiden.Size = new System.Drawing.Size(103, 17);
            this.lblSevkiyatGiden.TabIndex = 0;
            this.lblSevkiyatGiden.Text = "Giden Sevkiyat";
            // 
            // lstGidenSevk
            // 
            this.lstGidenSevk.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader9});
            this.lstGidenSevk.GridLines = true;
            this.lstGidenSevk.Location = new System.Drawing.Point(21, 327);
            this.lstGidenSevk.Margin = new System.Windows.Forms.Padding(4);
            this.lstGidenSevk.Name = "lstGidenSevk";
            this.lstGidenSevk.Size = new System.Drawing.Size(431, 243);
            this.lstGidenSevk.TabIndex = 1;
            this.lstGidenSevk.UseCompatibleStateImageBehavior = false;
            this.lstGidenSevk.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SiparişID";
            this.columnHeader4.Width = 69;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ürün Adı";
            this.columnHeader5.Width = 77;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Adet";
            this.columnHeader6.Width = 71;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Beklenen Tarih";
            this.columnHeader9.Width = 103;
            // 
            // lstSevkIcerik
            // 
            this.lstSevkIcerik.FormattingEnabled = true;
            this.lstSevkIcerik.ItemHeight = 16;
            this.lstSevkIcerik.Location = new System.Drawing.Point(487, 37);
            this.lstSevkIcerik.Margin = new System.Windows.Forms.Padding(4);
            this.lstSevkIcerik.Name = "lstSevkIcerik";
            this.lstSevkIcerik.Size = new System.Drawing.Size(205, 244);
            this.lstSevkIcerik.TabIndex = 2;
            // 
            // lblSevkIcerik
            // 
            this.lblSevkIcerik.AutoSize = true;
            this.lblSevkIcerik.Location = new System.Drawing.Point(487, 16);
            this.lblSevkIcerik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSevkIcerik.Name = "lblSevkIcerik";
            this.lblSevkIcerik.Size = new System.Drawing.Size(102, 17);
            this.lblSevkIcerik.TabIndex = 3;
            this.lblSevkIcerik.Text = "Sevkiyat İçeriği";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 308);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sevkiyat İçeriği";
            // 
            // lstSevkGidenIcerik
            // 
            this.lstSevkGidenIcerik.FormattingEnabled = true;
            this.lstSevkGidenIcerik.ItemHeight = 16;
            this.lstSevkGidenIcerik.Location = new System.Drawing.Point(487, 327);
            this.lstSevkGidenIcerik.Margin = new System.Windows.Forms.Padding(4);
            this.lstSevkGidenIcerik.Name = "lstSevkGidenIcerik";
            this.lstSevkGidenIcerik.Size = new System.Drawing.Size(205, 244);
            this.lstSevkGidenIcerik.TabIndex = 2;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Ürün Hasarlı",
            "Adet Eksik",
            "SİPARİŞ BAŞARILI"});
            this.checkedListBox1.Location = new System.Drawing.Point(716, 37);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(159, 55);
            this.checkedListBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(957, 254);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(716, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sorun varsa açıklama giriniz.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(720, 127);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 118);
            this.textBox1.TabIndex = 7;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Ürün Hasarlı",
            "Adet Eksik",
            "SİPARİŞ BAŞARILI"});
            this.checkedListBox2.Location = new System.Drawing.Point(712, 326);
            this.checkedListBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(159, 55);
            this.checkedListBox2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(953, 543);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(712, 395);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sorun varsa açıklama giriniz.";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(716, 416);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(336, 118);
            this.textBox2.TabIndex = 7;
            // 
            // SevkiyatEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 590);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSevkIcerik);
            this.Controls.Add(this.lstSevkGidenIcerik);
            this.Controls.Add(this.lstSevkIcerik);
            this.Controls.Add(this.lblSevkiyatGiden);
            this.Controls.Add(this.lstGidenSevk);
            this.Controls.Add(this.lstGelenSevk);
            this.Controls.Add(this.lblSevkiyatGelen);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SevkiyatEkran";
            this.Text = "Sevkiyat";
            this.Load += new System.EventHandler(this.SevkiyatEkran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSevkiyatGelen;
        private System.Windows.Forms.ListView lstGelenSevk;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label lblSevkiyatGiden;
        private System.Windows.Forms.ListView lstGidenSevk;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListBox lstSevkIcerik;
        private System.Windows.Forms.Label lblSevkIcerik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSevkGidenIcerik;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}