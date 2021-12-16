using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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


        

       

        void Loading(string sql) //Способ загрузки таблицы
        {
            string connectionString = (conStr);
    
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                connection.Close();
            }
        }


        private void ClientForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 250);
            
            Loading("SELECT * FROM Client"); //В скобку пишется командная строка для SQL
            dataGridView1.Columns["PhotoPath"].Visible = false;
        }

        private void btn_switch_over_EnterForm(object sender, EventArgs e)
        {
            
            
        }


        private void btn_Sort_AZ(object sender, EventArgs e)
        {
            Loading("SELECT * FROM Client ORDER BY LastName");
        }

        private void btn_Top10(object sender, EventArgs e)
        {
            Loading("SELECT TOP(10) * FROM Client");
        }

        private void btn_Top50(object sender, EventArgs e)
        {
            Loading("SELECT TOP(50) * FROM Client");
        }

        private void btn_Top200(object sender, EventArgs e)
        {
            Loading("SELECT TOP(200) * FROM Client");
        }

        private void btn_SizeAll(object sender, EventArgs e)
        {
            Loading("SELECT * FROM Client");
        }

        


        private void button11_Click(object sender, EventArgs e)
        {
            Loading("SELECT * FROM Client WHERE GenderCode = 'ж'");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Loading("SELECT * FROM Client ORDER BY RegistrationDate ASC");

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Loading("SELECT * FROM Client WHERE GenderCode = 'м'");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            CreateClient newCreateClient = new CreateClient();
            newCreateClient.Show();
            
        }

        private void btn_Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            CreateClient newCreateClient = new CreateClient();
            newCreateClient.Show();
            
        }
    }
}
