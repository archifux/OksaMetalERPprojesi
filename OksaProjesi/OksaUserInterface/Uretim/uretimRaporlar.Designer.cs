namespace OksaUserInterface.Uretim
{
    partial class uretimRaporlar
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Process"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))));
            this.label1 = new System.Windows.Forms.Label();
            this.uretimRaporCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.uretimLW = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raporlama Türü:";
            // 
            // uretimRaporCB
            // 
            this.uretimRaporCB.FormattingEnabled = true;
            this.uretimRaporCB.Items.AddRange(new object[] {
            "Üretimdeki processler",
            "Tamamlanmış processler",
            "Kullanılan abganta göre"});
            this.uretimRaporCB.Location = new System.Drawing.Point(177, 25);
            this.uretimRaporCB.Name = "uretimRaporCB";
            this.uretimRaporCB.Size = new System.Drawing.Size(154, 21);
            this.uretimRaporCB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(403, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarih:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(478, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // uretimLW
            // 
            this.uretimLW.GridLines = true;
            this.uretimLW.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.uretimLW.Location = new System.Drawing.Point(12, 63);
            this.uretimLW.Name = "uretimLW";
            this.uretimLW.Size = new System.Drawing.Size(661, 261);
            this.uretimLW.TabIndex = 4;
            this.uretimLW.UseCompatibleStateImageBehavior = false;
            this.uretimLW.View = System.Windows.Forms.View.Tile;
            // 
            // raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 336);
            this.Controls.Add(this.uretimLW);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uretimRaporCB);
            this.Controls.Add(this.label1);
            this.Name = "raporlar";
            this.Text = "raporlar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uretimRaporCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView uretimLW;
    }
}