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
    public partial class Formzapisi : Form
    {
        public Formzapisi()
        {
            InitializeComponent();
        }

        private void Formzapisi_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDaSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter1.Fill(this.klassDaSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.klassDSet.Users);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            usersTableAdapter1.Update(klassDaSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            usersDataGridView.Rows.RemoveAt(usersDataGridView.CurrentCell.RowIndex);
            MessageBox.Show("Запись удалена из базы данных");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form me = new FormMenu();
            me.Left = this.Left;
            me.Top = this.Top;
            me.Show();
            this.Hide();
        }
    }
}
