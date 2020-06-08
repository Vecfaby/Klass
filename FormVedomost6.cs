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
    public partial class FormVedomost6 : Form
    {
        public FormVedomost6()
        {
            InitializeComponent();
        }

        private void FormVedomost6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDataSet.students6". При необходимости она может быть перемещена или удалена.
            this.students6TableAdapter.Fill(this.klassDataSet.students6);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDataSet.vedomost6". При необходимости она может быть перемещена или удалена.
            this.vedomost6TableAdapter1.Fill(this.klassDataSet.vedomost6);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.vedomost6". При необходимости она может быть перемещена или удалена.
            this.vedomost6TableAdapter.Fill(this.klassDSet.vedomost6);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try{
                vedomost6TableAdapter1.Update(klassDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
            }
            catch (Exception)
            {

                MessageBox.Show("Возникло исключение!");

            }
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            vedomost6DataGridView.Rows.RemoveAt(vedomost6DataGridView.CurrentCell.RowIndex);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            double sum = 0, aver = 0;
            int count = 0;
            foreach (DataGridViewCell cell in vedomost6DataGridView.SelectedCells)
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
