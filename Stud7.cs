using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klass
{
    public partial class Stud7 : Form
    {
        public Stud7()
        {
            InitializeComponent();
        }

        private void Stud7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.students7". При необходимости она может быть перемещена или удалена.
            this.students7TableAdapter.Fill(this.klassDSet.students7);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormRoditeli7 r7 = new FormRoditeli7();
            r7.Left = this.Left;
            r7.Top = this.Top;
            r7.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormVedomost7 v7 = new FormVedomost7();
            v7.Left = this.Left;
            v7.Top = this.Top;
            v7.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHealt7 h7 = new FormHealt7();
            h7.Left = this.Left;
            h7.Top = this.Top;
            h7.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPosechaemost7 p7 = new FormPosechaemost7();
            p7.Left = this.Left;
            p7.Top = this.Top;
            p7.Show();
        }

        private void buttonPoisk_Click(object sender, EventArgs e)
        {
            FormStudent7 s7 = new FormStudent7();
            s7.Left = this.Left;
            s7.Top = this.Top;
            s7.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
