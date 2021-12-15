using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toloknov_YP
{
    public partial class EnterForm : Form
    {
        public EnterForm()
        {
            InitializeComponent();
        }

        private void btn_Clients_Click(object sender, EventArgs e)
        {
            ClientForm newGroupForm = new ClientForm();
            newGroupForm.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EnterForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 250);
        }
    }
}
