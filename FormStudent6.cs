using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Klass
{
    public partial class FormStudent6 : Form
    {
        public FormStudent6()
        {
            InitializeComponent();
        }

        private void students5DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

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
            worksheet.Name = "Ученики 6 класса";
            // сохраняем часть заголовка в Excel  
            for (int i = 1; i < students6DataGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = students6DataGridView.Columns[i - 1].HeaderText;
            }
            // сохраняем значение каждой строки и столбца в листе Excel  
            for (int i = 0; i < students6DataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < students6DataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = students6DataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            // сохранить приложение  
            
            MessageBox.Show("Данные экспортированы");
        }

        private void buttonPoisk_Click(object sender, EventArgs e)
        {
            students6BindingSource.Filter = "name_student = \'" + textBoxSearch.Text + "\'";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            students6DataGridView.Rows.RemoveAt(students6DataGridView.CurrentCell.RowIndex);
            MessageBox.Show("Запись удалена из базы данных");
        }

        private void buttonOtobr_Click(object sender, EventArgs e)
        {
            students6BindingSource.Filter = null;
            textBoxSearch.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            students6TableAdapter1.Update(klassDaSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Stud6 k6 = new Stud6();
            k6.Left = this.Left;
            k6.Top = this.Top;
            k6.Show();
            this.Hide();
        }

        private void FormStudent6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDaSet.students6". При необходимости она может быть перемещена или удалена.
            this.students6TableAdapter1.Fill(this.klassDaSet.students6);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.students6". При необходимости она может быть перемещена или удалена.
            this.students6TableAdapter.Fill(this.klassDSet.students6);
            SqlConnection con = new SqlConnection("Data Source='.\\SQLEXPRESS';Integrated Security='true';Initial Catalog='Klass'");
            SqlCommand cmd = new SqlCommand("SELECT name_student FROM students6", con);
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

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(students6DataGridView.Size.Width + 10, students6DataGridView.Size.Height + 10);
            students6DataGridView.DrawToBitmap(bmp, students6DataGridView.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
