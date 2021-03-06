﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klass
{
    public partial class FormHealt5 : Form
    {
        
        public FormHealt5()
        {
            InitializeComponent();
        }

        private void FormHealt5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.students5". При необходимости она может быть перемещена или удалена.
            this.students5TableAdapter.Fill(this.klassDSet.students5);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.karta_health5". При необходимости она может быть перемещена или удалена.
            this.karta_health5TableAdapter.Fill(this.klassDSet.karta_health5);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try { 
            karta_health5TableAdapter.Update(klassDSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }
            catch (Exception)
            {

                MessageBox.Show("Для того чтобы удалить данную запись, необходимо удалить строку с данными об ученике из окна Список учащихся 5 класса !");

            }
}

        private void buttonDellete_Click(object sender, EventArgs e)
        
        {
            karta_health5DataGridView.Rows.RemoveAt(karta_health5DataGridView.CurrentCell.RowIndex);
            MessageBox.Show("Запись удалена из базы данных");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Stud5 k5 = new Stud5();
            k5.Left = this.Left;
            k5.Top = this.Top;
            k5.Show();
            this.Hide();
        }
    }
}
