using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Спаровочник_аптекаря
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void apteki_Click(object sender, EventArgs e)
        {
            Form2 aptek = new Form2();
            aptek.Show();
            Hide();
        }

        private void lekarctva_Click(object sender, EventArgs e)
        {
            Form4 lek = new Form4();
            lek.Show();
            Hide();
        }

        private void ckladi_Click(object sender, EventArgs e)
        {
            Form3 cklad = new Form3();
            cklad.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 nal = new Form5();
            nal.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 nalr = new Form6();
            nalr.Show();
            Hide();
        }
    }
}
