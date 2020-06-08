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
    public partial class FormZhurnal : Form
    {
        public FormZhurnal()
        {
            InitializeComponent();
        }

        private void zhurnal_TBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zhurnal_TBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassDSet);

        }

        private void FormZhurnal_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDataSet.zhurnal_TB". При необходимости она может быть перемещена или удалена.
            this.zhurnal_TBTableAdapter2.Fill(this.klassDataSet.zhurnal_TB);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDaSet.zhurnal_TB". При необходимости она может быть перемещена или удалена.
            this.zhurnal_TBTableAdapter1.Fill(this.klassDaSet.zhurnal_TB);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.zhurnal_TB". При необходимости она может быть перемещена или удалена.
            this.zhurnal_TBTableAdapter.Fill(this.klassDSet.zhurnal_TB);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            zhurnal_TBTableAdapter2.Update(klassDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            zhurnal_TBDataGridView.Rows.RemoveAt(zhurnal_TBDataGridView.CurrentCell.RowIndex);
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormInst me = new FormInst();
            me.Left = this.Left;
            me.Top = this.Top;
            me.Show();
            this.Hide();
        }
    }
}
