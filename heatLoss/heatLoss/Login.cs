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
        private OleDbConnection connection = new OleDbConnection();
        public Authorization()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BD01.02.2016.mdb";
        }



        private void Authorization_Load(object sender, EventArgs e)
        {
            try
            {               
                connection.Open();
                lblCheckConnection.Text = "подключение к БД прошло успешно.";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ошибка, скорее всего не подключилась БД. Дальше идёт текст ошибки " + ex);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
           
            connection.Close();
        }
    }
}
