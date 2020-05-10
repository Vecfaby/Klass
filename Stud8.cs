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
    public partial class Stud8 : Form
    {
        public Stud8()
        {
            InitializeComponent();
        }

        private void Stud8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.students8". При необходимости она может быть перемещена или удалена.
            this.students8TableAdapter.Fill(this.klassDSet.students8);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormRoditeli8 r8 = new FormRoditeli8();
            r8.Left = this.Left;
            r8.Top = this.Top;
            r8.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormVedomost8 v8 = new FormVedomost8();
            v8.Left = this.Left;
            v8.Top = this.Top;
            v8.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHealt8 h8 = new FormHealt8();
            h8.Left = this.Left;
            h8.Top = this.Top;
            h8.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPosechaemost8 p8 = new FormPosechaemost8();
            p8.Left = this.Left;
            p8.Top = this.Top;
            p8.Show();
        }

        private void buttonPoisk_Click(object sender, EventArgs e)
        {
            FormStudent8 s8 = new FormStudent8();
            s8.Left = this.Left;
            s8.Top = this.Top;
            s8.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
