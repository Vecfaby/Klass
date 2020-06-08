using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klass
{
    public partial class FormStudent9 : Form
    {
        public FormStudent9()
        {
            InitializeComponent();
        }

        private void students5DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormStudent9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassDSet.students9". При необходимости она может быть перемещена или удалена.
            this.students9TableAdapter.Fill(this.klassDSet.students9);
            SqlConnection con = new SqlConnection("Data Source='.\\SQLEXPRESS';Integrated Security='true';Initial Catalog='Klass'");
            SqlCommand cmd = new SqlCommand("SELECT name_student FROM students9", con);
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

        private void buttonPoisk_Click(object sender, EventArgs e)
        {
            students9BindingSource.Filter = "name_student = \'" + textBoxSearch.Text + "\'";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            students9TableAdapter.Update(klassDSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonOtobr_Click(object sender, EventArgs e)
        {
            students9BindingSource.Filter = null;
            textBoxSearch.Clear();
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
            worksheet.Name = "Ученики 9 класса";
            // сохраняем часть заголовка в Excel  
            for (int i = 1; i < students9DataGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = students9DataGridView.Columns[i - 1].HeaderText;
            }
            // сохраняем значение каждой строки и столбца в листе Excel  
            for (int i = 0; i < students9DataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < students9DataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = students9DataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            // сохранить приложение  
            
            MessageBox.Show("Данные экспортированы");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            students9DataGridView.Rows.RemoveAt(students9DataGridView.CurrentCell.RowIndex);
            MessageBox.Show("Запись удалена из базы данных");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Stud9 k9 = new Stud9();
            k9.Left = this.Left;
            k9.Top = this.Top;
            k9.Show();
            this.Hide();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(students9DataGridView.Size.Width + 10, students9DataGridView.Size.Height + 10);
            students9DataGridView.DrawToBitmap(bmp, students9DataGridView.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
