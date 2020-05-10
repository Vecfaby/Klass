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
    public partial class FormRukEdit : Form
    {
        public FormRukEdit()
        {
            InitializeComponent();
        }

        private void klass_rukBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.klass_rukBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassDatSet);

        }

        private void FormRukEdit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.Klass_ruk". При необходимости она может быть перемещена или удалена.
            this.klass_rukTableAdapter1.Fill(this.klassDSet.Klass_ruk);    
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            klass_rukTableAdapter1.Update(klassDSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            klass_rukDataGridView.Rows.RemoveAt(klass_rukDataGridView.CurrentCell.RowIndex);
            MessageBox.Show("Запись удалена из базы данных");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormRuk ruk = new FormRuk();
            ruk.Left = this.Left;
            ruk.Top = this.Top;
            ruk.Show();
            this.Hide();
        }
    }
}
