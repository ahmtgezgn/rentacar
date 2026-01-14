namespace rentacar
{
    partial class Form1
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
            this.dgwAraclar = new System.Windows.Forms.DataGridView();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.cmbVites = new System.Windows.Forms.ComboBox();
            this.cmbYakit = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pctResim = new System.Windows.Forms.PictureBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTeslimAl = new System.Windows.Forms.Button();
            this.lblToplamKazanc = new System.Windows.Forms.Label();
            this.lblKiradakiArac = new System.Windows.Forms.Label();
            this.lblCiroBaslik = new System.Windows.Forms.Label();
            this.lblkiradakisay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAraclar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctResim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwAraclar
            // 
            this.dgwAraclar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAraclar.Location = new System.Drawing.Point(-8, 388);
            this.dgwAraclar.Name = "dgwAraclar";
            this.dgwAraclar.ReadOnly = true;
            this.dgwAraclar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwAraclar.Size = new System.Drawing.Size(1500, 409);
            this.dgwAraclar.TabIndex = 0;
            this.dgwAraclar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(116, 24);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(100, 20);
            this.txtPlaka.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-1, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plaka";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(0, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(0, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(-3, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Günlük Ücret";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Vites";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(-3, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Yakıt Türü";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(116, 50);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 20);
            this.txtMarka.TabIndex = 8;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(116, 81);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 9;
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(116, 241);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(100, 20);
            this.txtUcret.TabIndex = 10;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DarkBlue;
            this.btnKaydet.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(65, 300);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(183, 40);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Yılı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Renk";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(-1, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Kilometre";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(116, 106);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(100, 20);
            this.txtYil.TabIndex = 17;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(116, 184);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(100, 20);
            this.txtRenk.TabIndex = 18;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(116, 217);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(100, 20);
            this.txtKm.TabIndex = 19;
            // 
            // cmbVites
            // 
            this.cmbVites.FormattingEnabled = true;
            this.cmbVites.Items.AddRange(new object[] {
            "Otomatik",
            "Manuel"});
            this.cmbVites.Location = new System.Drawing.Point(116, 130);
            this.cmbVites.Name = "cmbVites";
            this.cmbVites.Size = new System.Drawing.Size(100, 21);
            this.cmbVites.TabIndex = 20;
            // 
            // cmbYakit
            // 
            this.cmbYakit.FormattingEnabled = true;
            this.cmbYakit.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "LPG",
            "Elektrik",
            "Hibrit"});
            this.cmbYakit.Location = new System.Drawing.Point(116, 157);
            this.cmbYakit.Name = "cmbYakit";
            this.cmbYakit.Size = new System.Drawing.Size(100, 21);
            this.cmbYakit.TabIndex = 21;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnResimSec
            // 
            this.btnResimSec.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResimSec.Location = new System.Drawing.Point(84, 303);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(138, 48);
            this.btnResimSec.TabIndex = 23;
            this.btnResimSec.Text = "RESİM SEÇ";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.txtKm);
            this.groupBox1.Controls.Add(this.cmbYakit);
            this.groupBox1.Controls.Add(this.txtYil);
            this.groupBox1.Controls.Add(this.txtRenk);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbVites);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtPlaka);
            this.groupBox1.Controls.Add(this.txtUcret);
            this.groupBox1.Controls.Add(this.txtMarka);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 348);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pctResim);
            this.groupBox2.Controls.Add(this.btnResimSec);
            this.groupBox2.Location = new System.Drawing.Point(1133, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 372);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resim İşlemleri";
            // 
            // pctResim
            // 
            this.pctResim.Location = new System.Drawing.Point(9, 32);
            this.pctResim.Name = "pctResim";
            this.pctResim.Size = new System.Drawing.Size(327, 265);
            this.pctResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctResim.TabIndex = 22;
            this.pctResim.TabStop = false;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(998, 280);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(129, 48);
            this.btnSil.TabIndex = 26;
            this.btnSil.Text = "ARAÇ SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnTeslimAl
            // 
            this.btnTeslimAl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeslimAl.ForeColor = System.Drawing.Color.Black;
            this.btnTeslimAl.Location = new System.Drawing.Point(998, 334);
            this.btnTeslimAl.Name = "btnTeslimAl";
            this.btnTeslimAl.Size = new System.Drawing.Size(129, 48);
            this.btnTeslimAl.TabIndex = 22;
            this.btnTeslimAl.Text = "ARACI TESLİM AL";
            this.btnTeslimAl.UseVisualStyleBackColor = true;
            this.btnTeslimAl.Click += new System.EventHandler(this.btnTeslimAl_Click);
            // 
            // lblToplamKazanc
            // 
            this.lblToplamKazanc.AutoSize = true;
            this.lblToplamKazanc.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamKazanc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKazanc.ForeColor = System.Drawing.Color.Gray;
            this.lblToplamKazanc.Location = new System.Drawing.Point(878, 349);
            this.lblToplamKazanc.Name = "lblToplamKazanc";
            this.lblToplamKazanc.Size = new System.Drawing.Size(70, 25);
            this.lblToplamKazanc.TabIndex = 27;
            this.lblToplamKazanc.Text = "toplaK";
            this.lblToplamKazanc.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblKiradakiArac
            // 
            this.lblKiradakiArac.AutoSize = true;
            this.lblKiradakiArac.BackColor = System.Drawing.Color.Transparent;
            this.lblKiradakiArac.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKiradakiArac.ForeColor = System.Drawing.Color.DimGray;
            this.lblKiradakiArac.Location = new System.Drawing.Point(880, 291);
            this.lblKiradakiArac.Name = "lblKiradakiArac";
            this.lblKiradakiArac.Size = new System.Drawing.Size(81, 25);
            this.lblKiradakiArac.TabIndex = 28;
            this.lblKiradakiArac.Text = "kiraSAY";
            // 
            // lblCiroBaslik
            // 
            this.lblCiroBaslik.AutoSize = true;
            this.lblCiroBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCiroBaslik.Location = new System.Drawing.Point(692, 346);
            this.lblCiroBaslik.Name = "lblCiroBaslik";
            this.lblCiroBaslik.Size = new System.Drawing.Size(115, 21);
            this.lblCiroBaslik.TabIndex = 29;
            this.lblCiroBaslik.Text = "TOPLAM CİRO";
            // 
            // lblkiradakisay
            // 
            this.lblkiradakisay.AutoSize = true;
            this.lblkiradakisay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkiradakisay.Location = new System.Drawing.Point(692, 294);
            this.lblkiradakisay.Name = "lblkiradakisay";
            this.lblkiradakisay.Size = new System.Drawing.Size(182, 21);
            this.lblkiradakisay.TabIndex = 30;
            this.lblkiradakisay.Text = "KİRADAKİ ARAÇ SAYISI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::rentacar.Properties.Resources.image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1514, 759);
            this.Controls.Add(this.lblkiradakisay);
            this.Controls.Add(this.lblCiroBaslik);
            this.Controls.Add(this.lblKiradakiArac);
            this.Controls.Add(this.lblToplamKazanc);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnTeslimAl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwAraclar);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAraclar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAraclar;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.ComboBox cmbVites;
        private System.Windows.Forms.ComboBox cmbYakit;
        private System.Windows.Forms.PictureBox pctResim;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTeslimAl;
        private System.Windows.Forms.Label lblToplamKazanc;
        private System.Windows.Forms.Label lblKiradakiArac;
        private System.Windows.Forms.Label lblCiroBaslik;
        private System.Windows.Forms.Label lblkiradakisay;
    }
}

