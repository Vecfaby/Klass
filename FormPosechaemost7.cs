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
    public partial class FormPosechaemost7 : Form
    {
        public FormPosechaemost7()
        {
            InitializeComponent();
        }

        private void FormPosechaemost7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDataSet.students7". При необходимости она может быть перемещена или удалена.
            this.students7TableAdapter.Fill(this.klassDataSet.students7);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDataSet.posechaemost7". При необходимости она может быть перемещена или удалена.
            this.posechaemost7TableAdapter1.Fill(this.klassDataSet.posechaemost7);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.posechaemost7". При необходимости она может быть перемещена или удалена.
            this.posechaemost7TableAdapter.Fill(this.klassDSet.posechaemost7);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try { 
            posechaemost7TableAdapter1.Update(klassDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
            }
            catch (Exception)
            {

                MessageBox.Show("Возникло исключение!");

            }
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            posechaemost7DataGridView.Rows.RemoveAt(posechaemost7DataGridView.CurrentCell.RowIndex);
            MessageBox.Show("Запись удалена из базы данных");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Stud7 k7 = new Stud7();
            k7.Left = this.Left;
            k7.Top = this.Top;
            k7.Show();
            this.Hide();
        }
    }
}
