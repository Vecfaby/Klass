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
    public partial class FormPosechaemost9 : Form
    {
        public FormPosechaemost9()
        {
            InitializeComponent();
        }

        private void FormPosechaemost9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDataSet.students9". При необходимости она может быть перемещена или удалена.
            this.students9TableAdapter.Fill(this.klassDataSet.students9);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDataSet.posechaemost9". При необходимости она может быть перемещена или удалена.
            this.posechaemost9TableAdapter1.Fill(this.klassDataSet.posechaemost9);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.posechaemost9". При необходимости она может быть перемещена или удалена.
            this.posechaemost9TableAdapter.Fill(this.klassDSet.posechaemost9);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try { 
            posechaemost9TableAdapter1.Update(klassDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
            }
            catch (Exception)
            {

                MessageBox.Show("Возникло исключение!");

            }
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            posechaemost9DataGridView.Rows.RemoveAt(posechaemost9DataGridView.CurrentCell.RowIndex);
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
