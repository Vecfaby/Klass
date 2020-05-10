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
    public partial class Stud5 : Form
    {
        public Stud5()
        {
            InitializeComponent();
        }

        private void Stud5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.students5". При необходимости она может быть перемещена или удалена.
            this.students5TableAdapter.Fill(this.klassDSet.students5);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormRoditeli5 r5 = new FormRoditeli5();
            r5.Left = this.Left;
            r5.Top = this.Top;
            r5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormVedomost5 v5 = new FormVedomost5();
            v5.Left = this.Left;
            v5.Top = this.Top;
            v5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHealt5 h5 = new FormHealt5();
            h5.Left = this.Left;
            h5.Top = this.Top;
            h5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPosechaemost5 p5 = new FormPosechaemost5();
            p5.Left = this.Left;
            p5.Top = this.Top;
            p5.Show();
        }

        private void buttonPoisk_Click(object sender, EventArgs e)
        {
            FormStudent5 s5 = new FormStudent5();
            s5.Left = this.Left;
            s5.Top = this.Top;
            s5.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
