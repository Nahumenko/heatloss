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

        //общий класс
        InputTableData stringOftable;
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
            // чищу массив статического класса
            pereprava.tempTable.Clear();

            //заношу данные в статический класс

            for (int i = 0; i < dgvTemptable.RowCount; i++)
            {
                stringOftable = new InputTableData(Convert.ToString(dgvTemptable[0, i].FormattedValue),
                                                     (Convert.ToDouble(dgvTemptable[1, i].Value)),
                                                     (Convert.ToDouble(dgvTemptable[2, i].Value)),
                                                     (Convert.ToDouble(dgvTemptable[3, i].Value)),
                                                     (Convert.ToDouble(dgvTemptable[4, i].Value)),   //заебеню одну строку 
                                                     (Convert.ToDouble(dgvTemptable[5, i].Value)),
                                                     (Convert.ToDouble(dgvTemptable[6, i].Value)),
                                                     (Convert.ToDouble(dgvTemptable[7, i].Value))
                                                     );

               
                //добавляю данные в статический класс
                pereprava.tempTable.Add(stringOftable);



            }


        }

        private void btnMassReturn_Click(object sender, EventArgs e)
        {
            /*     for (int i = 0; i < dgvTemptable.RowCount; i++)
                 {

                   //   dgvTemptable[0, i].Value
                     MessageBox.Show(calc.tempTable[i].month.ToString());
                     dgvTemptable[1, i].Value = calc.tempTable[i].Tcrm_vozd;
                     dgvTemptable[2, i].Value = calc.tempTable[i].Tcrm_grunt;
                     dgvTemptable[3, i].Value = calc.tempTable[i].Tcrm_H20;
                     dgvTemptable[4, i].Value = calc.tempTable[i].T1_P;
                     dgvTemptable[5, i].Value = calc.tempTable[i].T1_F;
                     dgvTemptable[6, i].Value = calc.tempTable[i].T2_P;
                     dgvTemptable[7, i].Value = calc.tempTable[i].T2_F;
                 }
*/
             }

        private void Data_temps_Click(object sender, EventArgs e)
        {
            double[,] data_temp = new double[14, 5]; // Данные по температурам из отчета
            data_temp[0, 0] = 4.8; data_temp[0, 1] = 61.6; data_temp[0, 2] = 61.6; data_temp[0, 3] = 49; data_temp[0, 4] = 49;
            data_temp[1, 0] = 4.9; data_temp[1, 1] = 60; data_temp[1, 2] = 60; data_temp[1, 3] = 48; data_temp[1, 4] = 48;
            data_temp[2, 0] = 6; data_temp[2, 1] = 60; data_temp[2, 2] = 60; data_temp[2, 3] = 48; data_temp[2, 4] = 48;
            data_temp[3, 0] = 9.1; data_temp[3, 1] = 60; data_temp[3, 2] = 60; data_temp[3, 3] = 48; data_temp[3, 4] = 48;
            data_temp[4, 0] = 14.5; data_temp[4, 1] = 60; data_temp[4, 2] = 60; data_temp[4, 3] = 50; data_temp[4, 4] = 50;
            data_temp[5, 0] = 21.5; data_temp[5, 1] = 60; data_temp[5, 2] = 60; data_temp[5, 3] = 50; data_temp[5, 4] = 50;
            data_temp[6, 0] = 22.7; data_temp[6, 1] = 60; data_temp[6, 2] = 60; data_temp[6, 3] = 50; data_temp[6, 4] = 50;
            data_temp[7, 0] = 21.3; data_temp[7, 1] = 60; data_temp[7, 2] = 60; data_temp[7, 3] = 50; data_temp[7, 4] = 50;
            data_temp[8, 0] = 16.3; data_temp[8, 1] = 60; data_temp[8, 2] = 60; data_temp[8, 3] = 50; data_temp[8, 4] = 50;
            data_temp[9, 0] = 11.6; data_temp[9, 1] = 60; data_temp[9, 2] = 60; data_temp[9, 3] = 48; data_temp[9, 4] = 48;
            data_temp[10, 0] = 9.1; data_temp[10, 1] = 60; data_temp[10, 2] = 60; data_temp[10, 3] = 48; data_temp[10, 4] = 48;
            data_temp[11, 0] = 5.4; data_temp[11, 1] = 63; data_temp[11, 2] = 63; data_temp[11, 3] = 49.9; data_temp[11, 4] = 49.9;
            data_temp[12, 0] = 0; data_temp[12, 1] = 60; data_temp[12, 2] = 60; data_temp[12, 3] = 50; data_temp[12, 4] = 50;
            data_temp[13, 0] = 0; data_temp[13, 1] = 60.8; data_temp[13, 2] = 60.8; data_temp[13, 3] = 48.5; data_temp[13, 4] = 48.5;


            for (int j = 3; j <= 7; j++)
                for (int i = 0; i < dgvTemptable.RowCount; i++)
                {
                    dgvTemptable.Rows[i].Cells[j].Value = data_temp[i, j - 3];
                }

        }
    }
        }


