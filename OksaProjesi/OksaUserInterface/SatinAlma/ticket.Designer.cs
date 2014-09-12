namespace OksaUserInterface.SatinAlma
{
    partial class ticket
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
            this.lblTicketKulAdi = new System.Windows.Forms.Label();
            this.lblTicketDepartman = new System.Windows.Forms.Label();
            this.lblTicketSorun = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtDepartman = new System.Windows.Forms.TextBox();
            this.txtSorun = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGonder = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTicketKulAdi
            // 
            this.lblTicketKulAdi.AutoSize = true;
            this.lblTicketKulAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTicketKulAdi.Location = new System.Drawing.Point(18, 39);
            this.lblTicketKulAdi.Name = "lblTicketKulAdi";
            this.lblTicketKulAdi.Size = new System.Drawing.Size(141, 20);
            this.lblTicketKulAdi.TabIndex = 0;
            this.lblTicketKulAdi.Text = "Kullanıcı Adı Giriniz";
            // 
            // lblTicketDepartman
            // 
            this.lblTicketDepartman.AutoSize = true;
            this.lblTicketDepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTicketDepartman.Location = new System.Drawing.Point(17, 67);
            this.lblTicketDepartman.Name = "lblTicketDepartman";
            this.lblTicketDepartman.Size = new System.Drawing.Size(137, 20);
            this.lblTicketDepartman.TabIndex = 0;
            this.lblTicketDepartman.Text = "Departman Giriniz";
            // 
            // lblTicketSorun
            // 
            this.lblTicketSorun.AutoSize = true;
            this.lblTicketSorun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTicketSorun.Location = new System.Drawing.Point(17, 96);
            this.lblTicketSorun.Name = "lblTicketSorun";
            this.lblTicketSorun.Size = new System.Drawing.Size(252, 20);
            this.lblTicketSorun.TabIndex = 0;
            this.lblTicketSorun.Text = "Lütfen Sorununuzu Açıkça Yazınız";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(325, 41);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(118, 21);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // txtDepartman
            // 
            this.txtDepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDepartman.Location = new System.Drawing.Point(325, 67);
            this.txtDepartman.Name = "txtDepartman";
            this.txtDepartman.Size = new System.Drawing.Size(118, 21);
            this.txtDepartman.TabIndex = 1;
            // 
            // txtSorun
            // 
            this.txtSorun.Location = new System.Drawing.Point(20, 121);
            this.txtSorun.Multiline = true;
            this.txtSorun.Name = "txtSorun";
            this.txtSorun.Size = new System.Drawing.Size(546, 172);
            this.txtSorun.TabIndex = 2;
            this.txtSorun.TabStop = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(323, 306);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(109, 31);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(457, 306);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(109, 31);
            this.btnGonder.TabIndex = 3;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(187, 306);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(109, 31);
            this.btnIptal.TabIndex = 3;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sorununuzun kısa sürede çözülmesi için lütfen formu eksiksiz doldurunuz.";
            // 
            // ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtSorun);
            this.Controls.Add(this.txtDepartman);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblTicketSorun);
            this.Controls.Add(this.lblTicketDepartman);
            this.Controls.Add(this.lblTicketKulAdi);
            this.Name = "ticket";
            this.Text = "ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTicketKulAdi;
        private System.Windows.Forms.Label lblTicketDepartman;
        private System.Windows.Forms.Label lblTicketSorun;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtDepartman;
        private System.Windows.Forms.TextBox txtSorun;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label label1;
    }
}