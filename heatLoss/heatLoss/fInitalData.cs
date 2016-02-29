using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heatLoss
{
    public partial class fInitalData : Form
    {
        public fInitalData()
        {
            InitializeComponent();

        }

        private void fInitalData_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.season". При необходимости она может быть перемещена или удалена.
            this.seasonTableAdapter.Fill(this._BD01_02_2016DataSet.season);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.temperature". При необходимости она может быть перемещена или удалена.
            this.temperatureTableAdapter.Fill(this._BD01_02_2016DataSet.temperature);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.region". При необходимости она может быть перемещена или удалена.
            this.regionTableAdapter.Fill(this._BD01_02_2016DataSet.region);


        }

        private void cbchoseMouth_CheckedChanged(object sender, EventArgs e)
        {
            if (cbchoseMouth.Checked)
            {
                lblFrom.Visible = true;
                lblTo.Visible = true;
                cbFrom.Visible = true;
                cbTo.Visible = true;
                //this.dgvTemptable.DataSource = this.temperatureTableAdapter.selectSeasonName(Convert.ToInt32(this.cbFrom.Text), Convert.ToInt32(this.cbTo.Text));
            }
            else
            {
                lblFrom.Visible = false;
                lblTo.Visible = false;
                cbFrom.Visible = false;
                cbTo.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // try
            // {
            for (int j = 1; j < dgvTemptable.RowCount; j++) //бегаем по строкам
            {
                for (int i = 1; i < dgvTemptable.ColumnCount; i++) //бегаем по столбцам
                    if (dgvTemptable.Rows[j - 1].Cells[i - 1].Value != null)
                    {
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Таблица не заполнена");
                        break;
                    }
                break;
            }
            // }
            //  catch { }




            /*Hide();
            // тут должен быть код который сохраняет данные в какой-то массив
            //и добавляет кнопку начала рапсчёта на форму  Fcalculation*/
        }

        private void selectSeasonNameToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void cbTo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void cbTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTo.Visible == true)
            {
                this.dgvTemptable.DataSource = this.temperatureTableAdapter.selectSeasonName(Convert.ToInt32(cbFrom.SelectedValue.ToString()), Convert.ToInt32(cbTo.SelectedValue.ToString()), Convert.ToInt32(regionName.SelectedValue.ToString()));
            }


        }

        private void cbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFrom.Visible == true)
            {
                try
                {
                    this.dgvTemptable.DataSource = this.temperatureTableAdapter.selectSeasonName(Convert.ToInt32(cbFrom.SelectedValue.ToString()), Convert.ToInt32(cbTo.SelectedValue.ToString()), Convert.ToInt32(regionName.SelectedValue.ToString()));
                }
                catch { }
            }


        }

        private void season_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbchoseMouth.Checked)
            {
                this.dgvTemptable.DataSource = this.temperatureTableAdapter.selectSeasonName(Convert.ToInt32(cbFrom.SelectedValue.ToString()), Convert.ToInt32(cbTo.SelectedValue.ToString()), Convert.ToInt32(regionName.SelectedValue.ToString()));
            }
            else
            {
                try
                {
                    this.dgvTemptable.DataSource = this.temperatureTableAdapter.selectRegionName(Convert.ToInt32(regionName.SelectedValue.ToString()));
                }
                catch { }
            }
        }

        private void cbBetweenHeating_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBetweenHeating.Checked)
            {
                cbSystemOpen.Visible = true;
                //тут должен быть код который добавит два меж отопительных месяца в таблицу
                // или куда-нибудь в массив
            }
            else
            {
                cbSystemOpen.Visible = false;
            }
        }

        private void cbSystemOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSystemOpen.Checked)
            {
                cbCirculation.Visible = true;

            }
            else
            {
                cbCirculation.Visible = false;
                //код который добавит температуру для Меж отопительного сесяца
                //подача 70
                //обратка 35
            }
        }

        private void cbCirculation_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCirculation.Checked)
            {
                // код который добавит температуру для МЕж отопительного месяца
                // без циркуляции 60
            }
            else
            {
                // код который добавит температуру для МЕж отопительного месяца
                // подача 60
                //обратка 50
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int j = 3; j <= 7; j++) //бегаем по столбцам
            {
                for (int i = 0; i < dgvTemptable.RowCount; i++)
                {
                    dgvTemptable.Rows[i].Cells[j].Value = rnd.Next(-10, 30);
                }
            }
        }

        private void btnMass_Click(object sender, EventArgs e)
        {
            //создаю массив таблицы
            List<InputData> TableList = new List<InputData>();
            

            InputData stringOFtable = new InputData(Convert.ToString(dgvTemptable[0, 0].FormattedValue), 
                                                    Convert.ToDouble(dgvTemptable[1, 0].FormattedValue),
                                                    Convert.ToDouble(dgvTemptable[2, 0].FormattedValue),
                                                    Convert.ToDouble(dgvTemptable[3, 0].FormattedValue),
                                                    Convert.ToDouble(dgvTemptable[4, 0].FormattedValue),   //заебеню одну строку 
                                                    Convert.ToDouble(dgvTemptable[5, 0].FormattedValue),
                                                    Convert.ToDouble(dgvTemptable[6, 0].FormattedValue),
                                                    Convert.ToDouble(dgvTemptable[7, 0].FormattedValue));
            label1.Text = ("1="+stringOFtable.month+" 2="+stringOFtable.Tcrm_vozd);
            TableList.Add(stringOFtable);





        }
    }
}

/*
 private void button1_Click_1(object sender, EventArgs e) //считывание значения с ячейки
        {
            int r = Convert.ToInt32(this.rowsText.Text);
            int c = Convert.ToInt32(this.cellsText.Text);

            label1.Text = this.dgvTemptable.Rows[r-1].Cells[c-1].Value.ToString(); //rows-строка cells-столбец
        }

        private void button2_Click(object sender, EventArgs e) //занесение данных в ячейку
        {
            int r = Convert.ToInt32(this.rowsText.Text);
            int c = Convert.ToInt32(this.cellsText.Text);
            this.dgvTemptable.Rows[r - 1].Cells[c - 1].Value = textBox1.Text;
        }



    */
