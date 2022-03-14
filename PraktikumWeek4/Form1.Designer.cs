
namespace PraktikumWeek4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNama = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelTelp = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtBoxNama = new System.Windows.Forms.TextBox();
            this.txtBoxAlamat = new System.Windows.Forms.TextBox();
            this.txtBoxTelp = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnLihatData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(12, 9);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(45, 15);
            this.labelNama.TabIndex = 0;
            this.labelNama.Text = "Nama :";
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Location = new System.Drawing.Point(12, 43);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(51, 15);
            this.labelAlamat.TabIndex = 1;
            this.labelAlamat.Text = "Alamat :";
            // 
            // labelTelp
            // 
            this.labelTelp.AutoSize = true;
            this.labelTelp.Location = new System.Drawing.Point(12, 79);
            this.labelTelp.Name = "labelTelp";
            this.labelTelp.Size = new System.Drawing.Size(34, 15);
            this.labelTelp.TabIndex = 2;
            this.labelTelp.Text = "Telp :";
            // 
            // txtBoxNama
            // 
            this.txtBoxNama.Location = new System.Drawing.Point(69, 6);
            this.txtBoxNama.Name = "txtBoxNama";
            this.txtBoxNama.Size = new System.Drawing.Size(292, 23);
            this.txtBoxNama.TabIndex = 3;
            // 
            // txtBoxAlamat
            // 
            this.txtBoxAlamat.Location = new System.Drawing.Point(69, 40);
            this.txtBoxAlamat.Name = "txtBoxAlamat";
            this.txtBoxAlamat.Size = new System.Drawing.Size(409, 23);
            this.txtBoxAlamat.TabIndex = 4;
            // 
            // txtBoxTelp
            // 
            this.txtBoxTelp.Location = new System.Drawing.Point(69, 79);
            this.txtBoxTelp.Name = "txtBoxTelp";
            this.txtBoxTelp.Size = new System.Drawing.Size(166, 23);
            this.txtBoxTelp.TabIndex = 5;
            this.txtBoxTelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTelp_KeyPress);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(12, 133);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnLihatData
            // 
            this.btnLihatData.Location = new System.Drawing.Point(117, 133);
            this.btnLihatData.Name = "btnLihatData";
            this.btnLihatData.Size = new System.Drawing.Size(75, 23);
            this.btnLihatData.TabIndex = 7;
            this.btnLihatData.Text = "Lihat Data";
            this.btnLihatData.UseVisualStyleBackColor = true;
            this.btnLihatData.Click += new System.EventHandler(this.btnLihatData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 189);
            this.Controls.Add(this.btnLihatData);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtBoxTelp);
            this.Controls.Add(this.txtBoxAlamat);
            this.Controls.Add(this.txtBoxNama);
            this.Controls.Add(this.labelTelp);
            this.Controls.Add(this.labelAlamat);
            this.Controls.Add(this.labelNama);
            this.Name = "Form1";
            this.Text = "Form Penambahan Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelTelp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtBoxNama;
        private System.Windows.Forms.TextBox txtBoxAlamat;
        private System.Windows.Forms.TextBox txtBoxTelp;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnLihatData;
    }
}

