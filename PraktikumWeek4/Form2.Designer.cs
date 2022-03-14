
namespace PraktikumWeek4
{
    partial class Form2
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
            this.labelNama = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelTelp = new System.Windows.Forms.Label();
            this.labelOutputNama = new System.Windows.Forms.Label();
            this.labelOutputAlamat = new System.Windows.Forms.Label();
            this.labelOutputTelp = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnPrevData = new System.Windows.Forms.Button();
            this.btnNextData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(13, 13);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(45, 15);
            this.labelNama.TabIndex = 0;
            this.labelNama.Text = "Nama :";
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Location = new System.Drawing.Point(13, 57);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(51, 15);
            this.labelAlamat.TabIndex = 1;
            this.labelAlamat.Text = "Alamat :";
            // 
            // labelTelp
            // 
            this.labelTelp.AutoSize = true;
            this.labelTelp.Location = new System.Drawing.Point(13, 101);
            this.labelTelp.Name = "labelTelp";
            this.labelTelp.Size = new System.Drawing.Size(34, 15);
            this.labelTelp.TabIndex = 2;
            this.labelTelp.Text = "Telp :";
            // 
            // labelOutputNama
            // 
            this.labelOutputNama.AutoSize = true;
            this.labelOutputNama.Location = new System.Drawing.Point(100, 13);
            this.labelOutputNama.Name = "labelOutputNama";
            this.labelOutputNama.Size = new System.Drawing.Size(38, 15);
            this.labelOutputNama.TabIndex = 3;
            this.labelOutputNama.Text = "label4";
            // 
            // labelOutputAlamat
            // 
            this.labelOutputAlamat.AutoSize = true;
            this.labelOutputAlamat.Location = new System.Drawing.Point(100, 57);
            this.labelOutputAlamat.Name = "labelOutputAlamat";
            this.labelOutputAlamat.Size = new System.Drawing.Size(38, 15);
            this.labelOutputAlamat.TabIndex = 4;
            this.labelOutputAlamat.Text = "label5";
            // 
            // labelOutputTelp
            // 
            this.labelOutputTelp.AutoSize = true;
            this.labelOutputTelp.Location = new System.Drawing.Point(100, 101);
            this.labelOutputTelp.Name = "labelOutputTelp";
            this.labelOutputTelp.Size = new System.Drawing.Size(38, 15);
            this.labelOutputTelp.TabIndex = 5;
            this.labelOutputTelp.Text = "label6";
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(12, 137);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 23);
            this.btnKembali.TabIndex = 6;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnPrevData
            // 
            this.btnPrevData.Location = new System.Drawing.Point(126, 137);
            this.btnPrevData.Name = "btnPrevData";
            this.btnPrevData.Size = new System.Drawing.Size(75, 23);
            this.btnPrevData.TabIndex = 7;
            this.btnPrevData.Text = "Prev Data";
            this.btnPrevData.UseVisualStyleBackColor = true;
            this.btnPrevData.Click += new System.EventHandler(this.btnPrevData_Click);
            // 
            // btnNextData
            // 
            this.btnNextData.Location = new System.Drawing.Point(242, 137);
            this.btnNextData.Name = "btnNextData";
            this.btnNextData.Size = new System.Drawing.Size(75, 23);
            this.btnNextData.TabIndex = 8;
            this.btnNextData.Text = "Next Data";
            this.btnNextData.UseVisualStyleBackColor = true;
            this.btnNextData.Click += new System.EventHandler(this.btnNextData_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 189);
            this.Controls.Add(this.btnNextData);
            this.Controls.Add(this.btnPrevData);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.labelOutputTelp);
            this.Controls.Add(this.labelOutputAlamat);
            this.Controls.Add(this.labelOutputNama);
            this.Controls.Add(this.labelTelp);
            this.Controls.Add(this.labelAlamat);
            this.Controls.Add(this.labelNama);
            this.Name = "Form2";
            this.Text = "Form Tampilan Data";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelTelp;
        private System.Windows.Forms.Label labelOutputNama;
        private System.Windows.Forms.Label labelOutputAlamat;
        private System.Windows.Forms.Label labelOutputTelp;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnPrevData;
        private System.Windows.Forms.Button btnNextData;
    }
}