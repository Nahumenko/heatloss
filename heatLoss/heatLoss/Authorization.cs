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
using static System.Windows.Forms.MenuStrip;
using static System.Windows.Forms.ToolStripMenuItem;

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
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from users where Login='" + textBUserName.Text + "' and password='" + textBPass.Text + "'";

            OleDbDataReader reder = command.ExecuteReader();
            Form1 main = this.Owner as Form1; //обращение к форме1 как к main, через текущую форму как this
            int count = 0;
            while (reder.Read())
            {
                count++;
            }
            if (count <= 2)
            {
                switch (count)
                {
                    case 1:

                        MessageBox.Show("Логин и пароль верны!");
                        main.редактированиеСправочныхТаблицToolStripMenuItem.Visible = true;
                        main.файлToolStripMenuItem.Visible = true;
                        main.войтиToolStripMenuItem.Visible = false;
                        pereprava.check = true;
                        this.Close();



                        break;
                    case 2:
                        MessageBox.Show("Логин и пароль верны! А также есть копия их в БД!!!");
                        break;
                    default:
                        MessageBox.Show("не верный логин и пароль!");

                        break;
                }
            }
            else
            {
                MessageBox.Show("Логин и пароль верны! А также есть копия их в БД.Кол-во повторений= " + count);
            }

            connection.Close();

        }

        private void textBPass_TextChanged(object sender, EventArgs e)
        {
            this.textBPass.PasswordChar = '*';
        }
    }
}
