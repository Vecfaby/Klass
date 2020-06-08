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
    public partial class FormHealt8 : Form
    {
        public FormHealt8()
        {
            InitializeComponent();
        }

        private void FormHealt8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDataSet.students8". При необходимости она может быть перемещена или удалена.
            this.students8TableAdapter.Fill(this.klassDataSet.students8);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDataSet.karta_health8". При необходимости она может быть перемещена или удалена.
            this.karta_health8TableAdapter1.Fill(this.klassDataSet.karta_health8);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.karta_health8". При необходимости она может быть перемещена или удалена.
            this.karta_health8TableAdapter.Fill(this.klassDSet.karta_health8);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try { 
            karta_health8TableAdapter1.Update(klassDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
            }
            catch (Exception)
            {

                MessageBox.Show("Возникло исключение!");

            }
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            karta_health8DataGridView.Rows.RemoveAt(karta_health8DataGridView.CurrentCell.RowIndex);
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
    }
}
