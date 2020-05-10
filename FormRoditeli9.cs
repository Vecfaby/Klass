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
    public partial class FormRoditeli9 : Form
    {
        public FormRoditeli9()
        {
            InitializeComponent();
        }

        private void roditeli9BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roditeli9BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassDSet);

        }

        private void FormRoditeli9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.roditeli9". При необходимости она может быть перемещена или удалена.
            this.roditeli9TableAdapter.Fill(this.klassDSet.roditeli9);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            roditeli9TableAdapter.Update(klassDSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            roditeli9DataGridView.Rows.RemoveAt(roditeli9DataGridView.CurrentCell.RowIndex);
            MessageBox.Show("Запись удалена из базы данных");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Stud9 k9 = new Stud9();
            k9.Left = this.Left;
            k9.Top = this.Top;
            k9.Show();
            this.Hide();



        }
    }
}
