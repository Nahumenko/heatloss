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
        public Authorization()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conection = new OleDbConnection();
                conection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BD01.02.2016.mdb";
                conection.Open();
                lblCheckConnection.Text = "conection successful";
                conection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Erorr   " + ex);
            }


        }
    }
}
