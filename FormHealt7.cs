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
    public partial class FormHealt7 : Form
    {
        public FormHealt7()
        {
            InitializeComponent();
        }

        private void FormHealt7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDataSet.students7". При необходимости она может быть перемещена или удалена.
            this.students7TableAdapter1.Fill(this.klassDataSet.students7);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDataSet.karta_health7". При необходимости она может быть перемещена или удалена.
            this.karta_health7TableAdapter1.Fill(this.klassDataSet.karta_health7);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDataSet1.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.klassDataSet1.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.students7". При необходимости она может быть перемещена или удалена.
            this.students7TableAdapter.Fill(this.klassDSet.students7);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.karta_health7". При необходимости она может быть перемещена или удалена.
            this.karta_health7TableAdapter.Fill(this.klassDSet.karta_health7);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {try { 
            karta_health7TableAdapter1.Update(klassDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
            }
            catch (Exception)
            {

                MessageBox.Show("Возникло исключение!");

            }
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            karta_health7DataGridView.Rows.RemoveAt(karta_health7DataGridView.CurrentCell.RowIndex);
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

        private void karta_health7DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
