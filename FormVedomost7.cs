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
    public partial class FormVedomost7 : Form
    {
        public FormVedomost7()
        {
            InitializeComponent();
        }

        private void FormVedomost7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.vedomost7". При необходимости она может быть перемещена или удалена.
            this.vedomost7TableAdapter.Fill(this.klassDSet.vedomost7);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            vedomost7TableAdapter.Update(klassDSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            vedomost7DataGridView.Rows.RemoveAt(vedomost7DataGridView.CurrentCell.RowIndex);
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

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0, aver = 0;
            int count = 0;
            foreach (DataGridViewCell cell in vedomost7DataGridView.SelectedCells)
            {
                double value = 0;
                if (cell.Value != null & double.TryParse(cell.Value.ToString(), out value))
                {
                    sum += value;
                    count++;
                }
            }
            aver = sum / count;
            MessageBox.Show(aver.ToString(),"Средняя оценка ");
        }
    }
}
