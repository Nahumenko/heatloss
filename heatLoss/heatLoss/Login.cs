using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace heatLoss
{
    public partial class Authorization : Form
    {
        OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\учеба\заочка\Диплом\heatloss\heatLoss\heatLoss\BD01.02.2016.mdb");
        OleDbDataAdapter da;
        DataTable dt = new DataTable();
        public Authorization()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("select* from users where login='" + tbLogin.Text + "' and Password='" + tbPass.Text + "'", cn);
            da.Fill(dt);
        }
    }
}
