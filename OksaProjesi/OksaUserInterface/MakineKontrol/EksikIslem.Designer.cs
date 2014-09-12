namespace OksaUserInterface.MakineKontrol
{
    partial class EksikIslem
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
            this.nmrUDeksikParca = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEksikSebep = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUDeksikParca)).BeginInit();
            this.SuspendLayout();
            // 
            // nmrUDeksikParca
            // 
            this.nmrUDeksikParca.Location = new System.Drawing.Point(221, 19);
            this.nmrUDeksikParca.Name = "nmrUDeksikParca";
            this.nmrUDeksikParca.Size = new System.Drawing.Size(85, 20);
            this.nmrUDeksikParca.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tamamlanan Parça Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tamamlanamama Sebebi:";
            // 
            // txtEksikSebep
            // 
            this.txtEksikSebep.Location = new System.Drawing.Point(221, 62);
            this.txtEksikSebep.Name = "txtEksikSebep";
            this.txtEksikSebep.Size = new System.Drawing.Size(224, 146);
            this.txtEksikSebep.TabIndex = 3;
            this.txtEksikSebep.Text = "";
            // 
            // EksikIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 257);
            this.Controls.Add(this.txtEksikSebep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmrUDeksikParca);
            this.Name = "EksikIslem";
            this.Text = "EksikIslem";
            ((System.ComponentModel.ISupportInitialize)(this.nmrUDeksikParca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmrUDeksikParca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtEksikSebep;
    }
}