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
    public partial class FormRuk : Form
    {
        public FormRuk()
        {
            InitializeComponent();
        }

        private void klass_rukBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.klass_rukBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassDatSet);

        }

        private void FormRuk_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDatSet.Klass_ruk". При необходимости она может быть перемещена или удалена.
            this.klass_rukTableAdapter.Fill(this.klassDatSet.Klass_ruk);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRukEdit re = new FormRukEdit();
            re.Left = this.Left;
            re.Top = this.Top;
            re.Show();
            this.Hide();
        }

        private void id_klassLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form me = new FormMenu();
            me.Left = this.Left;
            me.Top = this.Top;
            me.Show();
            this.Hide();
        }
    }
}
