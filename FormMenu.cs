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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonRuk_Click(object sender, EventArgs e)
        {
            FormRuk ruk = new FormRuk();
            ruk.Left = this.Left;
            ruk.Top = this.Top;
            ruk.Show();
            this.Hide();
        }

        private void buttonStud_Click(object sender, EventArgs e)
        {
            FormStudents stud = new FormStudents();
            stud.Left = this.Left;
            stud.Top = this.Top;
            stud.Show();
            this.Hide();
        }

        private void buttonZhur_Click(object sender, EventArgs e)
        {
            FormZhurnal zh = new FormZhurnal();
            zh.Left = this.Left;
            zh.Top = this.Top;
            zh.Show();
            this.Hide();
        }

        private void buttonVneur_Click(object sender, EventArgs e)
        {
            FormVneurochnaya vn = new FormVneurochnaya();
            vn.Left = this.Left;
            vn.Top = this.Top;
            vn.Show();
            this.Hide();
        }

        private void buttonzapisi_Click(object sender, EventArgs e)
        {
            Formzapisi z = new Formzapisi();
            z.Left = this.Left;
            z.Top = this.Top;
            z.Show();
            this.Hide();
        }
    }
}
