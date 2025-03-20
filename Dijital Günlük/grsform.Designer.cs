namespace Dijital_Günlük
{
    partial class grsform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(grsform));
            this.button1 = new System.Windows.Forms.Button();
            this.tx_kullanici = new System.Windows.Forms.TextBox();
            this.tx_parola = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.lbl_prl = new System.Windows.Forms.Label();
            this.lbl_kayit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(329, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 19);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tx_kullanici
            // 
            this.tx_kullanici.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tx_kullanici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_kullanici.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tx_kullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_kullanici.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tx_kullanici.HideSelection = false;
            this.tx_kullanici.Location = new System.Drawing.Point(152, 114);
            this.tx_kullanici.Multiline = true;
            this.tx_kullanici.Name = "tx_kullanici";
            this.tx_kullanici.Size = new System.Drawing.Size(117, 27);
            this.tx_kullanici.TabIndex = 5;
            this.tx_kullanici.Text = "serhat";
            // 
            // tx_parola
            // 
            this.tx_parola.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tx_parola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_parola.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tx_parola.Cursor = System.Windows.Forms.Cursors.Default;
            this.tx_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_parola.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tx_parola.HideSelection = false;
            this.tx_parola.Location = new System.Drawing.Point(152, 171);
            this.tx_parola.Margin = new System.Windows.Forms.Padding(0);
            this.tx_parola.Multiline = true;
            this.tx_parola.Name = "tx_parola";
            this.tx_parola.PasswordChar = '*';
            this.tx_parola.Size = new System.Drawing.Size(117, 27);
            this.tx_parola.TabIndex = 6;
            this.tx_parola.Text = "34324";
            this.tx_parola.WordWrap = false;
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_giris.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_giris.FlatAppearance.BorderSize = 2;
            this.btn_giris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_giris.Location = new System.Drawing.Point(103, 238);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(153, 33);
            this.btn_giris.TabIndex = 7;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.UseCompatibleTextRendering = true;
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // lbl_prl
            // 
            this.lbl_prl.AutoSize = true;
            this.lbl_prl.BackColor = System.Drawing.Color.Transparent;
            this.lbl_prl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_prl.ForeColor = System.Drawing.Color.Red;
            this.lbl_prl.Location = new System.Drawing.Point(162, 280);
            this.lbl_prl.Name = "lbl_prl";
            this.lbl_prl.Size = new System.Drawing.Size(104, 13);
            this.lbl_prl.TabIndex = 8;
            this.lbl_prl.Text = "Parolamı unuttum";
            this.lbl_prl.Click += new System.EventHandler(this.lbl_prl_Click);
            // 
            // lbl_kayit
            // 
            this.lbl_kayit.AutoSize = true;
            this.lbl_kayit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kayit.ForeColor = System.Drawing.Color.Blue;
            this.lbl_kayit.Location = new System.Drawing.Point(108, 280);
            this.lbl_kayit.Name = "lbl_kayit";
            this.lbl_kayit.Size = new System.Drawing.Size(51, 13);
            this.lbl_kayit.TabIndex = 9;
            this.lbl_kayit.Text = "Kayıt Ol";
            this.lbl_kayit.Click += new System.EventHandler(this.lbl_kayit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(35, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label4.Location = new System.Drawing.Point(94, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Şifre:";
            // 
            // grsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(360, 361);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_kayit);
            this.Controls.Add(this.lbl_prl);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.tx_parola);
            this.Controls.Add(this.tx_kullanici);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "grsform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Günlük | Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tx_kullanici;
        private System.Windows.Forms.TextBox tx_parola;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Label lbl_prl;
        private System.Windows.Forms.Label lbl_kayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

