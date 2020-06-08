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
    public partial class Stud6 : Form
    {
        public Stud6()
        {
            InitializeComponent();
        }

        private void Stud6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDaSet.students6". При необходимости она может быть перемещена или удалена.
            this.students6TableAdapter2.Fill(this.klassDaSet.students6);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDataSet.students6". При необходимости она может быть перемещена или удалена.
            this.students6TableAdapter1.Fill(this.klassDataSet.students6);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.students6". При необходимости она может быть перемещена или удалена.
            this.students6TableAdapter.Fill(this.klassDSet.students6);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.students5". При необходимости она может быть перемещена или удалена.
            this.students5TableAdapter.Fill(this.klassDSet.students5);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormRoditeli6 r6 = new FormRoditeli6();
            r6.Left = this.Left;
            r6.Top = this.Top;
            r6.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormVedomost6 v6 = new FormVedomost6();
            v6.Left = this.Left;
            v6.Top = this.Top;
            v6.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHealt6 h6 = new FormHealt6();
            h6.Left = this.Left;
            h6.Top = this.Top;
            h6.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPosechaemost6 p6 = new FormPosechaemost6();
            p6.Left = this.Left;
            p6.Top = this.Top;
            p6.Show();
            this.Hide();
        }

        private void buttonPoisk_Click(object sender, EventArgs e)
        {
            FormStudent6 s6 = new FormStudent6();
            s6.Left = this.Left;
            s6.Top = this.Top;
            s6.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormAutor aaa = new FormAutor();
            aaa.Left = this.Left;
            aaa.Top = this.Top;
            aaa.Show();
           
        }
    }
}
