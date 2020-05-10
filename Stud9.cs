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
    public partial class Stud9 : Form
    {
        public Stud9()
        {
            InitializeComponent();
        }

        private void Stud9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.students9". При необходимости она может быть перемещена или удалена.
            this.students9TableAdapter.Fill(this.klassDSet.students9);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormRoditeli9 r9 = new FormRoditeli9();
            r9.Left = this.Left;
            r9.Top = this.Top;
            r9.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormVedomost9 v9 = new FormVedomost9();
            v9.Left = this.Left;
            v9.Top = this.Top;
            v9.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHealt9 h9 = new FormHealt9();
            h9.Left = this.Left;
            h9.Top = this.Top;
            h9.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPosechaemost9 p9 = new FormPosechaemost9();
            p9.Left = this.Left;
            p9.Top = this.Top;
            p9.Show();
        }

        private void buttonPoisk_Click(object sender, EventArgs e)
        {
            FormStudent9 s9 = new FormStudent9();
            s9.Left = this.Left;
            s9.Top = this.Top;
            s9.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
