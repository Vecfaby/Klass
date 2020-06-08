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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDataSet.students6". При необходимости она может быть перемещена или удалена.
            this.students6TableAdapter.Fill(this.klassDataSet.students6);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDataSet.karta_health6". При необходимости она может быть перемещена или удалена.
            this.karta_health6TableAdapter2.Fill(this.klassDataSet.karta_health6);
            
            

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try { 
            karta_health6TableAdapter2.Update(klassDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
            }
            catch (Exception)
            {

                MessageBox.Show("Возникло исключение!");

            }
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

        private void karta_health6DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
