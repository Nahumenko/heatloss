using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace heatLoss
{
    public partial class fFiveCalc : Form
    {
        // создаю рассчётный касс
        claculationFirst calc = new claculationFirst();
        //класс интерполяции
        linterp lin = new linterp();
        //передаю в него таблицу исходных данных

        public fFiveCalc()
        {
            InitializeComponent();

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            // проверка ввода
            // проверка ввода

            // основной алгоритм в кейсе
            if (cbType.SelectedIndex == 0 || cbType.SelectedIndex == 1)
            {
                // выборка суперпозиции
                bool superPoz;
                if (cbType.SelectedIndex == 0)
                    superPoz = true;
                else superPoz = false;
                //кол-во труб
                switch (cbPipeNumber.SelectedIndex)
                {
                    case -1:
                        MessageBox.Show("Выберите тип подземной прокладки", "Ошибка");
                        break;
                    //двухтрубная
                    case 0:
                        this.dgv_heatloss.DataSource = this.standardHeatLossTableAdapter.sql_hl_addDtSP(Convert.ToInt32(cbOutDiam.SelectedValue), cbYear.Checked, cbNhwInYear.Checked, superPoz, Convert.ToInt32(cbType.SelectedValue));
                        calc.twoTubesUnderground(cBoxDepth.Checked);
                        //заносим массив
                        double[,] heatLossMass = inMass(dgv_heatloss.RowCount, dgv_heatloss.ColumnCount);
                        //дополниттельная проверка на кол-во строк в массиве
                        if (heatLossMass.GetLength(0) != 0)
                        {
                            lblQ.Visible = true;
                            lblTemP.Visible = true;
                            lblTemP.Text = ("Значение Делта Т св = " + calc.deltaTcv);
                            //интерполяция
                            double q = lin.massiv(heatLossMass, calc.deltaTcv); // кушки куда-то нужно девать
                            lblQ.Text = ("Значение Ку Подз =" + q);
                            //График
                            chart1.Visible = true;
                            paintingChart(heatLossMass, calc.deltaTcv, q);
                            //вывод данных и дальнейший расчёт
                        }
                        else MessageBox.Show("В базе данных нет значений для заданых условий");
                        break;
                    //подача отдельно
                    case 1:
                        //таблица
                        this.dgv_heatloss.DataSource = this.standardHeatLossTableAdapter.sql_hl_addDtSP2(Convert.ToInt32(cbOutDiam.SelectedValue), cbYear.Checked, cbNhwInYear.Checked, superPoz, Convert.ToInt32(cbType.SelectedValue));
                        calc.onePipeUndergtound(Direction.FLOW, cBoxDepth.Checked);
                        //заносим массив
                        heatLossMass = inMass(dgv_heatloss.RowCount, dgv_heatloss.ColumnCount);
                        //дополниттельная проверка на кол-во строк в массиве
                        if (heatLossMass.GetLength(0) != 0)
                        {
                            lblQ.Visible = true;
                            lblTemP.Visible = true;
                            lblTemP.Text = ("Значение Делта Т1 подз = " + calc.deltaT1_podz);
                            //интерполяция
                            double q = lin.massiv(heatLossMass, calc.deltaT1_podz); // кушки куда-то нужно девать
                            lblQ.Text = ("Значение Ку1 Подз =" + q);
                            //График
                            chart1.Visible = true;
                            paintingChart(heatLossMass, calc.deltaT1_podz, q);
                            //вывод данных и дальнейший расчёт
                        }
                        else MessageBox.Show("В базе данных нет значений для заданых условий");
                        break;
                    case 2:
                        //таблица
                        this.dgv_heatloss.DataSource = this.standardHeatLossTableAdapter.sql_hl_addDtSP3(Convert.ToInt32(cbOutDiam.SelectedValue), cbYear.Checked, cbNhwInYear.Checked, superPoz, Convert.ToInt32(cbType.SelectedValue));
                        calc.onePipeUndergtound(Direction.RETURN, cBoxDepth.Checked);
                        //заносим массив
                        heatLossMass = inMass(dgv_heatloss.RowCount, dgv_heatloss.ColumnCount);
                        //дополниттельная проверка на кол-во строк в массиве
                        if (heatLossMass.GetLength(0) != 0)
                        {
                            lblQ.Visible = true;
                            lblTemP.Visible = true;
                            lblTemP.Text = ("Значение Делта Т2 подз = " + calc.deltaT2_podz);
                            //интерполяция
                            double q = lin.massiv(heatLossMass, calc.deltaT2_podz); // кушки куда-то нужно девать
                            lblQ.Text = ("Значение Ку2 Подз =" + q);
                            //График
                            chart1.Visible = true;
                            paintingChart(heatLossMass, calc.deltaT2_podz, q);
                            //вывод данных и дальнейший расчёт
                        }
                        else MessageBox.Show("В базе данных нет значений для заданых условий");
                        break;
                }
            }

            // месеж бокс условие воздушка 
            if (cbType.SelectedIndex == 3)
            {
                // вот по этим значениям нужно брать данные из таблицы
                double x = calc.deltaT1_vozd = calc.onePipeAir(Direction.FLOW);
                double xx = calc.deltaT2_vozd = calc.onePipeAir(Direction.RETURN);
                //заносим массив
                double[,] heatLossMass = inMass(dgv_heatloss.RowCount, dgv_heatloss.ColumnCount);
                //дополниттельная проверка на кол-во строк в массиве
                if (heatLossMass.GetLength(0) != 0)
                {

                    chart1.Series.Clear();
                    chart1.Series.Add("справочные значения");
                    chart1.Series[0].ChartType = SeriesChartType.Spline;
                    chart1.Series[0].MarkerStyle = MarkerStyle.Circle;
                    chart1.Series[0].BorderWidth = 50;
                    chart1.Series[0].LabelBorderWidth = 50;
                    chart1.Series[0].MarkerBorderWidth = 50;
                    for (int i = 0; i < heatLossMass.GetLength(0); i++)
                    {
                        chart1.Series[0].Points.AddXY(heatLossMass[i, 0], heatLossMass[i, 1]);
                    }
                    chart1.Series.Add("расчётные значения");
                    chart1.Series[1].ChartType = SeriesChartType.Point;
                    chart1.Series[1].MarkerStyle = MarkerStyle.Cross;
                    chart1.Series[1].Color = Color.Red;
                    chart1.Series[1].Points.AddXY(x, lin.massiv(heatLossMass, calc.deltaT1_vozd));
                    chart1.Series[1].Points.AddXY(xx, lin.massiv(heatLossMass, calc.deltaT2_vozd));
                    // интерпалируем значения взятые из таблицы и присваимваем ку1 и ку 2
                }
                else MessageBox.Show("В базе данных нет значений для заданого диаметра");

            }

        }

        private void fFiveCalc_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.methodOfLaying". При необходимости она может быть перемещена или удалена.
            this.methodOfLayingTableAdapter.Fill(this._BD01_02_2016DataSet.methodOfLaying);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.outsideDiameter". При необходимости она может быть перемещена или удалена.
            this.outsideDiameterTableAdapter.Fill(this._BD01_02_2016DataSet.outsideDiameter);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.deltaT". При необходимости она может быть перемещена или удалена.
            this.deltaTTableAdapter.Fill(this._BD01_02_2016DataSet.deltaT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.standardHeatLoss". При необходимости она может быть перемещена или удалена.
            this.standardHeatLossTableAdapter.Fill(this._BD01_02_2016DataSet.standardHeatLoss);
            // буру данные из переправы
            calc.tempTable = pereprava.tempTable;
            //сделать потом
            // this.dgv_heatloss.DataSource = this.standardHeatLossTableAdapter.sql_hl(Convert.ToInt32(cbType.SelectedValue), checkBox2.Checked, checkBox1.Checked, Convert.ToInt32(cboutD.SelectedValue));
            // проверка на властелина энергии
            if (pereprava.check)
            {
                checkBox3.Visible = true;
            }

            //провекра кол-ва труб в котловане
            cbPipeNumberCheck();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbType.SelectedIndex.ToString());
            //  this.dgv_heatloss.DataSource = this.standardHeatLossTableAdapter.sql_hl(cbType.SelectedIndex, checkBox2.Checked, checkBox1.Checked, Convert.ToInt32(tbDiametr.Text));
            this.dgv_heatloss.DataSource = this.standardHeatLossTableAdapter.sql_hl(Convert.ToInt32(cbType.SelectedValue), cbNhwInYear.Checked, cbYear.Checked, Convert.ToInt32(cbOutDiam.SelectedValue));

            // попробую всё заносить в массив 
            double[,] heatLossMass = new double[dgv_heatloss.RowCount, dgv_heatloss.ColumnCount];
            for (int i = 0; i < dgv_heatloss.RowCount; i++)
            {
                for (int j = 0; j < dgv_heatloss.ColumnCount; j++)
                {
                    heatLossMass[i, j] = Convert.ToDouble(dgv_heatloss[j, i].EditedFormattedValue);
                    // MessageBox.Show(heatLossMass[i, j].ToString());  
                }
            }
            // попробую всё заносить в массив 
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) { dgv_heatloss.Visible = true; }
            else { dgv_heatloss.Visible = false; }
        }
        //рисование графика
        private void paintingChart(double[,] mass, double t, double q)
        {
            chart1.Series.Clear(); // чищу на всякий пожарный
            chart1.Series.Add("справочные значения");
            chart1.Series[0].ChartType = SeriesChartType.Spline;
            chart1.Series[0].MarkerStyle = MarkerStyle.Circle;
            chart1.Series[0].BorderWidth = 3;
            chart1.Series[0].LabelBorderWidth = 3;
            chart1.Series[0].MarkerBorderWidth = 3;


            for (int i = 0; i < mass.GetLength(0); i++)
            {
                chart1.Series[0].Points.AddXY(mass[i, 0], mass[i, 1]);
            }
            chart1.Series.Add("расчётные значения");
            chart1.Series[1].Color = Color.GreenYellow;
            chart1.Series[1].MarkerSize = 15;
            chart1.Series[1].ChartType = SeriesChartType.Point;
            chart1.Series[1].MarkerStyle = MarkerStyle.Cross;
            chart1.Series[1].Points.AddXY(t, q);
        }
        //рисование графика перегрузка на две точки
        private void paintingChart(double[,] mass, double t0, double q0, double t1, double q1)
        {
            chart1.Series.Clear(); // чищу на всякий пожарный
            chart1.Series.Add("справочные значения");
            chart1.Series[0].ChartType = SeriesChartType.Spline;
            chart1.Series[0].MarkerStyle = MarkerStyle.Circle;
            chart1.Series[0].BorderWidth = 3;
            chart1.Series[0].LabelBorderWidth = 3;
            chart1.Series[0].MarkerBorderWidth = 3;
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                chart1.Series[0].Points.AddXY(mass[i, 0], mass[i, 1]);
            }
            chart1.Series.Add("расчётные значения");
            chart1.Series[1].Color = Color.GreenYellow;
            chart1.Series[1].MarkerSize = 15;
            chart1.Series[1].ChartType = SeriesChartType.Point;
            chart1.Series[1].MarkerStyle = MarkerStyle.Cross;
            chart1.Series[1].Points.AddXY(t0, q0);
            chart1.Series[1].Points.AddXY(t1, q1);
        }


        //провекра кол-ва труб в котловане на видимость
        private void cbPipeNumberCheck()
        {
            if (cbType.SelectedIndex == 0 || cbType.SelectedIndex == 1)
            {
                cbPipeNumber.Visible = true;
                cBoxDepth.Visible = true;
            }
            else
            {
                cbPipeNumber.Visible = false;
                cBoxDepth.Visible = false;
            }
        }
        //ввод данных из строки в масиив
        public double[,] inMass(int row, int col)
        {
            double[,] newMass = new double[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    newMass[i, j] = Convert.ToDouble(this.dgv_heatloss[j, i].EditedFormattedValue);
                }
            }
            return newMass;
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //провекра кол-ва труб в котловане
            cbPipeNumberCheck();
        }

        private void fFiveCalc_FormClosing(object sender, FormClosingEventArgs e)
        {
            lblQ.Visible = false;
            lblTemP.Visible = false;
            chart1.Visible = false;
        }


    }
}
