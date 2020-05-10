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
    public partial class FormPosechaemost5 : Form
    {
        public FormPosechaemost5()
        {
            InitializeComponent();
        }

        private void FormPosechaemost5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.posechaemost5". При необходимости она может быть перемещена или удалена.
            this.posechaemost5TableAdapter.Fill(this.klassDSet.posechaemost5);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            posechaemost5TableAdapter.Update(klassDSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            posechaemost5DataGridView.Rows.RemoveAt(posechaemost5DataGridView.CurrentCell.RowIndex);
            MessageBox.Show("Запись удалена из базы данных");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Stud5 k5 = new Stud5();
            k5.Left = this.Left;
            k5.Top = this.Top;
            k5.Show();
            this.Hide();
        }
    }
}
