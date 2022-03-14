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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Form1 balikForm1 = new Form1();
            balikForm1.Show();
            this.Hide();
        }
        public int rows = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            labelOutputNama.Text = Form1.dataOrang.Rows[rows][0].ToString();
            labelOutputAlamat.Text = Form1.dataOrang.Rows[rows][1].ToString();
            labelOutputTelp.Text = Form1.dataOrang.Rows[rows][2].ToString();
        }

        private void btnPrevData_Click(object sender, EventArgs e)
        {
            if (rows == 0)
            {
                string gaBisaDiPrev = "Data sudah data pertama!";
                MessageBox.Show(gaBisaDiPrev);
            }
            else
            {
                rows -= 1;
                labelOutputNama.Text = Form1.dataOrang.Rows[rows][0].ToString();
                labelOutputAlamat.Text = Form1.dataOrang.Rows[rows][1].ToString();
                labelOutputTelp.Text = Form1.dataOrang.Rows[rows][2].ToString();
            }
        }

        private void btnNextData_Click(object sender, EventArgs e)
        {
            if (rows == 9)
            {
                string gaBisaDiNext = "Data sudah data terakhir!";
                MessageBox.Show(gaBisaDiNext);
            }
            else
            {
                rows += 1;
                labelOutputNama.Text = Form1.dataOrang.Rows[rows][0].ToString();
                labelOutputAlamat.Text = Form1.dataOrang.Rows[rows][1].ToString();
                labelOutputTelp.Text = Form1.dataOrang.Rows[rows][2].ToString();
            }
        }
    }
}
