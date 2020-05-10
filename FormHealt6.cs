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
    public partial class FormHealt6 : Form
    {
        public FormHealt6()
        {
            InitializeComponent();
        }

        private void FormHealt6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDaSet.karta_health6". При необходимости она может быть перемещена или удалена.
            this.karta_health6TableAdapter1.Fill(this.klassDaSet.karta_health6);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.karta_health6". При необходимости она может быть перемещена или удалена.
            this.karta_health6TableAdapter.Fill(this.klassDSet.karta_health6);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            karta_health6TableAdapter1.Update(klassDaSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            karta_health6DataGridView.Rows.RemoveAt(karta_health6DataGridView.CurrentCell.RowIndex);
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
    }
}
