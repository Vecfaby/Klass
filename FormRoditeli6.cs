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
    public partial class FormRoditeli6 : Form
    {
        public FormRoditeli6()
        {
            InitializeComponent();
        }

        private void roditeli6BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roditeli6BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassDSet);

        }

        private void FormRoditeli6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDataSet.students6". При необходимости она может быть перемещена или удалена.
            this.students6TableAdapter.Fill(this.klassDataSet.students6);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDataSet.roditeli6". При необходимости она может быть перемещена или удалена.
            this.roditeli6TableAdapter1.Fill(this.klassDataSet.roditeli6);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.roditeli6". При необходимости она может быть перемещена или удалена.
            this.roditeli6TableAdapter.Fill(this.klassDSet.roditeli6);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try { 
            roditeli6TableAdapter1.Update(klassDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
            }
            catch (Exception)
            {

                MessageBox.Show("Возникло исключение!");

            }
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            roditeli6DataGridView.Rows.RemoveAt(roditeli6DataGridView.CurrentCell.RowIndex);
            MessageBox.Show("Запись удалена из базы данных");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Stud6 k6 = new Stud6();
            k6.Left = this.Left;
            k6.Top = this.Top;
            k6.Show();
            this.Hide();
        }
    }
}
