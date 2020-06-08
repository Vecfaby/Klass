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
    public partial class FormVedomost9 : Form
    {
        public FormVedomost9()
        {
            InitializeComponent();
        }

        private void FormVedomost9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDataSet.students9". При необходимости она может быть перемещена или удалена.
            this.students9TableAdapter.Fill(this.klassDataSet.students9);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDataSet.vedomost9". При необходимости она может быть перемещена или удалена.
            this.vedomost9TableAdapter1.Fill(this.klassDataSet.vedomost9);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.vedomost9". При необходимости она может быть перемещена или удалена.
            this.vedomost9TableAdapter.Fill(this.klassDSet.vedomost9);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try { 
            vedomost9TableAdapter1.Update(klassDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
            }
            catch (Exception)
            {

                MessageBox.Show("Возникло исключение!");

            }
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            vedomost9DataGridView.Rows.RemoveAt(vedomost9DataGridView.CurrentCell.RowIndex);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            double sum = 0, aver = 0;
            int count = 0;
            foreach (DataGridViewCell cell in vedomost9DataGridView.SelectedCells)
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
