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
    public partial class FormVedomost5 : Form
    {
        public FormVedomost5()
        {
            InitializeComponent();
        }

       

        private void FormVedomost5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.students5". При необходимости она может быть перемещена или удалена.
            this.students5TableAdapter.Fill(this.klassDSet.students5);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.vedomost5". При необходимости она может быть перемещена или удалена.
            this.vedomost5TableAdapter.Fill(this.klassDSet.vedomost5);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try { 
            vedomost5TableAdapter.Update(klassDSet);
            MessageBox.Show("Изменения сохранены в базе данных");
            }
            catch (Exception)
            {

                MessageBox.Show("Возникло исключение!");

            }
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            vedomost5DataGridView.Rows.RemoveAt(vedomost5DataGridView.CurrentCell.RowIndex);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            double sum = 0, aver = 0;
            int count = 0;
            foreach (DataGridViewCell cell in vedomost5DataGridView.SelectedCells)
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
