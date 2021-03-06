﻿using System;
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
    public partial class FormVneurochnaya : Form
    {
        public FormVneurochnaya()
        {
            InitializeComponent();
        }

        private void FormVneurochnaya_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.vneurochnaya_deyatelnost". При необходимости она может быть перемещена или удалена.
            this.vneurochnaya_deyatelnostTableAdapter.Fill(this.klassDSet.vneurochnaya_deyatelnost);
           

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            vneurochnaya_deyatelnostTableAdapter.Update(klassDSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            vneDataGridView.Rows.RemoveAt(vneDataGridView.CurrentCell.RowIndex);
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
