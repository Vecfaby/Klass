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
    public partial class FormInst : Form
    {
        public FormInst()
        {
            InitializeComponent();
        }

        private void FormInst_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.instruktion". При необходимости она может быть перемещена или удалена.
            this.instruktionTableAdapter.Fill(this.klassDSet.instruktion);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            instruktionTableAdapter.Update(klassDSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            zhurnal_TBDataGridView.Rows.RemoveAt(zhurnal_TBDataGridView.CurrentCell.RowIndex);
            MessageBox.Show("Запись удалена из базы данных");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormZhurnal zh = new FormZhurnal();
            zh.Left = this.Left;
            zh.Top = this.Top;
            zh.Show();
            this.Hide();
        }
    }
}
