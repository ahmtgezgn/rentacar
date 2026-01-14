namespace rentacar
{
    partial class AnaMenu
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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnVitrin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.FlatAppearance.BorderSize = 2;
            this.btnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnAdmin.Location = new System.Drawing.Point(748, 293);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(160, 46);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = " YÖNETİCİ GİRİŞİ";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnVitrin
            // 
            this.btnVitrin.BackColor = System.Drawing.Color.Transparent;
            this.btnVitrin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVitrin.FlatAppearance.BorderSize = 2;
            this.btnVitrin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnVitrin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnVitrin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVitrin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVitrin.Location = new System.Drawing.Point(748, 345);
            this.btnVitrin.Name = "btnVitrin";
            this.btnVitrin.Size = new System.Drawing.Size(160, 51);
            this.btnVitrin.TabIndex = 1;
            this.btnVitrin.Text = "MÜŞTERİ ";
            this.btnVitrin.UseCompatibleTextRendering = true;
            this.btnVitrin.UseVisualStyleBackColor = false;
            this.btnVitrin.Click += new System.EventHandler(this.btnVitrin_Click);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::rentacar.Properties.Resources.Gemini_Generated_Image_ts2fdkts2fdkts2f;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1482, 839);
            this.Controls.Add(this.btnVitrin);
            this.Controls.Add(this.btnAdmin);
            this.DoubleBuffered = true;
            this.Name = "AnaMenu";
            this.Text = "AnaMenu";
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnVitrin;
    }
}