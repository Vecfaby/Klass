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
    public partial class FormHealt9 : Form
    {
        public FormHealt9()
        {
            InitializeComponent();
        }

        private void FormHealt9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.karta_health9". При необходимости она может быть перемещена или удалена.
            this.karta_health9TableAdapter.Fill(this.klassDSet.karta_health9);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            karta_health9TableAdapter.Update(klassDSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            karta_health9DataGridView.Rows.RemoveAt(karta_health9DataGridView.CurrentCell.RowIndex);
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
    }
}
