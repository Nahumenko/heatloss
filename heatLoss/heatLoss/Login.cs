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
            da = new OleDbDataAdapter("select* from users where login='"+ tbLogin.Text+"' and Password='"+tbPass.Text+ "'", cn);
            da.Fill(dt);
            if (dt.Rows.Count <= 0)
            {
                if (panel1.Height == 0)
                {
                    label1.Text = "Login or password are invalid plese try again";
                }
                else if (panel1.Height == 100)
                {
                    timer2.Start();
                    label1.Text = "";
                }
            }
            else if (dt.Rows.Count > 0)
            {
                if (panel1.Height == 0)
                {
                    label1.Text = "Login Succsufully";
                    timer1.Start();
                }
                else if (panel1.Height == 100)
                {
                    timer2.Start();
                    label1.Text = "";
                }
            }
            dt.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(panel1.Height != 100)
            {
                panel1.Height += 5;
                if(panel1.Height == 100)
                {
                    timer1.Stop();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panel1.Height != 0)
            {
                panel1.Height -= 5;
                if (panel1.Height==0)
                {
                    timer2.Stop();
                }
            }
        }
    }
}
