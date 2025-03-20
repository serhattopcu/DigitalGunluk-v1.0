namespace Dijital_Günlük
{
    partial class anaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaEkran));
            this.tx_metin = new System.Windows.Forms.TextBox();
            this.btn_coz = new System.Windows.Forms.Button();
            this.tx_sifreprev = new System.Windows.Forms.TextBox();
            this.tx_cozulenmetin = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.c1_gun = new System.Windows.Forms.ComboBox();
            this.c2_ay = new System.Windows.Forms.ComboBox();
            this.c3_yil = new System.Windows.Forms.ComboBox();
            this.lbl_gun = new System.Windows.Forms.Label();
            this.lbl_ay = new System.Windows.Forms.Label();
            this.lbl_yil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tx_metin
            // 
            this.tx_metin.BackColor = System.Drawing.Color.NavajoWhite;
            this.tx_metin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_metin.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_metin.Location = new System.Drawing.Point(38, 226);
            this.tx_metin.Multiline = true;
            this.tx_metin.Name = "tx_metin";
            this.tx_metin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tx_metin.Size = new System.Drawing.Size(670, 505);
            this.tx_metin.TabIndex = 0;
            this.tx_metin.TextChanged += new System.EventHandler(this.tx_metin_TextChanged);
            // 
            // btn_coz
            // 
            this.btn_coz.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_coz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_coz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_coz.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btn_coz.Location = new System.Drawing.Point(511, 22);
            this.btn_coz.Name = "btn_coz";
            this.btn_coz.Size = new System.Drawing.Size(131, 80);
            this.btn_coz.TabIndex = 2;
            this.btn_coz.Text = "Çöz ve Oku";
            this.btn_coz.UseVisualStyleBackColor = false;
            this.btn_coz.Click += new System.EventHandler(this.btn_coz_Click);
            // 
            // tx_sifreprev
            // 
            this.tx_sifreprev.BackColor = System.Drawing.Color.Black;
            this.tx_sifreprev.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tx_sifreprev.ForeColor = System.Drawing.Color.ForestGreen;
            this.tx_sifreprev.Location = new System.Drawing.Point(38, 33);
            this.tx_sifreprev.Margin = new System.Windows.Forms.Padding(0);
            this.tx_sifreprev.Multiline = true;
            this.tx_sifreprev.Name = "tx_sifreprev";
            this.tx_sifreprev.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tx_sifreprev.Size = new System.Drawing.Size(670, 95);
            this.tx_sifreprev.TabIndex = 3;
            this.tx_sifreprev.TextChanged += new System.EventHandler(this.tx_sifreprev_TextChanged);
            // 
            // tx_cozulenmetin
            // 
            this.tx_cozulenmetin.BackColor = System.Drawing.Color.Tan;
            this.tx_cozulenmetin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_cozulenmetin.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_cozulenmetin.ForeColor = System.Drawing.Color.Firebrick;
            this.tx_cozulenmetin.Location = new System.Drawing.Point(794, 232);
            this.tx_cozulenmetin.Margin = new System.Windows.Forms.Padding(0);
            this.tx_cozulenmetin.Multiline = true;
            this.tx_cozulenmetin.Name = "tx_cozulenmetin";
            this.tx_cozulenmetin.ReadOnly = true;
            this.tx_cozulenmetin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tx_cozulenmetin.Size = new System.Drawing.Size(708, 524);
            this.tx_cozulenmetin.TabIndex = 4;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.Crimson;
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_kaydet.Location = new System.Drawing.Point(385, 776);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(174, 47);
            this.btn_kaydet.TabIndex = 6;
            this.btn_kaydet.Text = "Şifrele Ve Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.ForeColor = System.Drawing.Color.Cyan;
            this.btn_temizle.Location = new System.Drawing.Point(148, 776);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(174, 47);
            this.btn_temizle.TabIndex = 10;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(286, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Şifreleme Önizleme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(60, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Metin Giriş:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(791, 203);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Çözülen Şifreli Metin: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(287, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Serhat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(219, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kullanııcı";
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_tarih.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_tarih.Location = new System.Drawing.Point(474, 201);
            this.lbl_tarih.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(215, 20);
            this.lbl_tarih.TabIndex = 17;
            this.lbl_tarih.Text = "3 Ağustos 2020 Pazartesi";
            // 
            // c1_gun
            // 
            this.c1_gun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.c1_gun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.c1_gun.FormattingEnabled = true;
            this.c1_gun.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.c1_gun.Location = new System.Drawing.Point(73, 43);
            this.c1_gun.Name = "c1_gun";
            this.c1_gun.Size = new System.Drawing.Size(61, 32);
            this.c1_gun.TabIndex = 21;
            this.c1_gun.Text = "Gün";
            // 
            // c2_ay
            // 
            this.c2_ay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.c2_ay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.c2_ay.FormattingEnabled = true;
            this.c2_ay.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.c2_ay.Location = new System.Drawing.Point(174, 43);
            this.c2_ay.Name = "c2_ay";
            this.c2_ay.Size = new System.Drawing.Size(132, 32);
            this.c2_ay.TabIndex = 22;
            this.c2_ay.Text = "Ay";
            // 
            // c3_yil
            // 
            this.c3_yil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.c3_yil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.c3_yil.FormattingEnabled = true;
            this.c3_yil.Items.AddRange(new object[] {
            "2025",
            "2024",
            "2023",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014"});
            this.c3_yil.Location = new System.Drawing.Point(343, 43);
            this.c3_yil.Name = "c3_yil";
            this.c3_yil.Size = new System.Drawing.Size(114, 32);
            this.c3_yil.TabIndex = 23;
            this.c3_yil.Text = "Yıl";
            this.c3_yil.SelectedIndexChanged += new System.EventHandler(this.c3_yil_SelectedIndexChanged);
            // 
            // lbl_gun
            // 
            this.lbl_gun.AutoSize = true;
            this.lbl_gun.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gun.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gun.Location = new System.Drawing.Point(1188, 203);
            this.lbl_gun.Name = "lbl_gun";
            this.lbl_gun.Size = new System.Drawing.Size(34, 22);
            this.lbl_gun.TabIndex = 24;
            this.lbl_gun.Text = "....";
            // 
            // lbl_ay
            // 
            this.lbl_ay.AutoSize = true;
            this.lbl_ay.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ay.Location = new System.Drawing.Point(1232, 203);
            this.lbl_ay.Name = "lbl_ay";
            this.lbl_ay.Size = new System.Drawing.Size(40, 22);
            this.lbl_ay.TabIndex = 25;
            this.lbl_ay.Text = ".....";
            // 
            // lbl_yil
            // 
            this.lbl_yil.AutoSize = true;
            this.lbl_yil.BackColor = System.Drawing.Color.Transparent;
            this.lbl_yil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yil.Location = new System.Drawing.Point(1311, 203);
            this.lbl_yil.Name = "lbl_yil";
            this.lbl_yil.Size = new System.Drawing.Size(40, 22);
            this.lbl_yil.TabIndex = 26;
            this.lbl_yil.Text = ".....";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1389, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "tarihli günlük";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.c3_yil);
            this.groupBox1.Controls.Add(this.c2_ay);
            this.groupBox1.Controls.Add(this.c1_gun);
            this.groupBox1.Controls.Add(this.btn_coz);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Lavender;
            this.groupBox1.Location = new System.Drawing.Point(794, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 116);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarih Bilgisi Belirtiniz:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(1077, 765);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 47);
            this.button1.TabIndex = 30;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // anaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1531, 839);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_yil);
            this.Controls.Add(this.lbl_ay);
            this.Controls.Add(this.lbl_gun);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.tx_cozulenmetin);
            this.Controls.Add(this.tx_sifreprev);
            this.Controls.Add(this.tx_metin);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "anaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Günlük";
            this.Load += new System.EventHandler(this.anaEkran_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_metin;
        private System.Windows.Forms.Button btn_coz;
        private System.Windows.Forms.TextBox tx_cozulenmetin;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tx_sifreprev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.ComboBox c1_gun;
        private System.Windows.Forms.ComboBox c2_ay;
        private System.Windows.Forms.ComboBox c3_yil;
        private System.Windows.Forms.Label lbl_gun;
        private System.Windows.Forms.Label lbl_ay;
        private System.Windows.Forms.Label lbl_yil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}