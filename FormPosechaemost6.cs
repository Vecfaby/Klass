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
    public partial class FormPosechaemost6 : Form
    {
        public FormPosechaemost6()
        {
            InitializeComponent();
        }

        private void FormPosechaemost6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.posechaemost6". При необходимости она может быть перемещена или удалена.
            this.posechaemost6TableAdapter.Fill(this.klassDSet.posechaemost6);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            posechaemost6TableAdapter.Update(klassDSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            posechaemost6DataGridView.Rows.RemoveAt(posechaemost6DataGridView.CurrentCell.RowIndex);
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
