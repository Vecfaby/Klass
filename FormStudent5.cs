﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Klass
{
    public partial class FormStudent5 : Form
    {
        public FormStudent5()
        {
            InitializeComponent();
        }
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }        
            private void buttonPoisk_Click(object sender, EventArgs e)
        {
            students5BindingSource.Filter = "name_student = \'" + textBoxSearch.Text + "\'";
        }
        private void buttonDellete_Click(object sender, EventArgs e)
        {
            students5DataGridView.Rows.RemoveAt(students5DataGridView.CurrentCell.RowIndex);
            MessageBox.Show("Запись удалена из базы данных");
        }
        private void buttonOtobr_Click(object sender, EventArgs e)
        {
            students5BindingSource.Filter = null;
            textBoxSearch.Clear();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            students5TableAdapter.Update(klassDSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }
        private void FormStudent5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.students5". При необходимости она может быть перемещена или удалена.
            this.students5TableAdapter.Fill(this.klassDSet.students5);
            SqlConnection con = new SqlConnection("Data Source='.\\SQLEXPRESS';Integrated Security='true';Initial Catalog='Klass'");
            SqlCommand cmd = new SqlCommand("SELECT name_student FROM students5", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection SCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                SCollection.Add(reader.GetString(0));
            }
            textBoxSearch.AutoCompleteCustomSource = SCollection;
            con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // создаем приложение Excel  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // создаем новую книгу в приложении Excel  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // создаем новый Excelsheet в книге  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // см. лист Excel за программой  
            app.Visible = true;
            // получить ссылку на первый лист. По умолчанию его имя Sheet1.  
            // сохранить ссылку на лист  
            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;
            // меняем имя активного листа  
            worksheet.Name = "Ученики 5 класса";
            // сохраняем часть заголовка в Excel  
            for (int i = 1; i < students5DataGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = students5DataGridView.Columns[i - 1].HeaderText;
            }
            // сохраняем значение каждой строки и столбца в листе Excel  
            for (int i = 0; i < students5DataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < students5DataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = students5DataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            // сохранить приложение             
            MessageBox.Show("Данные экспортированы");
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(students5DataGridView.Size.Width + 10, students5DataGridView.Size.Height + 10);
            students5DataGridView.DrawToBitmap(bmp, students5DataGridView.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Stud5 k5 = new Stud5();
            k5.Left = this.Left;
            k5.Top = this.Top;
            k5.Show();
            this.Hide();
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }



  

     
       