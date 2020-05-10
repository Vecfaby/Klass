using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Klass
{
    class ClassIniDataBase
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-QJJ19PD\SQLEXPRESS;Initial Catalog=Klass;Integrated Security=True"); //это строка подключения базы данных

        public void openConnection()

        {

            if (connection.State == System.Data.ConnectionState.Closed)

                connection.Open();

        }

        public void closeConnection()

        {

            if (connection.State == System.Data.ConnectionState.Open)

                connection.Close();

        }

        public SqlConnection GetConnection()

        {

            return connection;

        }
    }
}
