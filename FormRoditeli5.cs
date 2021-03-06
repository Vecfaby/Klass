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
   	        
		
	
    public partial class FormRoditeli5 : Form
    {
        public FormRoditeli5()
        {
            InitializeComponent();
        }

        private void roditeli5BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roditeli5BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassDSet);

        }

        private void FormRoditeli5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.students5". При необходимости она может быть перемещена или удалена.
            this.students5TableAdapter.Fill(this.klassDSet.students5);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.roditeli5". При необходимости она может быть перемещена или удалена.
            this.roditeli5TableAdapter.Fill(this.klassDSet.roditeli5);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                roditeli5TableAdapter.Update(klassDSet);
                MessageBox.Show("Изменения сохранены в базе данных");
            }
            catch (Exception)
            {

                MessageBox.Show("Возникло исключение!");

            }
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            roditeli5DataGridView.Rows.RemoveAt(roditeli5DataGridView.CurrentCell.RowIndex);
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


