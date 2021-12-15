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

namespace Toloknov_YP
{
    public partial class ClientForm : Form
    {
        static string conStr = "Data Source=10.10.1.24;Initial Catalog=YP_Toloknov;Persist Security Info=True;User ID=pro-41;Password=Pro_41student";
        public ClientForm()
        {
            InitializeComponent();
        }

        void Restart() //Способ обновления таблицы
        {
            string connectionString = (conStr);
            string sql = "SELECT * FROM Client";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }







        private void ClientForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 250);
            string connectionString = (conStr);
            string sql = "SELECT * FROM Client";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            EnterForm newEnterForm = new EnterForm();
            newEnterForm.Show();
        }
    }
}
