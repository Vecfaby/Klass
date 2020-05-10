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
    public partial class FormHealt7 : Form
    {
        public FormHealt7()
        {
            InitializeComponent();
        }

        private void FormHealt7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.karta_health7". При необходимости она может быть перемещена или удалена.
            this.karta_health7TableAdapter.Fill(this.klassDSet.karta_health7);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            karta_health7TableAdapter.Update(klassDSet);
            MessageBox.Show("Изменения сохранены в базе данных");
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
    }
}
