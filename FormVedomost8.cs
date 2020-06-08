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
    public partial class FormVedomost8 : Form
    {
        public FormVedomost8()
        {
            InitializeComponent();
        }

        private void FormVedomost8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDataSet.students8". При необходимости она может быть перемещена или удалена.
            this.students8TableAdapter.Fill(this.klassDataSet.students8);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDataSet.vedomost8". При необходимости она может быть перемещена или удалена.
            this.vedomost8TableAdapter1.Fill(this.klassDataSet.vedomost8);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.vedomost8". При необходимости она может быть перемещена или удалена.
            this.vedomost8TableAdapter.Fill(this.klassDSet.vedomost8);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try { 
            vedomost8TableAdapter1.Update(klassDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }
            catch (Exception)
            {

                MessageBox.Show("Возникло исключение!");

            }
}

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            vedomost8DataGridView.Rows.RemoveAt(vedomost8DataGridView.CurrentCell.RowIndex);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            double sum = 0, aver = 0;
            int count = 0;
            foreach (DataGridViewCell cell in vedomost8DataGridView.SelectedCells)
            {
                double value = 0;
                if (cell.Value != null & double.TryParse(cell.Value.ToString(), out value))
                {
                    sum += value;
                    count++;
                }
            }
            aver = sum / count;
            MessageBox.Show(aver.ToString(), "Средняя оценка ");
            }
            catch (Exception)
            {

                MessageBox.Show("Возникло исключение!");

            }
        }
    }
}
