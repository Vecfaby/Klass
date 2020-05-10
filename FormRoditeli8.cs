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
    public partial class FormRoditeli8 : Form
    {
        public FormRoditeli8()
        {
            InitializeComponent();
        }

        private void roditeli8BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roditeli8BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassDSet);

        }

        private void FormRoditeli8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.roditeli8". При необходимости она может быть перемещена или удалена.
            this.roditeli8TableAdapter.Fill(this.klassDSet.roditeli8);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            roditeli8TableAdapter.Update(klassDSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            roditeli8DataGridView.Rows.RemoveAt(roditeli8DataGridView.CurrentCell.RowIndex);
            MessageBox.Show("Запись удалена из базы данных");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Stud8 k8 = new Stud8();
            k8.Left = this.Left;
            k8.Top = this.Top;
            k8.Show();
            this.Hide();
        }
    }
}
