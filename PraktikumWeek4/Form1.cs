using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static DataTable dataOrang = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataOrang.Columns.Add("Nama");
            dataOrang.Columns.Add("Alamat");
            dataOrang.Columns.Add("Telp");
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            dataOrang.Rows.Add(txtBoxNama.Text.ToString(), txtBoxAlamat.Text.ToString(), txtBoxTelp.Text.ToString());
            if (dataOrang.Rows.Count == 11)
            {
                string penuh = "Data Telah Penuh!";
                MessageBox.Show(penuh);
            }
        }

        private void btnLihatData_Click(object sender, EventArgs e)
        {
            Form2 pindahForm2 = new Form2();
            pindahForm2.Show();
            this.Hide();
        }

        private void txtBoxTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
    }
}
