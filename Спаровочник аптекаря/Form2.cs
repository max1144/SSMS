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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lukyanenkoDataSet.лекарства". При необходимости она может быть перемещена или удалена.
            this.лекарстваTableAdapter.Fill(this.lukyanenkoDataSet.лекарства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lukyanenkoDataSet.нал_лек_в_апт". При необходимости она может быть перемещена или удалена.
            this.нал_лек_в_аптTableAdapter.Fill(this.lukyanenkoDataSet.нал_лек_в_апт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lukyanenkoDataSet.аптеки". При необходимости она может быть перемещена или удалена.
            this.аптекиTableAdapter.Fill(this.lukyanenkoDataSet.аптеки);

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
            this.аптекиTableAdapter.Update(this.lukyanenkoDataSet.аптеки);
        }

    
    }
}
