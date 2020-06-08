using System;
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
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-QJJ19PD\SQLEXPRESS;Initial Catalog=Klass;Integrated Security=True");
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "INSERT INTO [Users] ([login], [password], [role]) VALUES ('" + loginTextBox.Text + "','" + passwordTextBox.Text + "','" + roleTextBox.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Регистрация прошла успешно");
            FormAuto a = new FormAuto();
            a.Left = this.Left;
            a.Top = this.Top;
            a.Show();
            this.Hide();
        }

        private void FormReg_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source='.\\SQLEXPRESS';Integrated Security='true';Initial Catalog='Klass'");
            SqlCommand cmd = new SqlCommand("SELECT ruk FROM ruk", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection SCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                SCollection.Add(reader.GetString(0));
            }
            roleTextBox.AutoCompleteCustomSource = SCollection;
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAuto a = new FormAuto();
            a.Left = this.Left;
            a.Top = this.Top;
            a.Show();
            this.Hide();
        }

        private void roleTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


      
