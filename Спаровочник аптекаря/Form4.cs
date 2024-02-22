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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lukyanenkoDataSet.лекарства". При необходимости она может быть перемещена или удалена.
            this.лекарстваTableAdapter.Fill(this.lukyanenkoDataSet.лекарства);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 hom = new Form1();
            hom.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.лекарстваTableAdapter.Update(this.lukyanenkoDataSet.лекарства);
        }
    }
}
