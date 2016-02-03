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
            OleDbConnection conection = new OleDbConnection();
            conection.ConnectionString = @"";

        }
    }
}
