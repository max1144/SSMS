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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lukyanenkoDataSet.нал_лек_в_апт". При необходимости она может быть перемещена или удалена.
            this.нал_лек_в_аптTableAdapter.Fill(this.lukyanenkoDataSet.нал_лек_в_апт);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 hom = new Form1();
            hom.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.нал_лек_в_аптTableAdapter.Update(this.lukyanenkoDataSet.нал_лек_в_апт);
        }
    }
}
