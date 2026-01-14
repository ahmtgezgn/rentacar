namespace rentacar
{
    partial class Vitrin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKirala = new System.Windows.Forms.Button();
            this.txtGun = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpGuvenlik = new System.Windows.Forms.GroupBox();
            this.rbFull = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbMini = new System.Windows.Forms.RadioButton();
            this.rbYok = new System.Windows.Forms.RadioButton();
            this.pctAracResim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpGuvenlik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAracResim)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 293);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnKirala);
            this.groupBox1.Controls.Add(this.txtGun);
            this.groupBox1.Controls.Add(this.txtTC);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.lblFiyat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1184, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 345);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiralama İşlemi";
            // 
            // btnKirala
            // 
            this.btnKirala.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKirala.Location = new System.Drawing.Point(6, 168);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(211, 38);
            this.btnKirala.TabIndex = 10;
            this.btnKirala.Text = "KİRALA";
            this.btnKirala.UseVisualStyleBackColor = true;
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // txtGun
            // 
            this.txtGun.Location = new System.Drawing.Point(137, 86);
            this.txtGun.Name = "txtGun";
            this.txtGun.Size = new System.Drawing.Size(100, 20);
            this.txtGun.TabIndex = 9;
            this.txtGun.TextChanged += new System.EventHandler(this.txtGun_TextChanged);
            this.txtGun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGun_KeyPress);
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(137, 9);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 8;
            this.txtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTC_KeyPress);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(137, 35);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 7;
            this.txtAdSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdSoyad_KeyPress);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(137, 61);
            this.txtTel.MaxLength = 12;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 6;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(180, 122);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(13, 13);
            this.lblFiyat.TabIndex = 5;
            this.lblFiyat.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Toplam Tutar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kaç Gün:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // grpGuvenlik
            // 
            this.grpGuvenlik.BackColor = System.Drawing.Color.Transparent;
            this.grpGuvenlik.Controls.Add(this.rbFull);
            this.grpGuvenlik.Controls.Add(this.rbOrta);
            this.grpGuvenlik.Controls.Add(this.rbMini);
            this.grpGuvenlik.Controls.Add(this.rbYok);
            this.grpGuvenlik.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpGuvenlik.Location = new System.Drawing.Point(12, 321);
            this.grpGuvenlik.Name = "grpGuvenlik";
            this.grpGuvenlik.Size = new System.Drawing.Size(531, 270);
            this.grpGuvenlik.TabIndex = 12;
            this.grpGuvenlik.TabStop = false;
            this.grpGuvenlik.Text = "Güvence Paketleri (Opsiyonel)";
            // 
            // rbFull
            // 
            this.rbFull.AutoSize = true;
            this.rbFull.Location = new System.Drawing.Point(11, 156);
            this.rbFull.Name = "rbFull";
            this.rbFull.Size = new System.Drawing.Size(383, 29);
            this.rbFull.TabIndex = 3;
            this.rbFull.Text = "Full Güvence (+1000 TL/Gün)";
            this.rbFull.UseVisualStyleBackColor = true;
            this.rbFull.CheckedChanged += new System.EventHandler(this.rbFull_CheckedChanged);
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(11, 121);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(343, 29);
            this.rbOrta.TabIndex = 2;
            this.rbOrta.Text = "Orta Paket (+750 TL/Gün)";
            this.rbOrta.UseVisualStyleBackColor = true;
            this.rbOrta.CheckedChanged += new System.EventHandler(this.rbOrta_CheckedChanged);
            // 
            // rbMini
            // 
            this.rbMini.AutoSize = true;
            this.rbMini.Location = new System.Drawing.Point(11, 90);
            this.rbMini.Name = "rbMini";
            this.rbMini.Size = new System.Drawing.Size(340, 29);
            this.rbMini.TabIndex = 1;
            this.rbMini.Text = "Mini Paket (+450 TL/Gün)";
            this.rbMini.UseVisualStyleBackColor = true;
            this.rbMini.CheckedChanged += new System.EventHandler(this.rbMini_CheckedChanged);
            // 
            // rbYok
            // 
            this.rbYok.AutoSize = true;
            this.rbYok.Checked = true;
            this.rbYok.Location = new System.Drawing.Point(11, 55);
            this.rbYok.Name = "rbYok";
            this.rbYok.Size = new System.Drawing.Size(313, 29);
            this.rbYok.TabIndex = 0;
            this.rbYok.TabStop = true;
            this.rbYok.Text = "İstemiyorum (Standart)";
            this.rbYok.UseVisualStyleBackColor = true;
            this.rbYok.CheckedChanged += new System.EventHandler(this.rbYok_CheckedChanged);
            // 
            // pctAracResim
            // 
            this.pctAracResim.BackColor = System.Drawing.Color.Transparent;
            this.pctAracResim.Location = new System.Drawing.Point(746, 0);
            this.pctAracResim.Name = "pctAracResim";
            this.pctAracResim.Size = new System.Drawing.Size(715, 293);
            this.pctAracResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctAracResim.TabIndex = 11;
            this.pctAracResim.TabStop = false;
            this.pctAracResim.Click += new System.EventHandler(this.pctAracResim_Click);
            // 
            // Vitrin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::rentacar.Properties.Resources.image1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1493, 803);
            this.Controls.Add(this.grpGuvenlik);
            this.Controls.Add(this.pctAracResim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Vitrin";
            this.Text = "Vitrin";
            this.Load += new System.EventHandler(this.Vitrin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpGuvenlik.ResumeLayout(false);
            this.grpGuvenlik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAracResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKirala;
        private System.Windows.Forms.TextBox txtGun;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.PictureBox pctAracResim;
        private System.Windows.Forms.GroupBox grpGuvenlik;
        private System.Windows.Forms.RadioButton rbFull;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbMini;
        private System.Windows.Forms.RadioButton rbYok;
    }
}