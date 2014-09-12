namespace OksaUserInterface.Uretim
{
    partial class UretimMuduru
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.uretimeGonderBTN = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DigerSiparisTB = new System.Windows.Forms.RichTextBox();
            this.DigerSatinTB = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(641, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Siparişler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.uretimeGonderBTN);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 321);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gelen Siparişler";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.GridLines = true;
            listViewItem2.Tag = "Id";
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(3, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(638, 181);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Depo Kodu";
            this.columnHeader1.Width = 69;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Stok Adı";
            this.columnHeader2.Width = 61;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Stok Kodu";
            this.columnHeader3.Width = 64;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cari İsim";
            this.columnHeader4.Width = 55;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tarih";
            this.columnHeader5.Width = 42;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "İrsaliye No";
            this.columnHeader6.Width = 68;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Alis Mik.";
            this.columnHeader7.Width = 58;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Satis Mik.";
            this.columnHeader8.Width = 78;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Birim Fiyat";
            this.columnHeader9.Width = 68;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Net Fiyat";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(106, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Satın al ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uretimeGonderBTN
            // 
            this.uretimeGonderBTN.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uretimeGonderBTN.Location = new System.Drawing.Point(397, 247);
            this.uretimeGonderBTN.Name = "uretimeGonderBTN";
            this.uretimeGonderBTN.Size = new System.Drawing.Size(133, 45);
            this.uretimeGonderBTN.TabIndex = 1;
            this.uretimeGonderBTN.Text = "Üretime Gönder";
            this.uretimeGonderBTN.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(649, 347);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(641, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Diğer Siparişler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DimGray;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DigerSiparisTB);
            this.groupBox2.Controls.Add(this.DigerSatinTB);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(-4, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 318);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Siparis Ver";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Diğer Şirket Gereksinimleri :";
            // 
            // DigerSiparisTB
            // 
            this.DigerSiparisTB.Location = new System.Drawing.Point(160, 82);
            this.DigerSiparisTB.Name = "DigerSiparisTB";
            this.DigerSiparisTB.Size = new System.Drawing.Size(270, 96);
            this.DigerSiparisTB.TabIndex = 3;
            this.DigerSiparisTB.Text = "";
            // 
            // DigerSatinTB
            // 
            this.DigerSatinTB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DigerSatinTB.Location = new System.Drawing.Point(239, 215);
            this.DigerSatinTB.Name = "DigerSatinTB";
            this.DigerSatinTB.Size = new System.Drawing.Size(160, 45);
            this.DigerSatinTB.TabIndex = 2;
            this.DigerSatinTB.Text = "Satın al ";
            this.DigerSatinTB.UseVisualStyleBackColor = true;
            // 
            // UretimMuduru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 347);
            this.Controls.Add(this.tabControl1);
            this.Name = "UretimMuduru";
            this.Text = "UretimMuduru";
            this.Load += new System.EventHandler(this.UretimMuduru_Load);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button uretimeGonderBTN;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DigerSatinTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox DigerSiparisTB;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}