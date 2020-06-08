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
    public partial class FormPosechaemost8 : Form
    {
        public FormPosechaemost8()
        {
            InitializeComponent();
        }

        private void FormPosechaemost8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDataSet.students8". При необходимости она может быть перемещена или удалена.
            this.students8TableAdapter.Fill(this.klassDataSet.students8);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDataSet.posechaemost8". При необходимости она может быть перемещена или удалена.
            this.posechaemost8TableAdapter1.Fill(this.klassDataSet.posechaemost8);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.posechaemost8". При необходимости она может быть перемещена или удалена.
            this.posechaemost8TableAdapter.Fill(this.klassDSet.posechaemost8);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try { 
            posechaemost8TableAdapter1.Update(klassDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
            }
            catch (Exception)
            {

                MessageBox.Show("Возникло исключение!");

            }
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            posechaemost8DataGridView.Rows.RemoveAt(posechaemost8DataGridView.CurrentCell.RowIndex);
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

        private void posechaemost8DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
