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

        void Restart(string sql) //Способ обновления таблицы
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
            
            Restart("SELECT * FROM Client"); //В скобку пишется командная строка для SQL
        }

        private void btn_switch_over_EnterForm(object sender, EventArgs e)
        {
            this.Close();
            EnterForm newEnterForm = new EnterForm();
            newEnterForm.Show();
        }


        private void btn_Sort_AZ(object sender, EventArgs e)
        {
            Restart("SELECT * FROM Client ORDER BY FirstName");
        }

        private void btn_Top10(object sender, EventArgs e)
        {
            Restart("SELECT TOP(10) * FROM Client");
        }

        private void btn_Top50(object sender, EventArgs e)
        {
            Restart("SELECT TOP(50) * FROM Client");
        }

        private void btn_Top200(object sender, EventArgs e)
        {
            Restart("SELECT TOP(200) * FROM Client");
        }

        private void btn_SizeAll(object sender, EventArgs e)
        {
            Restart("SELECT * FROM Client");
        }

        private void btn_TopEnter(object sender, EventArgs e)
        {
            Restart("SELECT TOP("+tb_NumberSort.Text+") * FROM Client");
        }

        









    }
}
